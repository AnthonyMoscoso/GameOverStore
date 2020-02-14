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
            this.lbName = new System.Windows.Forms.Label();
            this.ptbxCancel = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbxImagen)).BeginInit();
            this.pnContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbxCancel)).BeginInit();
            this.SuspendLayout();
            // 
            // ptbxImagen
            // 
            this.ptbxImagen.Dock = System.Windows.Forms.DockStyle.Left;
            this.ptbxImagen.Location = new System.Drawing.Point(5, 5);
            this.ptbxImagen.Name = "ptbxImagen";
            this.ptbxImagen.Padding = new System.Windows.Forms.Padding(5);
            this.ptbxImagen.Size = new System.Drawing.Size(34, 33);
            this.ptbxImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbxImagen.TabIndex = 0;
            this.ptbxImagen.TabStop = false;
            // 
            // pnContenedor
            // 
            this.pnContenedor.BackColor = System.Drawing.SystemColors.Control;
            this.pnContenedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnContenedor.Controls.Add(this.lbName);
            this.pnContenedor.Controls.Add(this.ptbxCancel);
            this.pnContenedor.Controls.Add(this.ptbxImagen);
            this.pnContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContenedor.Location = new System.Drawing.Point(10, 10);
            this.pnContenedor.Name = "pnContenedor";
            this.pnContenedor.Padding = new System.Windows.Forms.Padding(5);
            this.pnContenedor.Size = new System.Drawing.Size(222, 45);
            this.pnContenedor.TabIndex = 1;
            // 
            // lbName
            // 
            this.lbName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbName.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(39, 5);
            this.lbName.Name = "lbName";
            this.lbName.Padding = new System.Windows.Forms.Padding(5);
            this.lbName.Size = new System.Drawing.Size(150, 33);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "label1";
            // 
            // ptbxCancel
            // 
            this.ptbxCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.ptbxCancel.Image = global::WindowsFormsUI.Properties.Resources.eye;
            this.ptbxCancel.Location = new System.Drawing.Point(189, 5);
            this.ptbxCancel.Name = "ptbxCancel";
            this.ptbxCancel.Size = new System.Drawing.Size(26, 33);
            this.ptbxCancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbxCancel.TabIndex = 1;
            this.ptbxCancel.TabStop = false;
            this.ptbxCancel.Click += new System.EventHandler(this.ptbxCancel_Click);
            // 
            // AdapterAjuster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnContenedor);
            this.Name = "AdapterAjuster";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Size = new System.Drawing.Size(242, 65);
            this.Load += new System.EventHandler(this.AdapterAjuster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbxImagen)).EndInit();
            this.pnContenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbxCancel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbxImagen;
        private System.Windows.Forms.Panel pnContenedor;
        private System.Windows.Forms.Label lbName;
        public System.Windows.Forms.PictureBox ptbxCancel;
    }
}
