using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace contlle
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var s = new Signup();
            s.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
        }

        private void pnlhome_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void logotext_Click(object sender, EventArgs e)
        {

        }
    }
}
