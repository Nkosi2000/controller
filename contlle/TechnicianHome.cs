using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using contlle.technician_controls;

namespace contlle
{
    public partial class TechnicianHome : Form
    {
        public TechnicianHome()
        {
            InitializeComponent();
        }

        // ------------------------------------------------------------------------------------- 
        // Dashboard
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            LoadDashboard(new TechDashboardControl1());
        }

        private void LoadDashboard(Control screen)
        {
            mainPanel.Controls.Clear();
            screen.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(screen);
        }

        // Deployment
        private void btnMyDeployments_Click(object sender, EventArgs e)
        {
            LoadDeployment(new TechDeploymentControl1());
        }

        private void LoadDeployment(Control screen)
        {
            mainPanel.Controls.Clear();
            screen.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(screen);
        }

        // Feeddback
        private void btnFeedbackReport_Click(object sender, EventArgs e)
        {
            LoadFeedback(new TechFeedbackControl1());
        }

        private void LoadFeedback(Control screen)
        {
            mainPanel.Controls.Clear();
            screen.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(screen);
        }

        // Ratings
        private void btnRatings_Click(object sender, EventArgs e)
        {
            LoadRantings(new TechRatingsControl1());
        }

        private void LoadRantings(Control screen)
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
    }
}
