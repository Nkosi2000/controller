using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using contlle.client_controls;

namespace contlle
{
    public partial class ClientHome : Form
    {
        public ClientHome()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        // -------------------------------------------------------------------------------------
        // Manage Subscriptions
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            LoadClientManageSubscription(new ClientManageSubscriptionsControl1());
        }

        private void LoadClientManageSubscription(Control screen)
        {
            mainPanel.Controls.Clear();
            screen.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(screen);
        }
        
        // Shop
        private void btnShop_Click(object sender, EventArgs e)
        {
            LoadClientShop(new ClientShopControl1());
        }

        private void LoadClientShop(Control screen)
        {
            mainPanel.Controls.Clear();
            screen.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(screen);
        }

        // Track Electricity
        private void btnTrackElectricity_Click(object sender, EventArgs e)
        {
            LoadTrackElectricty(new ClientTrackElectrictyControl1());
        }

        private void LoadTrackElectricty(Control screen)
        {
            mainPanel.Controls.Clear();
            screen.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(screen);
        }

        // Payment Method
        private void btnPaymentMethod_Click(object sender, EventArgs e)
        {
            LoadPaymentMethod(new ClientPaymentMethodControl1());
        }

        private void LoadPaymentMethod(Control screen)
        {
            mainPanel.Controls.Clear();
            screen.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(screen);
        }

        // Payment History
        private void btnPaymentHistory_Click(object sender, EventArgs e)
        {
            LoadPaymentHistory(new ClientPaymentHistoryControl1());
        }

        private void LoadPaymentHistory(Control screen)
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
