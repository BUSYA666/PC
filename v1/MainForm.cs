using PC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Theater
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Selections selections = new Selections();
            selections.Show();
            this.Hide();
        }

        private void InstallationButton_Click(object sender, EventArgs e)
        {
            Installation installation = new Installation();
            installation.Show();
            this.Hide();
        }

        private void SoftwareButton_Click(object sender, EventArgs e)
        {
            Software software = new Software();
            software.Show();
            this.Hide();
        }
    }
    }
