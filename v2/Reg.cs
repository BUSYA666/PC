using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Theater
{
    public partial class Reg : Form
    {
        private readonly string connectionString = "Data Source=PC.db;Version=3;";

        public Reg()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string login = LoginField.Text;
            string pass = passField.Text;

            // Проверка, если поля логина и пароля пусты
            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("Введите логин и пароль.");
                return;
            }

            // Проверка, если такой пользователь уже существует
            string checkUserSql = "SELECT COUNT(*) FROM Auth WHERE login=@login";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand checkUserCommand = new SQLiteCommand(checkUserSql, connection))
                {
                    checkUserCommand.Parameters.AddWithValue("@login", login);
                    int userCount = Convert.ToInt32(checkUserCommand.ExecuteScalar());
                    if (userCount > 0)
                    {
                        MessageBox.Show("Такой пользователь уже существует.");
                        return;
                    }
                }
            }

            // Регистрация нового пользователя
            string insertUserSql = "INSERT INTO Auth (Login, Pass) VALUES (@login, @pass)";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (SQLiteCommand insertUserCommand = new SQLiteCommand(insertUserSql, connection))
                {
                    insertUserCommand.Parameters.AddWithValue("@login", login);
                    insertUserCommand.Parameters.AddWithValue("@pass", pass);
                    int rowsAffected = insertUserCommand.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Регистрация прошла успешно.");

                        // Добавление нового пользователя
                        string name = NameField.Text;
                        string region = Region.Text;
                        string sphere = Sphere.Text;

                        string insertUserDetailsSql = "INSERT INTO Users (Name, Region, Sphere) VALUES (@Name, @region, @sphere)";
                        using (SQLiteCommand insertUserDetailsCommand = new SQLiteCommand(insertUserDetailsSql, connection))
                        {
                            insertUserDetailsCommand.Parameters.AddWithValue("@Name", name);
                            insertUserDetailsCommand.Parameters.AddWithValue("@region", region);
                            insertUserDetailsCommand.Parameters.AddWithValue("@sphere", sphere);


                            try
                            {
                                rowsAffected = insertUserDetailsCommand.ExecuteNonQuery();
                                MessageBox.Show("Новый пользователь успешно добавлен.");
                                // Код для входа обычного пользователя
                                Form fAuthorization = new MainForm();
                                fAuthorization.Show();
                                fAuthorization.FormClosed += new FormClosedEventHandler(form_FormClosed);
                                this.Hide();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Ошибка при добавлении нового пользователя: " + ex.Message);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ошибка при регистрации пользователя.");
                    }
                }
            }
        }

        private void form_FormClosed(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}