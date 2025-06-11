using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.OleDb;

namespace contlle
{
    public partial class ForgotPassword : Form
    {
        public ForgotPassword()
        {
            InitializeComponent();
        }
        private string GenerateResetToken()
        {
            using (var rng = new System.Security.Cryptography.RNGCryptoServiceProvider())
            {
                byte[] tokenData = new byte[32];
                rng.GetBytes(tokenData);
                return Convert.ToBase64String(tokenData);
            }
        }

        private void SendResetEmail(string email, string resetToken)
        {
            string resetLink = $"http://yourdomain.com/resetpassword?token={resetToken}";
            string subject = "Password Reset Request";
            string body = $"Please click the following link to reset your password: {resetLink}";

            using (var smtpClient = new System.Net.Mail.SmtpClient("smtp.yourprovider.com"))
            {
                var mailMessage = new System.Net.Mail.MailMessage("no-reply@yourdomain.com", email, subject, body);
                smtpClient.Send(mailMessage);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            
                string email = textBox1.Text.Trim();
                if (string.IsNullOrEmpty(email))
                {
                    label2.Text = "Please enter your email address.";
                    return;
                }

                string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\SlYA\source\repos\contlle\Database\Icontrol.accdb";
                string query = "SELECT [ID], [Fullnamez] FROM [Userz] WHERE [Emailz] = ?";

                using (OleDbConnection con = new OleDbConnection(connectionString))
                using (OleDbCommand cmd = new OleDbCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("?", email);

                    try
                    {
                        con.Open();
                        using (OleDbDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int userId = reader.GetInt32(0);
                                string fullname = reader.GetString(1);
                                string resetToken = GenerateResetToken();
                                DateTime tokenExpiry = DateTime.Now.AddHours(1);

                                // Update the database with the reset token and expiry
                                string updateQuery = "UPDATE [Userz] SET [PasswordResetToken] = ?, [TokenExpiry] = ? WHERE [ID] = ?";
                                using (OleDbCommand updateCmd = new OleDbCommand(updateQuery, con))
                                {
                                    updateCmd.Parameters.AddWithValue("?", resetToken);
                                    updateCmd.Parameters.AddWithValue("?", tokenExpiry);
                                    updateCmd.Parameters.AddWithValue("?", userId);
                                    updateCmd.ExecuteNonQuery();
                                }

                                // Send the reset email
                                SendResetEmail(email, resetToken);
                                label2.Text = "A password reset link has been sent to your email.";
                            }
                            else
                            {
                                label2.Text = "No account found with that email address.";
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        label2.Text = $"Error: {ex.Message}";
                    }
                }
            

        }
    }
}
