namespace WindowsFormsUI.Controladores
{
    partial class AdapterAjuster
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
            this.ptbxImagen = new System.Windows.Forms.PictureBox();
            this.pnContenedor = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptbxImagen)).BeginInit();
            this.pnContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ptbxImagen
            // 
            this.ptbxImagen.Dock = System.Windows.Forms.DockStyle.Left;
            this.ptbxImagen.Location = new System.Drawing.Point(10, 30);
            this.ptbxImagen.Name = "ptbxImagen";
            this.ptbxImagen.Padding = new System.Windows.Forms.Padding(5);
            this.ptbxImagen.Size = new System.Drawing.Size(66, 66);
            this.ptbxImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbxImagen.TabIndex = 0;
            this.ptbxImagen.TabStop = false;
            // 
            // pnContenedor
            // 
            this.pnContenedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnContenedor.Controls.Add(this.pictureBox1);
            this.pnContenedor.Controls.Add(this.ptbxImagen);
            this.pnContenedor.Controls.Add(this.lbName);
            this.pnContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContenedor.Location = new System.Drawing.Point(10, 10);
            this.pnContenedor.Name = "pnContenedor";
            this.pnContenedor.Padding = new System.Windows.Forms.Padding(10);
            this.pnContenedor.Size = new System.Drawing.Size(158, 108);
            this.pnContenedor.TabIndex = 1;
            this.pnContenedor.Click += new System.EventHandler(this.pnContenedor_Click);
            this.pnContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.pnContenedor_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(107, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 35);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lbName
            // 
            this.lbName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbName.Location = new System.Drawing.Point(10, 10);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(136, 20);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "label1";
            // 
            // AdapterAjuster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnContenedor);
            this.Name = "AdapterAjuster";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(178, 128);
            this.Load += new System.EventHandler(this.AdapterAjuster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbxImagen)).EndInit();
            this.pnContenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbxImagen;
        private System.Windows.Forms.Panel pnContenedor;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
