using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Theater
{
    public partial class Selections3 : Form
    {
        private readonly string connectionString = "Data Source=PC.db;Version=3;";

        public Selections3()
        {
            InitializeComponent();
            LoadDataIntoTableSample3();

        }

        private void LoadDataIntoTableSample3()
        {
            try
            {
                string query = @"SELECT Name, Version, Firm, Price
         FROM Product
         WHERE Type = 'серверные операционные системы'
         ORDER BY Applied DESC";

                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();
                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, connection))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        TableSample3.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading data: " + ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

    }
}
