using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;


namespace contlle
{
    public partial class UserHome : Form
    {
         
        public UserHome()
        {
            InitializeComponent();
             // Start battery monitoring

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Home().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new RequestSolar().Show();
        }
    }
}
