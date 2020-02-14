namespace WindowsFormsUI.Ventanas
{
    partial class VentanaAjustes
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnIdiomas = new WindowsFormsUI.Controladores.pnCard();
            this.pnPlataformas = new WindowsFormsUI.Controladores.pnCard();
            this.pnClasificaciones = new WindowsFormsUI.Controladores.pnCard();
            this.pnDesarrolladoras = new WindowsFormsUI.Controladores.pnCard();
            this.pnCard1 = new WindowsFormsUI.Controladores.pnCard();
            this.pnCard2 = new WindowsFormsUI.Controladores.pnCard();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1449, 62);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 775);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1449, 62);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tableLayoutPanel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 62);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(50);
            this.panel3.Size = new System.Drawing.Size(1449, 713);
            this.panel3.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.pnCard2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pnCard1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pnPlataformas, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnClasificaciones, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnDesarrolladoras, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnIdiomas, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(50, 50);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1349, 613);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pnIdiomas
            // 
            this.pnIdiomas.Codigo_Envio = 4;
            this.pnIdiomas.Dock = System.Windows.Forms.DockStyle.Fill;
           
            this.pnIdiomas.Location = new System.Drawing.Point(3, 309);
            this.pnIdiomas.Name = "pnIdiomas";
            this.pnIdiomas.PaddingInt = new System.Windows.Forms.Padding(10);
            this.pnIdiomas.PaddingOut = new System.Windows.Forms.Padding(25);
            this.pnIdiomas.Size = new System.Drawing.Size(443, 301);
            this.pnIdiomas.TabIndex = 3;
            this.pnIdiomas.Texto = "IDIOMAS";
            // 
            // pnPlataformas
            // 
            this.pnPlataformas.Codigo_Envio = 3;
            this.pnPlataformas.Dock = System.Windows.Forms.DockStyle.Fill;
         
            this.pnPlataformas.Location = new System.Drawing.Point(901, 3);
            this.pnPlataformas.Name = "pnPlataformas";
            this.pnPlataformas.PaddingInt = new System.Windows.Forms.Padding(10);
            this.pnPlataformas.PaddingOut = new System.Windows.Forms.Padding(25);
            this.pnPlataformas.Size = new System.Drawing.Size(445, 300);
            this.pnPlataformas.TabIndex = 2;
            this.pnPlataformas.Texto = "PLATAFORMAS";
            // 
            // pnClasificaciones
            // 
            this.pnClasificaciones.Codigo_Envio = 2;
            this.pnClasificaciones.Dock = System.Windows.Forms.DockStyle.Fill;
        
            this.pnClasificaciones.Location = new System.Drawing.Point(452, 3);
            this.pnClasificaciones.Name = "pnClasificaciones";
            this.pnClasificaciones.PaddingInt = new System.Windows.Forms.Padding(10);
            this.pnClasificaciones.PaddingOut = new System.Windows.Forms.Padding(25);
            this.pnClasificaciones.Size = new System.Drawing.Size(443, 300);
            this.pnClasificaciones.TabIndex = 1;
            this.pnClasificaciones.Texto = "CLASIFICACIONES";
            // 
            // pnDesarrolladoras
            // 
            this.pnDesarrolladoras.Codigo_Envio = 1;
            this.pnDesarrolladoras.Dock = System.Windows.Forms.DockStyle.Fill;
      
            this.pnDesarrolladoras.Location = new System.Drawing.Point(3, 3);
            this.pnDesarrolladoras.Name = "pnDesarrolladoras";
            this.pnDesarrolladoras.PaddingInt = new System.Windows.Forms.Padding(10);
            this.pnDesarrolladoras.PaddingOut = new System.Windows.Forms.Padding(25);
            this.pnDesarrolladoras.Size = new System.Drawing.Size(443, 300);
            this.pnDesarrolladoras.TabIndex = 0;
            this.pnDesarrolladoras.Texto = "DESARROLLADORAS";
            this.pnDesarrolladoras.Load += new System.EventHandler(this.pnDesarrolladoras_Load);
            // 
            // pnCard1
            // 
            this.pnCard1.Codigo_Envio = 4;
            this.pnCard1.Dock = System.Windows.Forms.DockStyle.Fill;
          
            this.pnCard1.Location = new System.Drawing.Point(452, 309);
            this.pnCard1.Name = "pnCard1";
            this.pnCard1.PaddingInt = new System.Windows.Forms.Padding(10);
            this.pnCard1.PaddingOut = new System.Windows.Forms.Padding(25);
            this.pnCard1.Size = new System.Drawing.Size(443, 301);
            this.pnCard1.TabIndex = 4;
            this.pnCard1.Texto = "IDIOMAS";
            // 
            // pnCard2
            // 
            this.pnCard2.Codigo_Envio = 4;
            this.pnCard2.Dock = System.Windows.Forms.DockStyle.Fill;
        
            this.pnCard2.Location = new System.Drawing.Point(901, 309);
            this.pnCard2.Name = "pnCard2";
            this.pnCard2.PaddingInt = new System.Windows.Forms.Padding(10);
            this.pnCard2.PaddingOut = new System.Windows.Forms.Padding(25);
            this.pnCard2.Size = new System.Drawing.Size(445, 301);
            this.pnCard2.TabIndex = 5;
            this.pnCard2.Texto = "IDIOMAS";
            // 
            // VentanaAjustes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1449, 837);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VentanaAjustes";
            this.Text = "VentanaAjustes";
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Controladores.pnCard pnDesarrolladoras;
        private Controladores.pnCard pnIdiomas;
        private Controladores.pnCard pnPlataformas;
        private Controladores.pnCard pnClasificaciones;
        private Controladores.pnCard pnCard2;
        private Controladores.pnCard pnCard1;
    }
}