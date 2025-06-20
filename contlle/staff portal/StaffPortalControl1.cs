using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    }
}
