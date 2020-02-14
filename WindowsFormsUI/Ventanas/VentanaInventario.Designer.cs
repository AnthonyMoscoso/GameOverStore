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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureHover1 = new System.Windows.Forms.PictureHover();
            this.pictureHover2 = new System.Windows.Forms.PictureHover();
            this.pictureHover3 = new System.Windows.Forms.PictureHover();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.pnSearch = new System.Windows.Forms.Panel();
            this.hintText1 = new System.Windows.Forms.HintText();
            this.ptbxSearch = new System.Windows.Forms.PictureBox();
            this.ptbxCancelSearch = new System.Windows.Forms.PictureBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureHover1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHover2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHover3)).BeginInit();
            this.pnSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbxSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbxCancelSearch)).BeginInit();
            this.pnFiltros.SuspendLayout();
            this.pnTituloFilterByPlataformas.SuspendLayout();
            this.pnTituloFilterByGeneros.SuspendLayout();
            this.pnTituloFiltro.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.pnSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1311, 116);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.pictureHover1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureHover2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureHover3, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(715, 47);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(140, 42);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // pictureHover1
            // 
            this.pictureHover1.Clicked = false;
            this.pictureHover1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureHover1.Hover = true;
            
            this.pictureHover1.Location = new System.Drawing.Point(4, 4);
            this.pictureHover1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureHover1.MargingOut = new System.Windows.Forms.Padding(4);
            this.pictureHover1.MarginInt = new System.Windows.Forms.Padding(2);
            this.pictureHover1.Name = "pictureHover1";
            this.pictureHover1.Size = new System.Drawing.Size(38, 34);
            this.pictureHover1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureHover1.TabIndex = 11;
            this.pictureHover1.TabStop = false;
            // 
            // pictureHover2
            // 
            this.pictureHover2.Clicked = false;
            this.pictureHover2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureHover2.Hover = false;
            this.pictureHover2.ImageHover = null;
            this.pictureHover2.ImageInicial = null;
            this.pictureHover2.Location = new System.Drawing.Point(49, 3);
            this.pictureHover2.MargingOut = new System.Windows.Forms.Padding(10);
            this.pictureHover2.MarginInt = new System.Windows.Forms.Padding(5);
            this.pictureHover2.Name = "pictureHover2";
            this.pictureHover2.Size = new System.Drawing.Size(40, 36);
            this.pictureHover2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureHover2.TabIndex = 12;
            this.pictureHover2.TabStop = false;
            // 
            // pictureHover3
            // 
            this.pictureHover3.Clicked = false;
            this.pictureHover3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureHover3.Hover = false;
            this.pictureHover3.ImageHover = null;
            this.pictureHover3.ImageInicial = null;
            this.pictureHover3.Location = new System.Drawing.Point(95, 3);
            this.pictureHover3.MargingOut = new System.Windows.Forms.Padding(10);
            this.pictureHover3.MarginInt = new System.Windows.Forms.Padding(5);
            this.pictureHover3.Name = "pictureHover3";
            this.pictureHover3.Size = new System.Drawing.Size(42, 36);
            this.pictureHover3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureHover3.TabIndex = 13;
            this.pictureHover3.TabStop = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(328, 67);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(280, 22);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // pnSearch
            // 
            this.pnSearch.Controls.Add(this.hintText1);
            this.pnSearch.Controls.Add(this.ptbxSearch);
            this.pnSearch.Controls.Add(this.ptbxCancelSearch);
            this.pnSearch.Location = new System.Drawing.Point(12, 61);
            this.pnSearch.Name = "pnSearch";
            this.pnSearch.Size = new System.Drawing.Size(222, 28);
            this.pnSearch.TabIndex = 3;
            // 
            // hintText1
            // 
            this.hintText1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hintText1.ForeColor = System.Drawing.Color.Gray;
            this.hintText1.Hint = null;
            this.hintText1.Location = new System.Drawing.Point(32, 0);
            this.hintText1.Multiline = true;
            this.hintText1.Name = "hintText1";
            this.hintText1.Size = new System.Drawing.Size(156, 28);
            this.hintText1.TabIndex = 10;
            // 
            // ptbxSearch
            // 
            this.ptbxSearch.Dock = System.Windows.Forms.DockStyle.Left;
            this.ptbxSearch.Location = new System.Drawing.Point(0, 0);
            this.ptbxSearch.Name = "ptbxSearch";
            this.ptbxSearch.Size = new System.Drawing.Size(32, 28);
            this.ptbxSearch.TabIndex = 1;
            this.ptbxSearch.TabStop = false;
            // 
            // ptbxCancelSearch
            // 
            this.ptbxCancelSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.ptbxCancelSearch.Location = new System.Drawing.Point(188, 0);
            this.ptbxCancelSearch.Name = "ptbxCancelSearch";
            this.ptbxCancelSearch.Size = new System.Drawing.Size(34, 28);
            this.ptbxCancelSearch.TabIndex = 2;
            this.ptbxCancelSearch.TabStop = false;
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
            this.pnFiltros.Location = new System.Drawing.Point(1055, 116);
            this.pnFiltros.Name = "pnFiltros";
            this.pnFiltros.Size = new System.Drawing.Size(256, 772);
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
            this.pnContainerElements.Location = new System.Drawing.Point(0, 116);
            this.pnContainerElements.Name = "pnContainerElements";
            this.pnContainerElements.Size = new System.Drawing.Size(1055, 772);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureHover1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHover2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHover3)).EndInit();
            this.pnSearch.ResumeLayout(false);
            this.pnSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbxSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbxCancelSearch)).EndInit();
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
        private System.Windows.Forms.Panel pnSearch;
        private System.Windows.Forms.PictureBox ptbxSearch;
        private System.Windows.Forms.PictureBox ptbxCancelSearch;
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
        private System.Windows.Forms.HintText hintText1;
        private System.Windows.Forms.FlowLayoutPanel pnContainerElements;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureHover pictureHover1;
        private System.Windows.Forms.PictureHover pictureHover2;
        private System.Windows.Forms.PictureHover pictureHover3;
    }
}