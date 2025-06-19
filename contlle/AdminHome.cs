using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using contlle.admin_controls;

namespace contlle
{
    public partial class AdminHome : Form
    {
       
        public AdminHome()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            Text = "1";
            Text = "2";
        }

        private void AdminHome_Load(object sender, EventArgs e)
        {

        }

        private void lblEmailto_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        // -------------------------------------------------------------------------------------
        // AdminDashboard
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            LoadAdminDashboardScreen(new AdminDashboardControl1());
        }

        private void LoadAdminDashboardScreen(Control screen)
        {
            
            mainPanel.Controls.Clear();
            screen.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(screen);
        }

        // AdminManageUsers
        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            LoadAdminManageUsersScreen(new AdminManageUsersControl1());
        }

        private void LoadAdminManageUsersScreen(Control screen)
        {
            mainPanel.Controls.Clear();
            screen.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(screen);
        }

        // AdminMakeSubmitions
        private void btnMakeSubmitions_Click(object sender, EventArgs e)
        {
            LoadAdminManageUsersScreen(new AdminMakeSubmitionsControl1());
        }

        private void LoadAdminMakeSubmitionsScreen(Control screen)
        {
            mainPanel.Controls.Clear();
            screen.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(screen);
        }

        // AdminTrackProcedures
        private void btnTrackProcedures_Click(object sender, EventArgs e)
        {
            LoadAdminTrackProceduresScreen(new AdminTrackProceduresControl1());
        }

        private void LoadAdminTrackProceduresScreen(Control screen)
        {
            mainPanel.Controls.Clear();
            screen.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(screen);
        }

        // AdminTrackTransactions
        private void btnTrackTransactions_Click(object sender, EventArgs e)
        {
            LoadAdminTrackTransaction(new AdminTrackTransactionsControl1());
        }

        private void LoadAdminTrackTransaction(Control screen)
        {
            mainPanel.Controls.Clear();
            screen.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(screen);
        }

        // AdminManageReports
        private void btnManageReports_Click(object sender, EventArgs e)
        {
            LoadAdminManageReports(new AdminManageReportsControl1());
        }

        private void LoadAdminManageReports(Control screen)
        {
            mainPanel.Controls.Clear();
            screen.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(screen);
        }
        // -------------------------------------------------------------------------------------

        bool sidebarExpand = true;

        private void SliderTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand) 
            {
                sidebar.Width -= 10;
                if (sidebar.Width <= 55) 
                {
                    sidebarExpand = false;
                    SliderTransition.Stop();
                }
            }
            else {
                sidebar.Width += 10;
                if (sidebar.Width >= 238)
                {
                    sidebarExpand = true;
                    SliderTransition.Stop();
                }
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            SliderTransition.Start();
        }
    }
}
