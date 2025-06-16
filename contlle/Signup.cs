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
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\SlYA\\source\\repos\\contlle\\Database\\Icontrol.accdb");
        private void button1_Click(object sender, EventArgs e)
        {
            /* con.Open();
             if (con.State == ConnectionState.Open)
             {
                 //try
                 //{
                     string name = textBox1.Text;
                     string nmbe = textBox2.Text;
                     string emal = textBox3.Text;
                     string pass1 = textBox4.Text;
                     string pass2 = textBox5.Text;

                     if (name == null)
                     {
                         MessageBox.Show("Enter Name!");
                     }
                     if (nmbe == null)
                     {
                         MessageBox.Show("Enter Phone!");
                     }
                     if (emal == null)
                     {
                         MessageBox.Show("Enter Email!");
                     }
                     if (pass1 == null)
                     {
                         MessageBox.Show("Enter Password!");
                     }
                     if (pass2 == null)
                     {
                         MessageBox.Show("Enter Confirmed Password!");
                     }
                     if (pass2 != pass1)
                     {
                         MessageBox.Show("Password Do Not Match!");
                     }

                     string query = "Insert into User (ID,Fullname,Number,Email,Password) values ('" + textBox1.Text.Trim() + "','" + textBox2.Text.Trim() + "','" + textBox3.Text.Trim() + "','" + textBox4.Text.Trim() + "')";
                  OleDbCommand cmd = new OleDbCommand(query, con);

                /* cmd.Parameters.AddWithValue(@"Name", OleDbType.VarChar).Value = name;
                 cmd.Parameters.AddWithValue(@"Number", OleDbType.VarChar).Value = nmbe;
                 cmd.Parameters.AddWithValue(@"Email", OleDbType.VarChar).Value = emal;
                 cmd.Parameters.AddWithValue(@"Password", OleDbType.VarChar).Value = pass1;
                 cmd.ExecuteNonQuery();
                 cmd.Parameters.AddWithValue("@fName", textBox1.Text);
                     cmd.Parameters.AddWithValue("@num", textBox2.Text);
                     cmd.Parameters.AddWithValue("@eml", textBox3.Text);
                     cmd.Parameters.AddWithValue("@passW", textBox4.Text);*/
            // cmd.ExecuteNonQuery();

            //con.Open();

            // }
            // catch (Exception error)
            // {
            // MessageBox.Show($"Error: {ex.Message}");
            //}
            // con.Close();
            //}*/

            //open connection
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
               // textBox4.PasswordChar = '*';
                //textBox5.PasswordChar = '*';

               
                //inserting records
                string query = "INSERT INTO [Userz] ([Fullnamez], [Numberz], [Emailz], [Passwordz],[Roles]) VALUES ( ?, ?, ?, ?,?)";

                using (OleDbCommand cmd = new OleDbCommand(query, con))
                {
                    string user = "User";
                    //cmd.Parameters.AddWithValue(" ");
                    cmd.Parameters.AddWithValue("?", nam);
                    cmd.Parameters.AddWithValue("?", nmbe);
                    cmd.Parameters.AddWithValue("?", emal);
                    cmd.Parameters.AddWithValue("?", pass1);
                    cmd.Parameters.AddWithValue("?",user);

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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox4.PasswordChar = checkBox1.Checked ? '\0' : '*'; // '\0' shows the password, '*' hides it
            textBox5.PasswordChar = checkBox1.Checked ? '\0' : '*'; // '\0' shows the password, '*' hides it
        }
    }
    
    

}
