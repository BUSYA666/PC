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
    public partial class Selections : Form
    {
        public Selections()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Selections1 selections1 = new Selections1();
            selections1.Show();
            this.Hide();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Selections2 selections2 = new Selections2();
            selections2.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Selections3 selections3 = new Selections3();
            selections3.Show();
            this.Hide();
        }
    }
}
