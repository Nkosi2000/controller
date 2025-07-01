namespace contlle.staff_portal
{
    partial class StaffPortalControl1
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlStaffPortal = new System.Windows.Forms.Panel();
            this.lnkForgotPassword = new System.Windows.Forms.LinkLabel();
            this.lnkForgotEmailAddress = new System.Windows.Forms.LinkLabel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lnkX = new System.Windows.Forms.LinkLabel();
            this.lblStaffLogin = new System.Windows.Forms.Label();
            this.lblStaffNumber = new System.Windows.Forms.Label();
            this.txtStaffEmailAddress = new System.Windows.Forms.TextBox();
            this.txtStaffNumber = new System.Windows.Forms.TextBox();
            this.lblstaffemail = new System.Windows.Forms.Label();
            this.pnlStaffPortal.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlStaffPortal
            // 
            this.pnlStaffPortal.BackColor = System.Drawing.Color.White;
            this.pnlStaffPortal.Controls.Add(this.lnkForgotPassword);
            this.pnlStaffPortal.Controls.Add(this.lnkForgotEmailAddress);
            this.pnlStaffPortal.Controls.Add(this.btnLogin);
            this.pnlStaffPortal.Controls.Add(this.lnkX);
            this.pnlStaffPortal.Controls.Add(this.lblStaffLogin);
            this.pnlStaffPortal.Controls.Add(this.lblStaffNumber);
            this.pnlStaffPortal.Controls.Add(this.txtStaffEmailAddress);
            this.pnlStaffPortal.Controls.Add(this.txtStaffNumber);
            this.pnlStaffPortal.Controls.Add(this.lblstaffemail);
            this.pnlStaffPortal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlStaffPortal.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlStaffPortal.Location = new System.Drawing.Point(0, 0);
            this.pnlStaffPortal.Name = "pnlStaffPortal";
            this.pnlStaffPortal.Size = new System.Drawing.Size(360, 442);
            this.pnlStaffPortal.TabIndex = 0;
            this.pnlStaffPortal.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlStaffPortal_Paint);
            // 
            // lnkForgotPassword
            // 
            this.lnkForgotPassword.ActiveLinkColor = System.Drawing.Color.LightGreen;
            this.lnkForgotPassword.AutoSize = true;
            this.lnkForgotPassword.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkForgotPassword.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkForgotPassword.LinkColor = System.Drawing.Color.SeaGreen;
            this.lnkForgotPassword.Location = new System.Drawing.Point(-3, 255);
            this.lnkForgotPassword.Name = "lnkForgotPassword";
            this.lnkForgotPassword.Size = new System.Drawing.Size(100, 16);
            this.lnkForgotPassword.TabIndex = 36;
            this.lnkForgotPassword.TabStop = true;
            this.lnkForgotPassword.Text = "                               ";
            this.lnkForgotPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lnkForgotEmailAddress
            // 
            this.lnkForgotEmailAddress.ActiveLinkColor = System.Drawing.Color.LightGreen;
            this.lnkForgotEmailAddress.AutoSize = true;
            this.lnkForgotEmailAddress.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkForgotEmailAddress.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkForgotEmailAddress.LinkColor = System.Drawing.Color.SeaGreen;
            this.lnkForgotEmailAddress.Location = new System.Drawing.Point(-3, 156);
            this.lnkForgotEmailAddress.Name = "lnkForgotEmailAddress";
            this.lnkForgotEmailAddress.Size = new System.Drawing.Size(117, 16);
            this.lnkForgotEmailAddress.TabIndex = 37;
            this.lnkForgotEmailAddress.TabStop = true;
            this.lnkForgotEmailAddress.Text = "Forgot staff number?";
            this.lnkForgotEmailAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.SeaGreen;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnLogin.FlatAppearance.BorderSize = 2;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.Honeydew;
            this.btnLogin.Location = new System.Drawing.Point(103, 320);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(123, 41);
            this.btnLogin.TabIndex = 34;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lnkX
            // 
            this.lnkX.ActiveLinkColor = System.Drawing.Color.LightGreen;
            this.lnkX.AutoSize = true;
            this.lnkX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkX.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkX.Image = global::contlle.Properties.Resources.backarrow;
            this.lnkX.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lnkX.LinkColor = System.Drawing.Color.SeaGreen;
            this.lnkX.Location = new System.Drawing.Point(318, 3);
            this.lnkX.Name = "lnkX";
            this.lnkX.Size = new System.Drawing.Size(30, 25);
            this.lnkX.TabIndex = 38;
            this.lnkX.TabStop = true;
            this.lnkX.Text = "   ";
            this.lnkX.VisitedLinkColor = System.Drawing.Color.LightGreen;
            this.lnkX.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkX_LinkClicked);
            // 
            // lblStaffLogin
            // 
            this.lblStaffLogin.AutoSize = true;
            this.lblStaffLogin.BackColor = System.Drawing.Color.Transparent;
            this.lblStaffLogin.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffLogin.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblStaffLogin.Location = new System.Drawing.Point(97, 34);
            this.lblStaffLogin.Name = "lblStaffLogin";
            this.lblStaffLogin.Size = new System.Drawing.Size(149, 33);
            this.lblStaffLogin.TabIndex = 35;
            this.lblStaffLogin.Text = "Staff Login";
            // 
            // lblStaffNumber
            // 
            this.lblStaffNumber.AutoSize = true;
            this.lblStaffNumber.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffNumber.Location = new System.Drawing.Point(-3, 113);
            this.lblStaffNumber.Name = "lblStaffNumber";
            this.lblStaffNumber.Size = new System.Drawing.Size(79, 16);
            this.lblStaffNumber.TabIndex = 30;
            this.lblStaffNumber.Text = "Staff number:";
            // 
            // txtStaffEmailAddress
            // 
            this.txtStaffEmailAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStaffEmailAddress.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStaffEmailAddress.Location = new System.Drawing.Point(0, 231);
            this.txtStaffEmailAddress.Name = "txtStaffEmailAddress";
            this.txtStaffEmailAddress.Size = new System.Drawing.Size(342, 21);
            this.txtStaffEmailAddress.TabIndex = 33;
            this.txtStaffEmailAddress.UseSystemPasswordChar = true;
            this.txtStaffEmailAddress.TextChanged += new System.EventHandler(this.txtStaffEmailAddress_TextChanged);
            // 
            // txtStaffNumber
            // 
            this.txtStaffNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStaffNumber.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStaffNumber.Location = new System.Drawing.Point(0, 132);
            this.txtStaffNumber.Name = "txtStaffNumber";
            this.txtStaffNumber.Size = new System.Drawing.Size(342, 21);
            this.txtStaffNumber.TabIndex = 32;
            this.txtStaffNumber.TextChanged += new System.EventHandler(this.txtStaffNumber_TextChanged);
            // 
            // lblstaffemail
            // 
            this.lblstaffemail.AutoSize = true;
            this.lblstaffemail.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstaffemail.Location = new System.Drawing.Point(-3, 212);
            this.lblstaffemail.Name = "lblstaffemail";
            this.lblstaffemail.Size = new System.Drawing.Size(111, 16);
            this.lblstaffemail.TabIndex = 31;
            this.lblstaffemail.Text = "Staff email address:";
            // 
            // StaffPortalControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlStaffPortal);
            this.Name = "StaffPortalControl1";
            this.Size = new System.Drawing.Size(360, 442);
            this.pnlStaffPortal.ResumeLayout(false);
            this.pnlStaffPortal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlStaffPortal;
        private System.Windows.Forms.LinkLabel lnkForgotPassword;
        private System.Windows.Forms.LinkLabel lnkForgotEmailAddress;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.LinkLabel lnkX;
        private System.Windows.Forms.Label lblStaffLogin;
        private System.Windows.Forms.Label lblStaffNumber;
        private System.Windows.Forms.TextBox txtStaffEmailAddress;
        private System.Windows.Forms.TextBox txtStaffNumber;
        private System.Windows.Forms.Label lblstaffemail;
    }
}
