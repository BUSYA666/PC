using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Theater;

namespace PC
{
    public partial class Software : Form
    {
        private readonly string connectionString = "Data Source=PC.db;Version=3;";

        public Software()
        {
            InitializeComponent();
            SetTextBoxPlaceholders();
            Load += Software_Load;
        }
        private void Software_Load(object sender, EventArgs e)
        {
            // Call the method to load data into the table
            LoadDataIntoTableSoftware();
        }
        private void LoadDataIntoTableSoftware()
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string selectDataQuery = "SELECT * FROM Product";
                using (SQLiteCommand selectDataCommand = new SQLiteCommand(selectDataQuery, connection))
                {
                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(selectDataCommand))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        TableSoftware.DataSource = dataTable;
                        TableSoftware.Columns["Id"].Visible = false;

                    }
                }
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NameTextBox.Text) || string.IsNullOrWhiteSpace(VersionTextBox.Text) ||
             string.IsNullOrWhiteSpace(TypeTextBox.Text) || string.IsNullOrWhiteSpace(FirmTextBox.Text) ||
             string.IsNullOrWhiteSpace(DateTextBox.Text) || string.IsNullOrWhiteSpace(AppliedTextBox.Text) ||
             string.IsNullOrWhiteSpace(PriceTextBox.Text))

           {
                MessageBox.Show("Пожалуйста, заполните все поля.");
                return;
            }
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string insertDataQuery = "INSERT INTO Product (Name, Version, Type, Firm, Date, Applied, Price) VALUES (@Name, @Version, @Type, @Firm, @Date, @Applied, @Price)";
                using (SQLiteCommand insertDataCommand = new SQLiteCommand(insertDataQuery, connection))
                {
                    insertDataCommand.Parameters.AddWithValue("@Name", NameTextBox.Text);
                    insertDataCommand.Parameters.AddWithValue("@Version", VersionTextBox.Text);
                    insertDataCommand.Parameters.AddWithValue("@Type", TypeTextBox.Text);
                    insertDataCommand.Parameters.AddWithValue("@Firm", FirmTextBox.Text);
                    insertDataCommand.Parameters.AddWithValue("@Date", DateTextBox.Text);
                    insertDataCommand.Parameters.AddWithValue("@Applied", AppliedTextBox.Text);
                    insertDataCommand.Parameters.AddWithValue("@Price", PriceTextBox.Text);



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
                        LoadDataIntoTableSoftware();

                        NameTextBox.Text = "";
                        VersionTextBox.Text = "";
                        TypeTextBox.Text = "";
                        FirmTextBox.Text = "";
                        DateTextBox.Text = "";
                        AppliedTextBox.Text = "";
                        PriceTextBox.Text = "";



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
            NameTextBox.Text = "Введите Имя";
            NameTextBox.ForeColor = Color.Black;

            VersionTextBox.Text = "Введите версию";
            VersionTextBox.ForeColor = Color.Black;

            TypeTextBox.Text = "Тип программы";
            TypeTextBox.ForeColor = Color.Black;

            FirmTextBox.Text = "Фирма";
            FirmTextBox.ForeColor = Color.Black;

            DateTextBox.Text = "Дата выпуcка";
            DateTextBox.ForeColor = Color.Black;

            AppliedTextBox.Text = "Прикладная область";
            AppliedTextBox.ForeColor = Color.Black;

            PriceTextBox.Text = "Стоимость";
            PriceTextBox.ForeColor = Color.Black;



        }

        private void NameTextBox_Enter(object sender, EventArgs e)
        {
            if (NameTextBox.Text == "Введите Имя")
            {
                NameTextBox.Text = "";
                NameTextBox.ForeColor = Color.Black;
            }
        }

        private void NameTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NameTextBox.Text) || NameTextBox.Text == "Введите Имя")
            {
                NameTextBox.Text = "Введите Имя";
                NameTextBox.ForeColor = Color.Black;
            }
        }

        private void VersionTextBox_Enter(object sender, EventArgs e)
        {
            if (VersionTextBox.Text == "Введите версию")
            {
                VersionTextBox.Text = "";
                VersionTextBox.ForeColor = Color.Black;
            }
        }

        private void VersionTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(VersionTextBox.Text) || VersionTextBox.Text == "Введите версию")
            {
                VersionTextBox.Text = "Введите версию";
                VersionTextBox.ForeColor = Color.Black;
            }
        }

        private void TypeTextBox_Enter(object sender, EventArgs e)
        {
            if (TypeTextBox.Text == "Тип программы")
            {
                TypeTextBox.Text = "";
                TypeTextBox.ForeColor = Color.Black;
            }
        }

        private void TypeTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TypeTextBox.Text) || TypeTextBox.Text == "Тип программы")
            {
                TypeTextBox.Text = "Тип программы";
                TypeTextBox.ForeColor = Color.Black;
            }
        }

        private void FirmTextBox_Enter(object sender, EventArgs e)
        {
            if (FirmTextBox.Text == "Фирма")
            {
                FirmTextBox.Text = "";
                FirmTextBox.ForeColor = Color.Black;
            }
        }

        private void FirmTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(FirmTextBox.Text) || FirmTextBox.Text == "Фирма")
            {
                FirmTextBox.Text = "Фирма";
                FirmTextBox.ForeColor = Color.Black;
            }
        }

        private void AppliedTextBox_Enter(object sender, EventArgs e)
        {
            if (AppliedTextBox.Text == "Прикладная область")
            {
                AppliedTextBox.Text = "";
                AppliedTextBox.ForeColor = Color.Black;
            }
        }

        private void AppliedTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(AppliedTextBox.Text) || AppliedTextBox.Text == "Прикладная область")
            {
                AppliedTextBox.Text = "Прикладная область";
                AppliedTextBox.ForeColor = Color.Black;
            }
        }

        private void PriceTextBox_Enter(object sender, EventArgs e)
        {
            if (PriceTextBox.Text == "Стоимость")
            {
                PriceTextBox.Text = "";
                PriceTextBox.ForeColor = Color.Black;
            }
        }

        private void PriceTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(PriceTextBox.Text) || PriceTextBox.Text == "Стоимость")
            {
                PriceTextBox.Text = "Стоимость";
                PriceTextBox.ForeColor = Color.Black;
            }
        }       
        private void DateTextBox_Enter(object sender, EventArgs e)
        {
            if (DateTextBox.Text == "Дата выпуcка")
            {
                DateTextBox.Text = "";
                DateTextBox.ForeColor = Color.Black;
            }
        }

        private void DateTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(DateTextBox.Text) || DateTextBox.Text == "Дата выпуcка")
            {
                DateTextBox.Text = "Дата выпуcка";
                DateTextBox.ForeColor = Color.Black;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TableSoftware.SelectedRows.Count == 0)
            {
                MessageBox.Show("Пожалуйста, выберите строку для удаления.");
                return;
            }

            DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить выбранную запись?", "Подтверждение удаления", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                var selectedId = Convert.ToInt32(TableSoftware.SelectedRows[0].Cells["Id"].Value);
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string deleteDataQuery = "DELETE FROM Product WHERE Id = @Id";
                    using (SQLiteCommand deleteDataCommand = new SQLiteCommand(deleteDataQuery, connection))
                    {
                        deleteDataCommand.Parameters.AddWithValue("@Id", selectedId);
                        deleteDataCommand.ExecuteNonQuery();

                        LoadDataIntoTableSoftware();

                        MessageBox.Show("Запись успешно удалена!");
                    }

                    connection.Close();
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
