using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using contlle.supervisor_controls;

namespace contlle
{
    public partial class SupervisorHome : Form
    {
        public SupervisorHome()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

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
            else
            {
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

        // -------------------------------------------------------------------------------------
        // Dashboard
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            LoadDashboard(new SupervisorDashboardControl1());
        }

        private void LoadDashboard(Control screen)
        {
            mainPanel.Controls.Clear();
            screen.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(screen);
        }

        // Manage Users
        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            LoadManageUsers(new SupervisorManageUsersControl1());
        }

        private void LoadManageUsers(Control screen)
        {
            mainPanel.Controls.Clear();
            screen.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(screen);
        }

        // Assign Schedule
        private void btnAssignSchedule_Click(object sender, EventArgs e)
        {
            LoadAssignSchedule(new SupervisorAssignScheduleControl1());
        }

        private void LoadAssignSchedule(Control screen)
        {
            mainPanel.Controls.Clear();
            screen.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(screen);
        }

        // Schedule Evaluation
        private void btnScheduleEvaluation_Click(object sender, EventArgs e)
        {
            LoadScheduleEvaluation(new SupervisorScheduleEvaluationControl1());
        }

        private void LoadScheduleEvaluation(Control screen)
        {
            mainPanel.Controls.Clear();
            screen.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(screen);
        }

        // Staff Reports
        private void btnStaffReports_Click(object sender, EventArgs e)
        {
            LoadStaffReports(new SupervisorStaffReportsControl1());
        }

        private void LoadStaffReports(Control screen)
        {
            mainPanel.Controls.Clear();
            screen.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(screen);
        }

        // Transactions Report
        private void btnTransactionsReport_Click(object sender, EventArgs e)
        {
            LoadTransactionReports(new SpvTransactionsReportControl1());
        }

        private void LoadTransactionReports(Control screen)
        {
            mainPanel.Controls.Clear();
            screen.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(screen);
        }

        // Stock Reports
        private void btnStockReport_Click(object sender, EventArgs e)
        {
            LoadStockReports(new SpvStockReportsControl1());
        }

        private void LoadStockReports(Control screen)
        {
            mainPanel.Controls.Clear();
            screen.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(screen);
        }
        // -------------------------------------------------------------------------------------
        // Logout
        private void btnLogout_Click(object sender, EventArgs e)
        {

        }
        // -------------------------------------------------------------------------------------
    }
}
