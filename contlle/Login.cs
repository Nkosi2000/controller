using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Data.OleDb;

namespace contlle
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public static string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }

       c
            ///-----------------------------------------------------------------///
            ///
           
            /*string hashedPassword = HashPassword(textBox2.Text.Trim());

          
            string query = "SELECT Roles FROM [Userz] WHERE [Emailz] = ? AND [Passwordz] = ?";
            using (OleDbConnection con = new OleDbConnection(connectionString))
            using (OleDbCommand cmd = new OleDbCommand(query, con))
            {
                cmd.Parameters.AddWithValue("?", textBox1.Text.Trim());
                cmd.Parameters.AddWithValue("?", HashPassword(textBox2.Text.Trim()));
                cmd.Parameters.AddWithValue("?", "Admin");

                try
                {
                    con.Open();
                    var result = cmd.ExecuteScalar();
                   
                    if (result != DBNull.Value && result != null)
                    {
                        string role = result.ToString();
                        MessageBox.Show("Login successful.");
                        this.Hide();
                        if (role == "Admin")
                            new AdminHome().Show();
                        else if (role =="")
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
            }*/

            ///---------------------------------------------------------///
            ///
           /* string query = "SELECT Rolez FROM [Userz] WHERE [Emailz] = ? AND [Passwordz] = ?";
            using (OleDbConnection con = new OleDbConnection(connectionString))
            using (OleDbCommand cmd = new OleDbCommand(query, con))
            {
                cmd.Parameters.AddWithValue("?", textBox1.Text.Trim());
                cmd.Parameters.AddWithValue("?", HashPassword(textBox2.Text.Trim()));
               // cmd.Parameters.AddWithValue("?", "Admin");

                try
                {
                    con.Open();
                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string role = reader["Rolez"].ToString();
                            MessageBox.Show("Login successful.");
                            this.Hide();
                            if (role == "Admin")
                                new AdminHome().Show();
                            else
                                new UserHome().Show();
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }*/




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
    }
}
