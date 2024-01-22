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
    public partial class Selections1 : Form
    {
        private readonly string connectionString = "Data Source=PC.db;Version=3;";

        public Selections1()
        {
            InitializeComponent();
            LoadDataIntoTableSample();
        }

        private void LoadDataIntoTableSample()
        {
            try
            {
                string query = @"SELECT Applied, COUNT(*) AS NumberOfProducts
                        FROM Product
                        GROUP BY Applied
                        ORDER BY NumberOfProducts DESC
                        LIMIT 1";

                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();
                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, connection))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        TableSample.DataSource = dataTable;
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
