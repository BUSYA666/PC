using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using Theater;

namespace PC
{
    public partial class Installation : Form
    {
        private readonly string connectionString = "Data Source=PC.db;Version=3;";

        public Installation()
        {
            InitializeComponent();
            LoadDataIntoTableInstallation();
            SetTextBoxPlaceholders();
        }

        private void LoadDataIntoTableInstallation()
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string selectDataQuery = "SELECT * FROM Installer";
                using (SQLiteCommand selectDataCommand = new SQLiteCommand(selectDataQuery, connection))
                {
                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(selectDataCommand))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        TableInstallation.DataSource = dataTable;
                        TableInstallation.Columns["Id"].Visible = false;

                    }
                }
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NameUserTextBox.Text) || string.IsNullOrWhiteSpace(PriceTextBox.Text) ||
             string.IsNullOrWhiteSpace(DateInstallerBox.Text) || string.IsNullOrWhiteSpace(DateDeinstalerBox.Text) ||
             string.IsNullOrWhiteSpace(QuantityLicTextBox.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.");
                return;
            }
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string insertDataQuery = "INSERT INTO Installer (NameUser, Price, DateInstaller, DateDeinstaler, QuantityLic) VALUES (@NameUser, @Price, @DateInstaller, @DateDeinstaler, @QuantityLic)";
                using (SQLiteCommand insertDataCommand = new SQLiteCommand(insertDataQuery, connection))
                {
                    insertDataCommand.Parameters.AddWithValue("@NameUser", NameUserTextBox.Text);
                    insertDataCommand.Parameters.AddWithValue("@Price", PriceTextBox.Text);
                    insertDataCommand.Parameters.AddWithValue("@DateInstaller", DateInstallerBox.Text);
                    insertDataCommand.Parameters.AddWithValue("@DateDeinstaler", DateDeinstalerBox.Text);
                    insertDataCommand.Parameters.AddWithValue("@QuantityLic", QuantityLicTextBox.Text);


                    const int maxRetries = 5;
                    int retries = 0;
                    bool success = false;

                    while (retries < maxRetries)
                    {
                        try
                        {
                            insertDataCommand.ExecuteNonQuery();
                            success = true;
                            break;
                        }
                        catch (SQLiteException ex)
                        {
                            if (ex.ErrorCode == (int)SQLiteErrorCode.Locked)
                            {
                                Thread.Sleep(1000);
                            }
                            else
                            {
                                MessageBox.Show("Произошла ошибка при сохранении данных: " + ex.Message);
                                success = false;
                                break;
                            }
                        }

                        retries++;
                    }

                    if (success)
                    {
                        LoadDataIntoTableInstallation();

                        NameUserTextBox.Text = "";
                        PriceTextBox.Text = "";
                        DateInstallerBox.Text = "";
                        DateDeinstalerBox.Text = "";
                        QuantityLicTextBox.Text = "";


                        SetTextBoxPlaceholders();

                        MessageBox.Show("Данные сохранены!");
                    }
                    else
                    {
                        MessageBox.Show("Не удалось сохранить данные. Попробуйте еще раз позже.");
                    }
                }

                connection.Close();
            }
        }
        private void SetTextBoxPlaceholders()
        {
            NameUserTextBox.Text = "Введите Имя";
            NameUserTextBox.ForeColor = Color.Black;

            PriceTextBox.Text = "Введите цену";
            PriceTextBox.ForeColor = Color.Black;

            QuantityLicTextBox.Text = "Количество лицензий";
            QuantityLicTextBox.ForeColor = Color.Black;

            DateInstallerBox.Text = "Дата установки";
            DateInstallerBox.ForeColor = Color.Black;

            DateDeinstalerBox.Text = "Дата деинсталляции";
            DateDeinstalerBox.ForeColor = Color.Black;


        }

        private void NameUserTextBox_Enter(object sender, EventArgs e)
        {
            if (NameUserTextBox.Text == "Введите Имя")
            {
                NameUserTextBox.Text = "";
                NameUserTextBox.ForeColor = Color.Black;
            }
        }

        private void NameUserTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NameUserTextBox.Text))
            {
                NameUserTextBox.Text = "Введите Имя";
                NameUserTextBox.ForeColor = Color.Black;
            }
        }

        private void PriceTextBox_Enter(object sender, EventArgs e)
        {
            if (PriceTextBox.Text == "Введите цену")
            {
                PriceTextBox.Text = "";
                PriceTextBox.ForeColor = Color.Black;
            }
        }

        private void PriceTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(PriceTextBox.Text))
            {
                PriceTextBox.Text = "Введите цену";
                PriceTextBox.ForeColor = Color.Black;
            }
        }

        private void QuantityLicTextBox_Enter(object sender, EventArgs e)
        {
            if (QuantityLicTextBox.Text == "Количество лицензий")
            {
                QuantityLicTextBox.Text = "";
                QuantityLicTextBox.ForeColor = Color.Black;
            }
        }

        private void QuantityLicTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(QuantityLicTextBox.Text))
            {
                QuantityLicTextBox.Text = "Количество лицензий";
                QuantityLicTextBox.ForeColor = Color.Black;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TableInstallation.SelectedRows.Count == 0)
            {
                MessageBox.Show("Пожалуйста, выберите строку для удаления.");
                return;
            }

            DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить выбранную запись?", "Подтверждение удаления", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                var selectedId = Convert.ToInt32(TableInstallation.SelectedRows[0].Cells["Id"].Value);
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string deleteDataQuery = "DELETE FROM Installer WHERE Id = @Id";
                    using (SQLiteCommand deleteDataCommand = new SQLiteCommand(deleteDataQuery, connection))
                    {
                        deleteDataCommand.Parameters.AddWithValue("@Id", selectedId);
                        deleteDataCommand.ExecuteNonQuery();

                        LoadDataIntoTableInstallation();

                        MessageBox.Show("Запись успешно удалена!");
                    }

                    connection.Close();
                }
            }
        }
      
    }
}
