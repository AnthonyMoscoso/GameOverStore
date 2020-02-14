namespace WindowsFormsUI.Controladores
{
    partial class pnCard
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
            this.pnContainder = new System.Windows.Forms.Panel();
            this.pnBody = new System.Windows.Forms.Panel();
            this.pnPicture = new System.Windows.Forms.Panel();
            this.ptbxImage = new System.Windows.Forms.PictureBox();
            this.pnDonw = new System.Windows.Forms.Panel();
            this.lbText = new System.Windows.Forms.Label();
            this.pnContainder.SuspendLayout();
            this.pnBody.SuspendLayout();
            this.pnPicture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbxImage)).BeginInit();
            this.pnDonw.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnContainder
            // 
            this.pnContainder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnContainder.Controls.Add(this.pnBody);
            this.pnContainder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContainder.Location = new System.Drawing.Point(0, 0);
            this.pnContainder.Name = "pnContainder";
            this.pnContainder.Padding = new System.Windows.Forms.Padding(25);
            this.pnContainder.Size = new System.Drawing.Size(264, 406);
            this.pnContainder.TabIndex = 1;
            // 
            // pnBody
            // 
            this.pnBody.Controls.Add(this.pnPicture);
            this.pnBody.Controls.Add(this.pnDonw);
            this.pnBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnBody.Location = new System.Drawing.Point(25, 25);
            this.pnBody.Name = "pnBody";
            this.pnBody.Size = new System.Drawing.Size(212, 354);
            this.pnBody.TabIndex = 3;
            // 
            // pnPicture
            // 
            this.pnPicture.Controls.Add(this.ptbxImage);
            this.pnPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnPicture.Location = new System.Drawing.Point(0, 0);
            this.pnPicture.Name = "pnPicture";
            this.pnPicture.Size = new System.Drawing.Size(212, 273);
            this.pnPicture.TabIndex = 1;
            // 
            // ptbxImage
            // 
            this.ptbxImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptbxImage.Location = new System.Drawing.Point(0, 0);
            this.ptbxImage.Name = "ptbxImage";
            this.ptbxImage.Size = new System.Drawing.Size(212, 273);
            this.ptbxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbxImage.TabIndex = 0;
            this.ptbxImage.TabStop = false;
            this.ptbxImage.Click += new System.EventHandler(this.ptbxImage_Click);
            this.ptbxImage.MouseEnter += new System.EventHandler(this.ptbxImage_MouseEnter);
            this.ptbxImage.MouseLeave += new System.EventHandler(this.ptbxImage_MouseLeave);
            // 
            // pnDonw
            // 
            this.pnDonw.Controls.Add(this.lbText);
            this.pnDonw.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnDonw.Location = new System.Drawing.Point(0, 273);
            this.pnDonw.Name = "pnDonw";
            this.pnDonw.Size = new System.Drawing.Size(212, 81);
            this.pnDonw.TabIndex = 2;
            // 
            // lbText
            // 
            this.lbText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbText.Location = new System.Drawing.Point(0, 0);
            this.lbText.Name = "lbText";
            this.lbText.Size = new System.Drawing.Size(212, 81);
            this.lbText.TabIndex = 0;
            this.lbText.Text = "Desarrolladoras";
            this.lbText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnContainder);
            this.Name = "pnCard";
            this.Size = new System.Drawing.Size(264, 406);
            this.Load += new System.EventHandler(this.pnCard_Load);
            this.pnContainder.ResumeLayout(false);
            this.pnBody.ResumeLayout(false);
            this.pnPicture.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbxImage)).EndInit();
            this.pnDonw.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnContainder;
        private System.Windows.Forms.Panel pnBody;
        private System.Windows.Forms.Panel pnPicture;
        private System.Windows.Forms.PictureBox ptbxImage;
        private System.Windows.Forms.Panel pnDonw;
        private System.Windows.Forms.Label lbText;
    }
}
