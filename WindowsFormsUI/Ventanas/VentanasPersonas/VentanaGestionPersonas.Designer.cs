namespace WindowsFormsUI.Ventanas.VentanasPersonas
{
    partial class VentanaGestionPersonas
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
            this.pnPaginate = new System.Windows.Forms.Panel();
            this.fomrPaginador1 = new WindowsFormsUI.Ventanas._Componentes.FomrPaginador();
            this.pnFiltros = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureHover4 = new System.Windows.Forms.PictureHover();
            this.ptbxListView = new System.Windows.Forms.PictureHover();
            this.ptbxCardView = new System.Windows.Forms.PictureHover();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pnBusqueda1 = new WindowsFormsUI.Ventanas._Componentes.PnBusqueda();
            this.pnContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.pnPaginate.SuspendLayout();
            this.pnFiltros.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureHover4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbxListView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbxCardView)).BeginInit();
            this.SuspendLayout();
            // 
            // pnPaginate
            // 
            this.pnPaginate.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnPaginate.Controls.Add(this.fomrPaginador1);
            this.pnPaginate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnPaginate.Location = new System.Drawing.Point(0, 733);
            this.pnPaginate.Name = "pnPaginate";
            this.pnPaginate.Size = new System.Drawing.Size(1300, 59);
            this.pnPaginate.TabIndex = 1;
            // 
            // fomrPaginador1
            // 
            this.fomrPaginador1.Location = new System.Drawing.Point(518, 6);
            this.fomrPaginador1.MaxPaginas = 10;
            this.fomrPaginador1.Name = "fomrPaginador1";
            this.fomrPaginador1.Size = new System.Drawing.Size(313, 43);
            this.fomrPaginador1.TabIndex = 0;
            // 
            // pnFiltros
            // 
            this.pnFiltros.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnFiltros.Controls.Add(this.tableLayoutPanel1);
            this.pnFiltros.Controls.Add(this.comboBox1);
            this.pnFiltros.Controls.Add(this.pnBusqueda1);
            this.pnFiltros.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnFiltros.Location = new System.Drawing.Point(0, 0);
            this.pnFiltros.Name = "pnFiltros";
            this.pnFiltros.Size = new System.Drawing.Size(1300, 64);
            this.pnFiltros.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.pictureHover4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ptbxListView, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ptbxCardView, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1172, 14);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(99, 29);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // pictureHover4
            // 
            this.pictureHover4.Clicked = false;
            this.pictureHover4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureHover4.Hover = false;
            this.pictureHover4.ImageHover = null;
            this.pictureHover4.Location = new System.Drawing.Point(69, 3);
            this.pictureHover4.MargingOut = new System.Windows.Forms.Padding(0);
            this.pictureHover4.Name = "pictureHover4";
            this.pictureHover4.Size = new System.Drawing.Size(27, 23);
            this.pictureHover4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureHover4.TabIndex = 5;
            this.pictureHover4.TabStop = false;
            // 
            // ptbxListView
            // 
            this.ptbxListView.Clicked = false;
            this.ptbxListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptbxListView.Hover = false;
            this.ptbxListView.Image = global::WindowsFormsUI.Properties.Resources.menu;
            this.ptbxListView.ImageHover = null;
            this.ptbxListView.Location = new System.Drawing.Point(36, 3);
            this.ptbxListView.MargingOut = new System.Windows.Forms.Padding(0);
            this.ptbxListView.Name = "ptbxListView";
            this.ptbxListView.Size = new System.Drawing.Size(27, 23);
            this.ptbxListView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbxListView.TabIndex = 4;
            this.ptbxListView.TabStop = false;
            this.ptbxListView.Click += new System.EventHandler(this.ptbxListView_Click);
            // 
            // ptbxCardView
            // 
            this.ptbxCardView.Clicked = false;
            this.ptbxCardView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptbxCardView.Hover = false;
            this.ptbxCardView.Image = global::WindowsFormsUI.Properties.Resources.grid;
            this.ptbxCardView.ImageHover = null;
            this.ptbxCardView.Location = new System.Drawing.Point(3, 3);
            this.ptbxCardView.MargingOut = new System.Windows.Forms.Padding(0);
            this.ptbxCardView.Name = "ptbxCardView";
            this.ptbxCardView.Size = new System.Drawing.Size(27, 23);
            this.ptbxCardView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbxCardView.TabIndex = 3;
            this.ptbxCardView.TabStop = false;
            this.ptbxCardView.Click += new System.EventHandler(this.ptbxCardView_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(241, 21);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(148, 24);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // pnBusqueda1
            // 
            this.pnBusqueda1.BackColor = System.Drawing.Color.White;
            this.pnBusqueda1.Location = new System.Drawing.Point(35, 20);
            this.pnBusqueda1.Name = "pnBusqueda1";
            this.pnBusqueda1.Size = new System.Drawing.Size(181, 25);
            this.pnBusqueda1.TabIndex = 0;
            // 
            // pnContainer
            // 
            this.pnContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContainer.Location = new System.Drawing.Point(0, 64);
            this.pnContainer.Name = "pnContainer";
            this.pnContainer.Size = new System.Drawing.Size(1300, 669);
            this.pnContainer.TabIndex = 2;
            // 
            // VentanaGestionPersonas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 792);
            this.Controls.Add(this.pnContainer);
            this.Controls.Add(this.pnFiltros);
            this.Controls.Add(this.pnPaginate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VentanaGestionPersonas";
            this.Text = "VentanaGestionPersonas";
            this.pnPaginate.ResumeLayout(false);
            this.pnFiltros.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureHover4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbxListView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbxCardView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnPaginate;
        private System.Windows.Forms.Panel pnFiltros;
        private _Componentes.PnBusqueda pnBusqueda1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureHover pictureHover4;
        private System.Windows.Forms.PictureHover ptbxListView;
        private System.Windows.Forms.PictureHover ptbxCardView;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.FlowLayoutPanel pnContainer;
        private _Componentes.FomrPaginador fomrPaginador1;
    }
}