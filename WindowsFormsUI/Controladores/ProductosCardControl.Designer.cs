namespace WindowsFormsUI.Controladores
{
    partial class ProductosCardControl
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
            this.pnDatas = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbPrecioVenta = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbDesarrolladora = new System.Windows.Forms.Label();
            this.ptbxImage = new System.Windows.Forms.PictureBox();
            this.pnContenedor = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pnDatas.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbxImage)).BeginInit();
            this.pnContenedor.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnDatas
            // 
            this.pnDatas.Controls.Add(this.panel2);
            this.pnDatas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnDatas.Location = new System.Drawing.Point(20, 315);
            this.pnDatas.Name = "pnDatas";
            this.pnDatas.Size = new System.Drawing.Size(240, 77);
            this.pnDatas.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbNombre);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(240, 77);
            this.panel2.TabIndex = 3;
            // 
            // lbPrecioVenta
            // 
            this.lbPrecioVenta.Location = new System.Drawing.Point(136, 12);
            this.lbPrecioVenta.Name = "lbPrecioVenta";
            this.lbPrecioVenta.Size = new System.Drawing.Size(46, 17);
            this.lbPrecioVenta.TabIndex = 1;
            this.lbPrecioVenta.Text = "label2";
            // 
            // lbNombre
            // 
            this.lbNombre.Location = new System.Drawing.Point(12, 3);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(111, 30);
            this.lbNombre.TabIndex = 0;
            this.lbNombre.Text = "label1";
            // 
            // lbDesarrolladora
            // 
            this.lbDesarrolladora.AutoSize = true;
            this.lbDesarrolladora.Location = new System.Drawing.Point(12, 0);
            this.lbDesarrolladora.Name = "lbDesarrolladora";
            this.lbDesarrolladora.Size = new System.Drawing.Size(46, 17);
            this.lbDesarrolladora.TabIndex = 1;
            this.lbDesarrolladora.Text = "label2";
            this.lbDesarrolladora.Click += new System.EventHandler(this.lbDesarrolladora_Click);
            // 
            // ptbxImage
            // 
            this.ptbxImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptbxImage.Location = new System.Drawing.Point(20, 20);
            this.ptbxImage.Name = "ptbxImage";
            this.ptbxImage.Size = new System.Drawing.Size(240, 295);
            this.ptbxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbxImage.TabIndex = 2;
            this.ptbxImage.TabStop = false;
            this.ptbxImage.Click += new System.EventHandler(this.ptbxImage_Click);
            this.ptbxImage.MouseEnter += new System.EventHandler(this.ptbxImage_MouseEnter);
            this.ptbxImage.MouseLeave += new System.EventHandler(this.ptbxImage_MouseLeave);
            // 
            // pnContenedor
            // 
            this.pnContenedor.Controls.Add(this.ptbxImage);
            this.pnContenedor.Controls.Add(this.pnDatas);
            this.pnContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContenedor.Location = new System.Drawing.Point(0, 0);
            this.pnContenedor.Name = "pnContenedor";
            this.pnContenedor.Padding = new System.Windows.Forms.Padding(20);
            this.pnContenedor.Size = new System.Drawing.Size(280, 412);
            this.pnContenedor.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbPrecioVenta);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.lbDesarrolladora);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 41);
            this.panel1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.Location = new System.Drawing.Point(204, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 41);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ProductosCardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnContenedor);
            this.Name = "ProductosCardControl";
            this.Size = new System.Drawing.Size(280, 412);
            this.pnDatas.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbxImage)).EndInit();
            this.pnContenedor.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnDatas;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbPrecioVenta;
        private System.Windows.Forms.Label lbDesarrolladora;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.PictureBox ptbxImage;
        private System.Windows.Forms.Panel pnContenedor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
    }
}
