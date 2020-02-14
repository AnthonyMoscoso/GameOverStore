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
                this.pnCard2 = new WindowsFormsUI.Controladores.pnCard();
                this.pnGeneros = new WindowsFormsUI.Controladores.pnCard();
                this.pnPlataformas = new WindowsFormsUI.Controladores.pnCard();
                this.pnClasificaciones = new WindowsFormsUI.Controladores.pnCard();
                this.pnDesarrolladoras = new WindowsFormsUI.Controladores.pnCard();
                this.pnIdiomas = new WindowsFormsUI.Controladores.pnCard();
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
                this.tableLayoutPanel1.Controls.Add(this.pnGeneros, 0, 1);
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
                // pnCard2
                // 
                this.pnCard2.Dock = System.Windows.Forms.DockStyle.Fill;
                this.pnCard2.ImagePanel = null;
                this.pnCard2.Location = new System.Drawing.Point(901, 309);
                this.pnCard2.Name = "pnCard2";
                this.pnCard2.PaddingInt = new System.Windows.Forms.Padding(10);
                this.pnCard2.PaddingOut = new System.Windows.Forms.Padding(25);
                this.pnCard2.Size = new System.Drawing.Size(445, 301);
                this.pnCard2.TabIndex = 5;
                this.pnCard2.Texto = "IDIOMAS";
                this.pnCard2.tipo_Dato = WindowsFormsUI.Controladores.pnCard.Tipo_dato.clasificaciones;
                // 
                // pnGeneros
                // 
                this.pnGeneros.Dock = System.Windows.Forms.DockStyle.Fill;
                this.pnGeneros.ImagePanel = global::WindowsFormsUI.Properties.Resources.sword;
                this.pnGeneros.Location = new System.Drawing.Point(452, 309);
                this.pnGeneros.Name = "pnGeneros";
                this.pnGeneros.PaddingInt = new System.Windows.Forms.Padding(10);
                this.pnGeneros.PaddingOut = new System.Windows.Forms.Padding(25);
                this.pnGeneros.Size = new System.Drawing.Size(443, 301);
                this.pnGeneros.TabIndex = 4;
                this.pnGeneros.Texto = "GENEROS";
                this.pnGeneros.tipo_Dato = WindowsFormsUI.Controladores.pnCard.Tipo_dato.generos;
                // 
                // pnPlataformas
                // 
                this.pnPlataformas.Dock = System.Windows.Forms.DockStyle.Fill;
                this.pnPlataformas.ImagePanel = global::WindowsFormsUI.Properties.Resources.joystick;
                this.pnPlataformas.Location = new System.Drawing.Point(901, 3);
                this.pnPlataformas.Name = "pnPlataformas";
                this.pnPlataformas.PaddingInt = new System.Windows.Forms.Padding(10);
                this.pnPlataformas.PaddingOut = new System.Windows.Forms.Padding(25);
                this.pnPlataformas.Size = new System.Drawing.Size(445, 300);
                this.pnPlataformas.TabIndex = 2;
                this.pnPlataformas.Texto = "PLATAFORMAS";
                this.pnPlataformas.tipo_Dato = WindowsFormsUI.Controladores.pnCard.Tipo_dato.plataformas;
                // 
                // pnClasificaciones
                // 
                this.pnClasificaciones.Dock = System.Windows.Forms.DockStyle.Fill;
                this.pnClasificaciones.ImagePanel = global::WindowsFormsUI.Properties.Resources.age;
                this.pnClasificaciones.Location = new System.Drawing.Point(452, 3);
                this.pnClasificaciones.Name = "pnClasificaciones";
                this.pnClasificaciones.PaddingInt = new System.Windows.Forms.Padding(10);
                this.pnClasificaciones.PaddingOut = new System.Windows.Forms.Padding(25);
                this.pnClasificaciones.Size = new System.Drawing.Size(443, 300);
                this.pnClasificaciones.TabIndex = 1;
                this.pnClasificaciones.Texto = "CLASIFICACIONES";
                this.pnClasificaciones.tipo_Dato = WindowsFormsUI.Controladores.pnCard.Tipo_dato.clasificaciones;
                // 
                // pnDesarrolladoras
                // 
                this.pnDesarrolladoras.Dock = System.Windows.Forms.DockStyle.Fill;
                this.pnDesarrolladoras.ImagePanel = global::WindowsFormsUI.Properties.Resources.programming;
                this.pnDesarrolladoras.Location = new System.Drawing.Point(3, 3);
                this.pnDesarrolladoras.Name = "pnDesarrolladoras";
                this.pnDesarrolladoras.PaddingInt = new System.Windows.Forms.Padding(10);
                this.pnDesarrolladoras.PaddingOut = new System.Windows.Forms.Padding(25);
                this.pnDesarrolladoras.Size = new System.Drawing.Size(443, 300);
                this.pnDesarrolladoras.TabIndex = 0;
                this.pnDesarrolladoras.Texto = "DESARROLLADORAS";
                this.pnDesarrolladoras.tipo_Dato = WindowsFormsUI.Controladores.pnCard.Tipo_dato.desarrolladoras;
                this.pnDesarrolladoras.Load += new System.EventHandler(this.pnDesarrolladoras_Load);
                // 
                // pnIdiomas
                // 
                this.pnIdiomas.Dock = System.Windows.Forms.DockStyle.Fill;
                this.pnIdiomas.ImagePanel = global::WindowsFormsUI.Properties.Resources.translation;
                this.pnIdiomas.Location = new System.Drawing.Point(3, 309);
                this.pnIdiomas.Name = "pnIdiomas";
                this.pnIdiomas.PaddingInt = new System.Windows.Forms.Padding(10);
                this.pnIdiomas.PaddingOut = new System.Windows.Forms.Padding(25);
                this.pnIdiomas.Size = new System.Drawing.Size(443, 301);
                this.pnIdiomas.TabIndex = 3;
                this.pnIdiomas.Texto = "IDIOMAS";
                this.pnIdiomas.tipo_Dato = WindowsFormsUI.Controladores.pnCard.Tipo_dato.idiomas;
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
            private WindowsFormsUI.Controladores.pnCard pnDesarrolladoras;
            private WindowsFormsUI.Controladores.pnCard pnIdiomas;
            private WindowsFormsUI.Controladores.pnCard pnPlataformas;
            private WindowsFormsUI.Controladores.pnCard pnClasificaciones;
            private WindowsFormsUI.Controladores.pnCard pnCard2;
            private WindowsFormsUI.Controladores.pnCard pnGeneros;
           

        
    }
}