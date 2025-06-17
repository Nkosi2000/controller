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
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {

            string connectionString = ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string fullname = txtFullName.Text.Trim();
                string phonenumber = txtPhoneNumber.Text.Trim();
                string emailaddress = txtEmailAddress.Text.Trim();
                string createpassword = txtCreatePassword.Text.Trim();
                string confirmpassword = txtConfirmPassword.Text.Trim();

                // Validate user inputs
                if (string.IsNullOrEmpty(fullname) || string.IsNullOrEmpty(phonenumber) || string.IsNullOrEmpty(emailaddress) || string.IsNullOrEmpty(createpassword) || string.IsNullOrEmpty(confirmpassword))
                {
                    MessageBox.Show("All fields are required.");
                    return;
                }

                if (createpassword != confirmpassword)
                {
                    MessageBox.Show("Passwords do not match.");
                    return;
                }

                string query = "INSERT INTO [Users] ([FullName], [PhoneNumber], [EmailAddress], [Password]) VALUES (@FullName, @PhoneNumber, @EmailAddress, @Password)";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("FullName", fullname);
                    cmd.Parameters.AddWithValue("PhoneNumber", phonenumber);
                    cmd.Parameters.AddWithValue("EmailAddress", emailaddress);
                    cmd.Parameters.AddWithValue("Password", confirmpassword);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("User registered successfully.");
                        this.Hide();
                        new Login().Show();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}");
                    }
                }
            }
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new Login().Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new Home().Show();
        }

        private void Signup_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
