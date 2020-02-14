namespace WindowsFormsUI.Login
{
    partial class VentanaLogin
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.alertPassword = new System.Windows.Forms.AlertPictureBox();
            this.alertEmail = new System.Windows.Forms.AlertPictureBox();
            this.ptxSeePassword = new System.Windows.Forms.PictureHover();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.HintText();
            this.txtPassword = new System.Windows.Forms.HintText();
            this.panel5 = new System.Windows.Forms.Panel();
            this.ptbxLogo = new System.Windows.Forms.PictureBox();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alertPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alertEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptxSeePassword)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(476, 42);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 719);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(476, 54);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Yellow;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 42);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(476, 677);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel4.Controls.Add(this.btnRegister);
            this.panel4.Controls.Add(this.btnLogin);
            this.panel4.Controls.Add(this.alertPassword);
            this.panel4.Controls.Add(this.alertEmail);
            this.panel4.Controls.Add(this.ptxSeePassword);
            this.panel4.Controls.Add(this.lbPassword);
            this.panel4.Controls.Add(this.lbEmail);
            this.panel4.Controls.Add(this.txtEmail);
            this.panel4.Controls.Add(this.txtPassword);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 212);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(476, 465);
            this.panel4.TabIndex = 10;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(78, 340);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(318, 54);
            this.btnRegister.TabIndex = 9;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(78, 257);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(318, 55);
            this.btnLogin.TabIndex = 8;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // alertPassword
            // 
            this.alertPassword.Location = new System.Drawing.Point(369, 145);
            this.alertPassword.Name = "alertPassword";
            this.alertPassword.Size = new System.Drawing.Size(27, 26);
            this.alertPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.alertPassword.TabIndex = 6;
            this.alertPassword.TabStop = false;
            this.alertPassword.Visible = false;
            // 
            // alertEmail
            // 
            this.alertEmail.Location = new System.Drawing.Point(369, 33);
            this.alertEmail.Name = "alertEmail";
            this.alertEmail.Size = new System.Drawing.Size(27, 26);
            this.alertEmail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.alertEmail.TabIndex = 5;
            this.alertEmail.TabStop = false;
            this.alertEmail.Visible = false;
            // 
            // ptxSeePassword
            // 
            this.ptxSeePassword.Clicked = false;
            this.ptxSeePassword.Hover = false;
            this.ptxSeePassword.ImageHover = null;
            this.ptxSeePassword.ImageInicial = null;
            this.ptxSeePassword.Location = new System.Drawing.Point(416, 191);
            this.ptxSeePassword.MargingOut = new System.Windows.Forms.Padding(0);
            this.ptxSeePassword.MarginInt = new System.Windows.Forms.Padding(0);
            this.ptxSeePassword.Name = "ptxSeePassword";
            this.ptxSeePassword.Size = new System.Drawing.Size(22, 23);
            this.ptxSeePassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptxSeePassword.TabIndex = 4;
            this.ptxSeePassword.TabStop = false;
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(75, 145);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(46, 17);
            this.lbPassword.TabIndex = 3;
            this.lbPassword.Text = "label2";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(75, 42);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(46, 17);
            this.lbEmail.TabIndex = 2;
            this.lbEmail.Text = "label1";
            // 
            // txtEmail
            // 
            this.txtEmail.ForeColor = System.Drawing.Color.Gray;
            this.txtEmail.Hint = null;
            this.txtEmail.Location = new System.Drawing.Point(78, 92);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(318, 22);
            this.txtEmail.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.ForeColor = System.Drawing.Color.Gray;
            this.txtPassword.Hint = "Ingresar  Contraseña";
            this.txtPassword.Location = new System.Drawing.Point(78, 192);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(318, 22);
            this.txtPassword.TabIndex = 0;
            this.txtPassword.Text = "Ingresar  Contraseña";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel5.Controls.Add(this.ptbxLogo);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(476, 212);
            this.panel5.TabIndex = 11;
            // 
            // ptbxLogo
            // 
            this.ptbxLogo.Location = new System.Drawing.Point(40, 23);
            this.ptbxLogo.Name = "ptbxLogo";
            this.ptbxLogo.Size = new System.Drawing.Size(398, 162);
            this.ptbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbxLogo.TabIndex = 7;
            this.ptbxLogo.TabStop = false;
            // 
            // VentanaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 773);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VentanaLogin";
            this.Text = "VentanaLogin";
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alertPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alertEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptxSeePassword)).EndInit();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.AlertPictureBox alertPassword;
        private System.Windows.Forms.AlertPictureBox alertEmail;
        private System.Windows.Forms.PictureHover ptxSeePassword;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.HintText txtEmail;
        private System.Windows.Forms.HintText txtPassword;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox ptbxLogo;
    }
}