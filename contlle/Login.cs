using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace contlle
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        
            {
                string connectionString = ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
                string query = "SELECT COUNT(*) FROM [Users] WHERE [EmailAddress] = @EmailAddress AND [Password] = @Password";

                using (SqlConnection con = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@EmailAddress", txtEmailAddress.Text.Trim());
                    cmd.Parameters.AddWithValue("@Password", txtPassword.Text.Trim());

                    try
                    {
                        con.Open();
                        int userCount = Convert.ToInt32(cmd.ExecuteScalar());

                        if (userCount > 0)
                        {
                            //MessageBox.Show("Login successful.");
                            // Proceed to the main application form
                            this.Hide();
                            new UserHome().Show();
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred: {ex.Message}");
                    }
                }
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new Signup().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Home().Show();
        }

        private void lnkX_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new Home().Show();
        }
    }
}
