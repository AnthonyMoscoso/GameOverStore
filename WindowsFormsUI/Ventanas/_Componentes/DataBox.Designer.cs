namespace WindowsFormsUI.Ventanas._Componentes
{
    partial class DataBox
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
            this.pnNombre = new System.Windows.Forms.Panel();
            this.pnBodyData = new System.Windows.Forms.Panel();
            this.tableData = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtData = new System.Windows.Forms.HintText();
            this.EyeImage = new System.Windows.Forms.PictureHover();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbNombreData = new System.Windows.Forms.Label();
            this.alertData = new System.Windows.Forms.AlertPictureBox();
            this.pnImagenData = new System.Windows.Forms.Panel();
            this.ptbxImagenData = new System.Windows.Forms.PictureBox();
            this.pnNombre.SuspendLayout();
            this.pnBodyData.SuspendLayout();
            this.tableData.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EyeImage)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alertData)).BeginInit();
            this.pnImagenData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbxImagenData)).BeginInit();
            this.SuspendLayout();
            // 
            // pnNombre
            // 
            this.pnNombre.Controls.Add(this.pnBodyData);
            this.pnNombre.Controls.Add(this.pnImagenData);
            this.pnNombre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnNombre.Location = new System.Drawing.Point(0, 0);
            this.pnNombre.Name = "pnNombre";
            this.pnNombre.Padding = new System.Windows.Forms.Padding(5);
            this.pnNombre.Size = new System.Drawing.Size(415, 77);
            this.pnNombre.TabIndex = 1;
            // 
            // pnBodyData
            // 
            this.pnBodyData.Controls.Add(this.tableData);
            this.pnBodyData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnBodyData.Location = new System.Drawing.Point(67, 5);
            this.pnBodyData.Name = "pnBodyData";
            this.pnBodyData.Padding = new System.Windows.Forms.Padding(4);
            this.pnBodyData.Size = new System.Drawing.Size(343, 67);
            this.pnBodyData.TabIndex = 4;
            // 
            // tableData
            // 
            this.tableData.ColumnCount = 1;
            this.tableData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableData.Controls.Add(this.panel2, 0, 1);
            this.tableData.Controls.Add(this.panel1, 0, 0);
            this.tableData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableData.Location = new System.Drawing.Point(4, 4);
            this.tableData.Name = "tableData";
            this.tableData.RowCount = 2;
            this.tableData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableData.Size = new System.Drawing.Size(335, 59);
            this.tableData.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtData);
            this.panel2.Controls.Add(this.EyeImage);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(329, 24);
            this.panel2.TabIndex = 7;
            // 
            // txtData
            // 
            this.txtData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtData.ForeColor = System.Drawing.Color.Gray;
            this.txtData.Hint = null;
            this.txtData.Location = new System.Drawing.Point(0, 0);
            this.txtData.Multiline = true;
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(305, 24);
            this.txtData.TabIndex = 2;
            this.txtData.Tipo_De_Texto = System.Windows.Forms.HintText.TipeText.All;
            // 
            // EyeImage
            // 
            this.EyeImage.Clicked = true;
            this.EyeImage.Dock = System.Windows.Forms.DockStyle.Right;
            this.EyeImage.Hover = false;
            this.EyeImage.Image = global::WindowsFormsUI.Properties.Resources.eye;
            this.EyeImage.ImageHover = global::WindowsFormsUI.Properties.Resources.hide;
            this.EyeImage.Location = new System.Drawing.Point(305, 0);
            this.EyeImage.MargingOut = new System.Windows.Forms.Padding(0);
            this.EyeImage.Name = "EyeImage";
            this.EyeImage.Size = new System.Drawing.Size(24, 24);
            this.EyeImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.EyeImage.TabIndex = 6;
            this.EyeImage.TabStop = false;
            this.EyeImage.Visible = false;
            this.EyeImage.Click += new System.EventHandler(this.EyeImage_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbNombreData);
            this.panel1.Controls.Add(this.alertData);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(329, 23);
            this.panel1.TabIndex = 1;
            // 
            // lbNombreData
            // 
            this.lbNombreData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbNombreData.Location = new System.Drawing.Point(0, 0);
            this.lbNombreData.Name = "lbNombreData";
            this.lbNombreData.Size = new System.Drawing.Size(305, 23);
            this.lbNombreData.TabIndex = 0;
            this.lbNombreData.Text = "label1";
            // 
            // alertData
            // 
            this.alertData.Dock = System.Windows.Forms.DockStyle.Right;
            this.alertData.Location = new System.Drawing.Point(305, 0);
            this.alertData.Name = "alertData";
            this.alertData.Size = new System.Drawing.Size(24, 23);
            this.alertData.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.alertData.TabIndex = 5;
            this.alertData.TabStop = false;
            this.alertData.Visible = false;
            // 
            // pnImagenData
            // 
            this.pnImagenData.Controls.Add(this.ptbxImagenData);
            this.pnImagenData.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnImagenData.Location = new System.Drawing.Point(5, 5);
            this.pnImagenData.Name = "pnImagenData";
            this.pnImagenData.Padding = new System.Windows.Forms.Padding(5);
            this.pnImagenData.Size = new System.Drawing.Size(62, 67);
            this.pnImagenData.TabIndex = 3;
            // 
            // ptbxImagenData
            // 
            this.ptbxImagenData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptbxImagenData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptbxImagenData.Location = new System.Drawing.Point(5, 5);
            this.ptbxImagenData.Name = "ptbxImagenData";
            this.ptbxImagenData.Size = new System.Drawing.Size(52, 57);
            this.ptbxImagenData.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbxImagenData.TabIndex = 0;
            this.ptbxImagenData.TabStop = false;
            // 
            // DataBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnNombre);
            this.Name = "DataBox";
            this.Size = new System.Drawing.Size(415, 77);

            this.pnNombre.ResumeLayout(false);
            this.pnBodyData.ResumeLayout(false);
            this.tableData.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EyeImage)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.alertData)).EndInit();
            this.pnImagenData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbxImagenData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel pnNombre;
        public System.Windows.Forms.PictureBox ptbxImagenData;
        public System.Windows.Forms.Panel pnBodyData;
        public System.Windows.Forms.Panel pnImagenData;
        public System.Windows.Forms.TableLayoutPanel tableData;
        public System.Windows.Forms.Label lbNombreData;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.AlertPictureBox alertData;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.HintText txtData;
        private System.Windows.Forms.PictureHover EyeImage;
    }
}
