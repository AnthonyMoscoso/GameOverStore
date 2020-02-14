namespace WindowsFormsUI.Ventanas._Componentes
{
    partial class PassWordTxt
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtPassword = new System.Windows.Forms.HintText();
            this.ImageSee = new System.Windows.Forms.PictureHover();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnEye = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ImageSee)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnEye.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPassword
            // 
            this.txtPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPassword.ForeColor = System.Drawing.Color.Gray;
            this.txtPassword.Hint = "Insertar Contraseña";
            this.txtPassword.Location = new System.Drawing.Point(0, 0);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(231, 35);
            this.txtPassword.TabIndex = 0;
            this.txtPassword.Text = "Insertar Contraseña";
            this.txtPassword.Tipo_De_Texto = System.Windows.Forms.HintText.TipeText.All;
            // 
            // ImageSee
            // 
            this.ImageSee.Clicked = true;
            this.ImageSee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImageSee.Hover = true;
            this.ImageSee.Image = global::WindowsFormsUI.Properties.Resources.eye;
            this.ImageSee.ImageHover = global::WindowsFormsUI.Properties.Resources.hide;
            this.ImageSee.Location = new System.Drawing.Point(0, 0);
            this.ImageSee.MargingOut = new System.Windows.Forms.Padding(0);
            this.ImageSee.Name = "ImageSee";
            this.ImageSee.Size = new System.Drawing.Size(32, 35);
            this.ImageSee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImageSee.TabIndex = 1;
            this.ImageSee.TabStop = false;
            this.ImageSee.Click += new System.EventHandler(this.ImageSee_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(231, 35);
            this.panel1.TabIndex = 2;
            // 
            // pnEye
            // 
            this.pnEye.Controls.Add(this.ImageSee);
            this.pnEye.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnEye.Location = new System.Drawing.Point(231, 0);
            this.pnEye.Name = "pnEye";
            this.pnEye.Size = new System.Drawing.Size(32, 35);
            this.pnEye.TabIndex = 3;
            this.pnEye.Visible = false;
            // 
            // PassWordTxt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnEye);
            this.Name = "PassWordTxt";
            this.Size = new System.Drawing.Size(263, 35);
            ((System.ComponentModel.ISupportInitialize)(this.ImageSee)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnEye.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.HintText txtPassword;
        private System.Windows.Forms.PictureHover ImageSee;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnEye;
    }
}
