namespace WindowsFormsUI.Ventanas
{
    partial class VentanaInventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaInventario));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnBusqueda1 = new WindowsFormsUI.Ventanas._Componentes.PnBusqueda();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ViewCard = new System.Windows.Forms.PictureHover();
            this.ViewList = new System.Windows.Forms.PictureHover();
            this.ViewTable = new System.Windows.Forms.PictureHover();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.pnFiltros = new System.Windows.Forms.Panel();
            this.pnContainerPlataformas = new System.Windows.Forms.Panel();
            this.pnTituloFilterByPlataformas = new System.Windows.Forms.Panel();
            this.btnOpenClosePlataformas = new System.Windows.Forms.Button();
            this.lbPlataformas = new System.Windows.Forms.Label();
            this.pnContainerGeneros = new System.Windows.Forms.Panel();
            this.pnTituloFilterByGeneros = new System.Windows.Forms.Panel();
            this.btnOpenCloseGeneros = new System.Windows.Forms.Button();
            this.lbGeneros = new System.Windows.Forms.Label();
            this.pnTituloFiltro = new System.Windows.Forms.Panel();
            this.lbFiltros = new System.Windows.Forms.Label();
            this.pnContainerElements = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewTable)).BeginInit();
            this.pnFiltros.SuspendLayout();
            this.pnTituloFilterByPlataformas.SuspendLayout();
            this.pnTituloFilterByGeneros.SuspendLayout();
            this.pnTituloFiltro.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.pnBusqueda1);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1311, 74);
            this.panel1.TabIndex = 0;
            // 
            // pnBusqueda1
            // 
            this.pnBusqueda1.BackColor = System.Drawing.Color.White;
            this.pnBusqueda1.Location = new System.Drawing.Point(30, 17);
            this.pnBusqueda1.Name = "pnBusqueda1";
            this.pnBusqueda1.Size = new System.Drawing.Size(197, 22);
            this.pnBusqueda1.TabIndex = 11;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.ViewCard, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ViewList, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.ViewTable, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(907, 13);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(123, 42);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // ViewCard
            // 
            this.ViewCard.Clicked = false;
            this.ViewCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ViewCard.Hover = true;
            this.ViewCard.Image = global::WindowsFormsUI.Properties.Resources.grid;
            this.ViewCard.ImageHover = null;
            this.ViewCard.Location = new System.Drawing.Point(4, 4);
            this.ViewCard.Margin = new System.Windows.Forms.Padding(4);
            this.ViewCard.MargingOut = new System.Windows.Forms.Padding(4);
            this.ViewCard.Name = "ViewCard";
            this.ViewCard.Size = new System.Drawing.Size(33, 34);
            this.ViewCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ViewCard.TabIndex = 11;
            this.ViewCard.TabStop = false;
            this.ViewCard.Click += new System.EventHandler(this.ViewCard_Click);
            // 
            // ViewList
            // 
            this.ViewList.Clicked = false;
            this.ViewList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ViewList.Hover = true;
            this.ViewList.Image = global::WindowsFormsUI.Properties.Resources.menu;
            this.ViewList.ImageHover = ((System.Drawing.Image)(resources.GetObject("ViewList.ImageHover")));
            this.ViewList.Location = new System.Drawing.Point(44, 3);
            this.ViewList.MargingOut = new System.Windows.Forms.Padding(6);
            this.ViewList.Name = "ViewList";
            this.ViewList.Size = new System.Drawing.Size(35, 36);
            this.ViewList.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ViewList.TabIndex = 12;
            this.ViewList.TabStop = false;
            this.ViewList.Click += new System.EventHandler(this.ViewList_Click);
            // 
            // ViewTable
            // 
            this.ViewTable.Clicked = false;
            this.ViewTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ViewTable.Hover = false;
            this.ViewTable.ImageHover = null;
            this.ViewTable.Location = new System.Drawing.Point(85, 3);
            this.ViewTable.MargingOut = new System.Windows.Forms.Padding(10);
            this.ViewTable.Name = "ViewTable";
            this.ViewTable.Size = new System.Drawing.Size(35, 36);
            this.ViewTable.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ViewTable.TabIndex = 13;
            this.ViewTable.TabStop = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(436, 17);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(280, 22);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // pnFiltros
            // 
            this.pnFiltros.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnFiltros.Controls.Add(this.pnContainerPlataformas);
            this.pnFiltros.Controls.Add(this.pnTituloFilterByPlataformas);
            this.pnFiltros.Controls.Add(this.pnContainerGeneros);
            this.pnFiltros.Controls.Add(this.pnTituloFilterByGeneros);
            this.pnFiltros.Controls.Add(this.pnTituloFiltro);
            this.pnFiltros.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnFiltros.Location = new System.Drawing.Point(1055, 74);
            this.pnFiltros.Name = "pnFiltros";
            this.pnFiltros.Size = new System.Drawing.Size(256, 814);
            this.pnFiltros.TabIndex = 1;
            // 
            // pnContainerPlataformas
            // 
            this.pnContainerPlataformas.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnContainerPlataformas.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnContainerPlataformas.Location = new System.Drawing.Point(0, 471);
            this.pnContainerPlataformas.Name = "pnContainerPlataformas";
            this.pnContainerPlataformas.Size = new System.Drawing.Size(256, 286);
            this.pnContainerPlataformas.TabIndex = 4;
            // 
            // pnTituloFilterByPlataformas
            // 
            this.pnTituloFilterByPlataformas.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnTituloFilterByPlataformas.Controls.Add(this.btnOpenClosePlataformas);
            this.pnTituloFilterByPlataformas.Controls.Add(this.lbPlataformas);
            this.pnTituloFilterByPlataformas.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTituloFilterByPlataformas.Location = new System.Drawing.Point(0, 398);
            this.pnTituloFilterByPlataformas.Name = "pnTituloFilterByPlataformas";
            this.pnTituloFilterByPlataformas.Size = new System.Drawing.Size(256, 73);
            this.pnTituloFilterByPlataformas.TabIndex = 3;
            // 
            // btnOpenClosePlataformas
            // 
            this.btnOpenClosePlataformas.Location = new System.Drawing.Point(201, 29);
            this.btnOpenClosePlataformas.Name = "btnOpenClosePlataformas";
            this.btnOpenClosePlataformas.Size = new System.Drawing.Size(31, 29);
            this.btnOpenClosePlataformas.TabIndex = 2;
            this.btnOpenClosePlataformas.Text = "v";
            this.btnOpenClosePlataformas.UseVisualStyleBackColor = true;
            this.btnOpenClosePlataformas.Click += new System.EventHandler(this.btnOpenClosePlataformas_Click);
            // 
            // lbPlataformas
            // 
            this.lbPlataformas.AutoSize = true;
            this.lbPlataformas.Location = new System.Drawing.Point(20, 29);
            this.lbPlataformas.Name = "lbPlataformas";
            this.lbPlataformas.Size = new System.Drawing.Size(83, 17);
            this.lbPlataformas.TabIndex = 0;
            this.lbPlataformas.Text = "Plataformas";
            // 
            // pnContainerGeneros
            // 
            this.pnContainerGeneros.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnContainerGeneros.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnContainerGeneros.Location = new System.Drawing.Point(0, 125);
            this.pnContainerGeneros.Name = "pnContainerGeneros";
            this.pnContainerGeneros.Size = new System.Drawing.Size(256, 273);
            this.pnContainerGeneros.TabIndex = 2;
            // 
            // pnTituloFilterByGeneros
            // 
            this.pnTituloFilterByGeneros.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnTituloFilterByGeneros.Controls.Add(this.btnOpenCloseGeneros);
            this.pnTituloFilterByGeneros.Controls.Add(this.lbGeneros);
            this.pnTituloFilterByGeneros.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTituloFilterByGeneros.Location = new System.Drawing.Point(0, 59);
            this.pnTituloFilterByGeneros.Name = "pnTituloFilterByGeneros";
            this.pnTituloFilterByGeneros.Size = new System.Drawing.Size(256, 66);
            this.pnTituloFilterByGeneros.TabIndex = 1;
            // 
            // btnOpenCloseGeneros
            // 
            this.btnOpenCloseGeneros.Location = new System.Drawing.Point(189, 21);
            this.btnOpenCloseGeneros.Name = "btnOpenCloseGeneros";
            this.btnOpenCloseGeneros.Size = new System.Drawing.Size(35, 28);
            this.btnOpenCloseGeneros.TabIndex = 1;
            this.btnOpenCloseGeneros.Text = "v";
            this.btnOpenCloseGeneros.UseVisualStyleBackColor = true;
            // 
            // lbGeneros
            // 
            this.lbGeneros.Location = new System.Drawing.Point(20, 21);
            this.lbGeneros.Name = "lbGeneros";
            this.lbGeneros.Size = new System.Drawing.Size(150, 28);
            this.lbGeneros.TabIndex = 0;
            this.lbGeneros.Text = "Generos";
            // 
            // pnTituloFiltro
            // 
            this.pnTituloFiltro.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnTituloFiltro.Controls.Add(this.lbFiltros);
            this.pnTituloFiltro.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTituloFiltro.Location = new System.Drawing.Point(0, 0);
            this.pnTituloFiltro.Name = "pnTituloFiltro";
            this.pnTituloFiltro.Size = new System.Drawing.Size(256, 59);
            this.pnTituloFiltro.TabIndex = 0;
            // 
            // lbFiltros
            // 
            this.lbFiltros.AutoSize = true;
            this.lbFiltros.Location = new System.Drawing.Point(20, 15);
            this.lbFiltros.Name = "lbFiltros";
            this.lbFiltros.Size = new System.Drawing.Size(66, 17);
            this.lbFiltros.TabIndex = 0;
            this.lbFiltros.Text = "FILTROS";
            // 
            // pnContainerElements
            // 
            this.pnContainerElements.AutoScroll = true;
            this.pnContainerElements.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnContainerElements.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContainerElements.Location = new System.Drawing.Point(0, 74);
            this.pnContainerElements.Name = "pnContainerElements";
            this.pnContainerElements.Size = new System.Drawing.Size(1055, 814);
            this.pnContainerElements.TabIndex = 2;
            // 
            // VentanaInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1311, 888);
            this.Controls.Add(this.pnContainerElements);
            this.Controls.Add(this.pnFiltros);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VentanaInventario";
            this.Text = "Inventario";
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ViewCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ViewTable)).EndInit();
            this.pnFiltros.ResumeLayout(false);
            this.pnTituloFilterByPlataformas.ResumeLayout(false);
            this.pnTituloFilterByPlataformas.PerformLayout();
            this.pnTituloFilterByGeneros.ResumeLayout(false);
            this.pnTituloFiltro.ResumeLayout(false);
            this.pnTituloFiltro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnFiltros;
        private System.Windows.Forms.Panel pnContainerPlataformas;
        private System.Windows.Forms.Panel pnTituloFilterByPlataformas;
        private System.Windows.Forms.Button btnOpenClosePlataformas;
        private System.Windows.Forms.Label lbPlataformas;
        private System.Windows.Forms.Panel pnContainerGeneros;
        private System.Windows.Forms.Panel pnTituloFilterByGeneros;
        private System.Windows.Forms.Button btnOpenCloseGeneros;
        private System.Windows.Forms.Label lbGeneros;
        private System.Windows.Forms.Panel pnTituloFiltro;
        private System.Windows.Forms.Label lbFiltros;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.FlowLayoutPanel pnContainerElements;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureHover ViewCard;
        private System.Windows.Forms.PictureHover ViewList;
        private System.Windows.Forms.PictureHover ViewTable;
        private _Componentes.PnBusqueda pnBusqueda1;
    }
}