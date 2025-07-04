using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace contlle.staff_portal
{
    public partial class StaffPortalControl1 : UserControl
    {
        public event EventHandler BackLinkClicked;

        public StaffPortalControl1()
        {
            InitializeComponent();
        }

        private void lnkX_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            BackLinkClicked?.Invoke(this, EventArgs.Empty);
            pnlStaffPortal.Controls.Clear();

            //pnlStaffPortal.Visible = false;

            // pnlFORSTAFF.Visible = true;
            // pnlFORSTAFF.Visible = fasle;
            // panel4.Visible = false;
        }

        private void pnlStaffPortal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string staffNumber = txtStaffNumber.Text.Trim();
            string staffEmail = txtStaffEmailAddress.Text.Trim();

            if (string.IsNullOrWhiteSpace(staffNumber) || string.IsNullOrWhiteSpace(staffEmail))
            {
                MessageBox.Show("Please enter both Staff Number and Email.");
                return;
            }

            string connectionString = ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
            string query = "SELECT StaffRole FROM Roles WHERE StaffNumber = @staffNumber AND StaffEmail = @staffEmail";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@staffNumber", staffNumber);
                cmd.Parameters.AddWithValue("@staffEmail", staffEmail);

                conn.Open();
                var result = cmd.ExecuteScalar();

                if (result != null)
                {
                    string role = result.ToString();

                    //MessageBox.Show($"Welcome {role}!");

                    // Grab the parent form that hosts the UserControl
                    Form parentForm = this.FindForm();

                    // Hide the login UserControl and the whole form
                    this.Visible = false;
                    parentForm?.Hide();

                    // Launch dashboard based on role
                    Form dashboardForm = null;


                    switch (role.ToLower())
                    {
                        case "admin":
                            dashboardForm = new AdminHome();
                            break;
                        case "supervisor":
                            dashboardForm = new SupervisorHome();
                            break;
                        case "technician":
                            dashboardForm = new TechnicianHome();
                            break;
                        default:
                            MessageBox.Show("Unknown role. Cannot proceed.");
                            this.Visible = true;
                            parentForm?.Show();
                            return;
                    }
                    dashboardForm.Show();
                }
                else
                {
                    MessageBox.Show("Invalid login details.");
                }
            }

        }

        private void txtStaffEmailAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtStaffNumber_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
