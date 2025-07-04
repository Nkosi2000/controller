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
using contlle.staff_portal;
using contlle;


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

                string connectionString = ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
                string query = "SELECT COUNT(*) FROM [Users] WHERE [EmailAddress] = @EmailAddress AND [Password] = @Password";

                using (SqlConnection con = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@EmailAddress", txtEmailAddress.Text.Trim());
                    cmd.Parameters.AddWithValue("@Password", txtPassword.Text.Trim());

          

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

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            panel4.Visible = true;
            btnDashboard.Visible = false;
            lblStaffPortal.Visible = false;
            LoadStaffPortScreen(new StaffPortalControl1());
        }

        private void LoadStaffPortScreen(Control screen)
        {
            panel4.Controls.Clear();
            screen.Dock = DockStyle.Fill;
            panel4.Controls.Add(screen);

            if (screen is StaffPortalControl1 staffPortal)
            {
                staffPortal.BackLinkClicked += StaffPortal_BackLinkClicked;
            }
        }

        private void StaffPortal_BackLinkClicked(object sender, EventArgs e)
        {
       
            panel4.Visible = false;
            btnDashboard.Visible = true;
            lblStaffPortal.Visible = true;

            //pnlStaffPortal.Visible = true;
            //pnlFORSTAFF.Controls.Clear();
        }


        private void lblLogin_Click(object sender, EventArgs e)
        {

        }
    }
}
