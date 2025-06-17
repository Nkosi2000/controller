
namespace contlle
{
    partial class Login
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtEmailAddress = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblEmailAddress = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblLogin = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.logotext = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lnkForgotPassword = new System.Windows.Forms.LinkLabel();
            this.lnkForgotEmailAddress = new System.Windows.Forms.LinkLabel();
            this.lnkX = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lnkX);
            this.panel1.Controls.Add(this.lnkForgotEmailAddress);
            this.panel1.Controls.Add(this.lnkForgotPassword);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.logotext);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.lblLogin);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.txtEmailAddress);
            this.panel1.Controls.Add(this.lblPassword);
            this.panel1.Controls.Add(this.lblEmailAddress);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(711, 476);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(339, 419);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Don\'t have an account ?";
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.LightGreen;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.Color.SeaGreen;
            this.linkLabel1.Location = new System.Drawing.Point(470, 418);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(44, 16);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Signup";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
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
            this.btnLogin.Location = new System.Drawing.Point(443, 341);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(123, 41);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Location = new System.Drawing.Point(339, 253);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(342, 20);
            this.txtPassword.TabIndex = 5;
            // 
            // txtEmailAddress
            // 
            this.txtEmailAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmailAddress.Location = new System.Drawing.Point(339, 154);
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.Size = new System.Drawing.Size(342, 20);
            this.txtEmailAddress.TabIndex = 4;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(339, 237);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(56, 13);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password:";
            // 
            // lblEmailAddress
            // 
            this.lblEmailAddress.AutoSize = true;
            this.lblEmailAddress.Location = new System.Drawing.Point(339, 138);
            this.lblEmailAddress.Name = "lblEmailAddress";
            this.lblEmailAddress.Size = new System.Drawing.Size(75, 13);
            this.lblEmailAddress.TabIndex = 2;
            this.lblEmailAddress.Text = "Email address:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SeaGreen;
            this.panel2.ForeColor = System.Drawing.Color.SeaGreen;
            this.panel2.Location = new System.Drawing.Point(91, 7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(537, 3);
            this.panel2.TabIndex = 18;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SeaGreen;
            this.panel3.ForeColor = System.Drawing.Color.SeaGreen;
            this.panel3.Location = new System.Drawing.Point(91, 466);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(537, 3);
            this.panel3.TabIndex = 19;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.BackColor = System.Drawing.Color.Transparent;
            this.lblLogin.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblLogin.Location = new System.Drawing.Point(467, 58);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(85, 33);
            this.lblLogin.TabIndex = 21;
            this.lblLogin.Text = "Login";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Cursor = System.Windows.Forms.Cursors.Default;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.SeaGreen;
            this.label6.Location = new System.Drawing.Point(70, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 28);
            this.label6.TabIndex = 25;
            this.label6.Text = "IT";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // logotext
            // 
            this.logotext.AutoSize = true;
            this.logotext.BackColor = System.Drawing.Color.Transparent;
            this.logotext.Cursor = System.Windows.Forms.Cursors.Default;
            this.logotext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logotext.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logotext.ForeColor = System.Drawing.Color.SeaGreen;
            this.logotext.Location = new System.Drawing.Point(131, 58);
            this.logotext.Margin = new System.Windows.Forms.Padding(0);
            this.logotext.Name = "logotext";
            this.logotext.Size = new System.Drawing.Size(111, 28);
            this.logotext.TabIndex = 23;
            this.logotext.Text = "CHARGE";
            this.logotext.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::contlle.Properties.Resources._3418133;
            this.pictureBox1.Location = new System.Drawing.Point(91, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::contlle.Properties.Resources._3418133;
            this.pictureBox2.Location = new System.Drawing.Point(0, 22);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(333, 442);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // lnkForgotPassword
            // 
            this.lnkForgotPassword.ActiveLinkColor = System.Drawing.Color.LightGreen;
            this.lnkForgotPassword.AutoSize = true;
            this.lnkForgotPassword.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkForgotPassword.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkForgotPassword.LinkColor = System.Drawing.Color.SeaGreen;
            this.lnkForgotPassword.Location = new System.Drawing.Point(339, 276);
            this.lnkForgotPassword.Name = "lnkForgotPassword";
            this.lnkForgotPassword.Size = new System.Drawing.Size(102, 16);
            this.lnkForgotPassword.TabIndex = 26;
            this.lnkForgotPassword.TabStop = true;
            this.lnkForgotPassword.Text = "Forgot password?";
            this.lnkForgotPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lnkForgotEmailAddress
            // 
            this.lnkForgotEmailAddress.ActiveLinkColor = System.Drawing.Color.LightGreen;
            this.lnkForgotEmailAddress.AutoSize = true;
            this.lnkForgotEmailAddress.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkForgotEmailAddress.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkForgotEmailAddress.LinkColor = System.Drawing.Color.SeaGreen;
            this.lnkForgotEmailAddress.Location = new System.Drawing.Point(339, 177);
            this.lnkForgotEmailAddress.Name = "lnkForgotEmailAddress";
            this.lnkForgotEmailAddress.Size = new System.Drawing.Size(124, 16);
            this.lnkForgotEmailAddress.TabIndex = 27;
            this.lnkForgotEmailAddress.TabStop = true;
            this.lnkForgotEmailAddress.Text = "Forgot email address?";
            this.lnkForgotEmailAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lnkX
            // 
            this.lnkX.ActiveLinkColor = System.Drawing.Color.LightGreen;
            this.lnkX.AutoSize = true;
            this.lnkX.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkX.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lnkX.LinkColor = System.Drawing.Color.SeaGreen;
            this.lnkX.Location = new System.Drawing.Point(657, 22);
            this.lnkX.Name = "lnkX";
            this.lnkX.Size = new System.Drawing.Size(24, 25);
            this.lnkX.TabIndex = 29;
            this.lnkX.TabStop = true;
            this.lnkX.Text = "x";
            this.lnkX.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkX_LinkClicked);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 476);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtEmailAddress;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblEmailAddress;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label logotext;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.LinkLabel lnkForgotEmailAddress;
        private System.Windows.Forms.LinkLabel lnkForgotPassword;
        private System.Windows.Forms.LinkLabel lnkX;
    }
}