using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Data.OleDb;

namespace contlle
{
    public partial class AdminRqstSolar : Form
    {
        public AdminRqstSolar()
        {
            InitializeComponent();
        }
        string connString ="Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\SlYA\\source\\repos\\contlle\\Database\\Icontrol.accdb" ;
        private void button1_Click(object sender, EventArgs e)
        {
            string searchTerm = textBox1.Text.Trim();
             if (string.IsNullOrEmpty(searchTerm))
             {
                 MessageBox.Show("Please enter a search term.");
                   return;
             }

                string query = "SELECT Email FROM Users WHERE UserID = ?";
                using (OleDbConnection con = new OleDbConnection(connString))
            using (OleDbCommand cmd = new OleDbCommand(query, con))
            {
                cmd.Parameters.AddWithValue("?", searchTerm);

        try
        {
            con.Open();
            object result = cmd.ExecuteScalar();
            if (result != null)
            {
                textBox2.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("No email found for the given user.");
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error retrieving data: " + ex.Message);
        }
        
        }
        
        
     }
    
    
    }
}
