namespace WindowsFormsUI.Login
{
    partial class VentanaRecuperarContreseña
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnContenedor = new System.Windows.Forms.Panel();
            this.buttonHover1 = new System.Windows.Forms.ButtonHover();
            this.pnSendCodigo = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.buttonHover2 = new System.Windows.Forms.ButtonHover();
            this.DataEmail = new WindowsFormsUI.Ventanas._Componentes.DataBox();
            this.panel3.SuspendLayout();
            this.pnContenedor.SuspendLayout();
            this.pnSendCodigo.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.buttonHover1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(4);
            this.panel3.Size = new System.Drawing.Size(372, 32);
            this.panel3.TabIndex = 7;
            // 
            // pnContenedor
            // 
            this.pnContenedor.Controls.Add(this.pnSendCodigo);
            this.pnContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContenedor.Location = new System.Drawing.Point(0, 32);
            this.pnContenedor.Name = "pnContenedor";
            this.pnContenedor.Size = new System.Drawing.Size(372, 125);
            this.pnContenedor.TabIndex = 8;
            // 
            // buttonHover1
            // 
            this.buttonHover1.ButtonBorderStyle = System.Windows.Forms.ButtonBorderStyle.None;
            this.buttonHover1.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonHover1.Location = new System.Drawing.Point(342, 4);
            this.buttonHover1.Name = "buttonHover1";
            this.buttonHover1.Size = new System.Drawing.Size(26, 24);
            this.buttonHover1.TabIndex = 0;
            this.buttonHover1.Text = "buttonHover1";
            this.buttonHover1.UseVisualStyleBackColor = true;
            // 
            // pnSendCodigo
            // 
            this.pnSendCodigo.Controls.Add(this.DataEmail);
            this.pnSendCodigo.Controls.Add(this.panel4);
            this.pnSendCodigo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnSendCodigo.Location = new System.Drawing.Point(0, 0);
            this.pnSendCodigo.Name = "pnSendCodigo";
            this.pnSendCodigo.Size = new System.Drawing.Size(372, 125);
            this.pnSendCodigo.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.buttonHover2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 70);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(10);
            this.panel4.Size = new System.Drawing.Size(372, 55);
            this.panel4.TabIndex = 2;
            // 
            // buttonHover2
            // 
            this.buttonHover2.ButtonBorderStyle = System.Windows.Forms.ButtonBorderStyle.None;
            this.buttonHover2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonHover2.Location = new System.Drawing.Point(10, 10);
            this.buttonHover2.Name = "buttonHover2";
            this.buttonHover2.Size = new System.Drawing.Size(352, 35);
            this.buttonHover2.TabIndex = 0;
            this.buttonHover2.Text = "buttonHover2";
            this.buttonHover2.UseVisualStyleBackColor = true;
         
            // 
            // DataEmail
            // 
            this.DataEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataEmail.Imagen = global::WindowsFormsUI.Properties.Resources.mail;
            this.DataEmail.IsPassword = false;
            this.DataEmail.Location = new System.Drawing.Point(0, 0);
            this.DataEmail.Name = "DataEmail";
            this.DataEmail.Size = new System.Drawing.Size(372, 70);
            this.DataEmail.TabIndex = 0;
            this.DataEmail.Texto = "";
            this.DataEmail.TextoHint = "Introducir Email";
            this.DataEmail.Tipo_De_Texto = WindowsFormsUI.Ventanas._Componentes.DataBox.TipeText.All;
            this.DataEmail.Titule = "Introducir Email";
            // 
            // VentanaRecuperarContreseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 157);
            this.Controls.Add(this.pnContenedor);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VentanaRecuperarContreseña";
            this.panel3.ResumeLayout(false);
            this.pnContenedor.ResumeLayout(false);
            this.pnSendCodigo.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ButtonHover buttonHover1;
        private System.Windows.Forms.Panel pnContenedor;
        private System.Windows.Forms.Panel pnSendCodigo;
        private Ventanas._Componentes.DataBox DataEmail;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ButtonHover buttonHover2;
    }
}
