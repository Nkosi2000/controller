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
using System.Security.Cryptography;

namespace contlle
{
    public partial class AdminSignup : Form
    {
        public AdminSignup()
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
        private void button1_Click(object sender, EventArgs e)
        {
           
          
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            textBox2.PasswordChar = checkBox1.Checked ? '\0' : '*'; // '\0' shows the password, '*' hides it
            textBox3.PasswordChar = checkBox1.Checked ? '\0' : '*'; // '\0' shows the password, '*' hides it
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            using (OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\SlYA\\source\\repos\\contlle\\Database\\Icontrol.accdb"))
            {
                con.Open();
                string nam = textBox1.Text.Trim();
                string nmbe = textBox2.Text.Trim();
                string emal = textBox3.Text.Trim();
                string pass1 = textBox4.Text.Trim();
                string pass2 = textBox5.Text.Trim();

                string checkQuery = "SELECT COUNT(*) FROM [Userz] WHERE [Emailz] = ?";
                using (OleDbCommand checkCmd = new OleDbCommand(checkQuery, con))
                {
                    checkCmd.Parameters.Add("?", OleDbType.VarWChar, 255).Value = emal;
                    int count = Convert.ToInt32(checkCmd.ExecuteScalar());
                    if (count > 0)
                    {
                        MessageBox.Show("Email is already registered.");
                        return;
                    }
                }


                // Validate user inputs
                if (string.IsNullOrEmpty(nam) || string.IsNullOrEmpty(nmbe) || string.IsNullOrEmpty(emal) || string.IsNullOrEmpty(pass1) || string.IsNullOrEmpty(pass2))
                {
                    MessageBox.Show("All fields are required.");
                    return;
                }

                //Checking email format ---
                try
                {
                    var mail = new MailAddress(emal);

                }
                catch (FormatException)
                {
                    MessageBox.Show("Invalid email address.");
                }

                //----------------------------------------------------------------

                if (pass1 != pass2)
                {
                    MessageBox.Show("Passwords do not match.");
                    return;
                }
                textBox4.PasswordChar = '*';
                textBox5.PasswordChar = '*';

                string query = "INSERT INTO [Userz] ([Fullnamez], [Numberz], [Emailz], [Passwordz],[Roles]) VALUES ( ?, ?, ?, ?,?)";

                using (OleDbCommand cmd = new OleDbCommand(query, con))
                {
                    string user = "Admin";
                    //cmd.Parameters.AddWithValue(" ");
                    cmd.Parameters.AddWithValue("?", nam);
                    cmd.Parameters.AddWithValue("?", nmbe);
                    cmd.Parameters.AddWithValue("?", emal);
                    cmd.Parameters.AddWithValue("?", pass1);
                    cmd.Parameters.AddWithValue("?", user);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("User registered successfully.");
                        this.Hide();
                        new AdminHome().Show();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}");
                    }
                }
            }
        }
    }
}
