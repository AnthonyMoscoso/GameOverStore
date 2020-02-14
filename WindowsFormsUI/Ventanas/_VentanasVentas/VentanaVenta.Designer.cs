namespace WindowsFormsUI.Ventanas
{
    partial class VentanaVenta
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
            this.pnBody = new System.Windows.Forms.Panel();
            this.pnProductos = new System.Windows.Forms.FlowLayoutPanel();
            this.pnTop = new System.Windows.Forms.Panel();
            this.pnSearch = new WindowsFormsUI.Ventanas._Componentes.PnBusqueda();
            this.pnDown = new System.Windows.Forms.Panel();
            this.fomrPaginador1 = new WindowsFormsUI.Ventanas._Componentes.FomrPaginador();
            this.pnRight = new System.Windows.Forms.Panel();
            this.pnCarrito = new System.Windows.Forms.Panel();
            this.pnCarritoCompra = new System.Windows.Forms.FlowLayoutPanel();
            this.pnTopCarrito = new System.Windows.Forms.Panel();
            this.pnDownCarrito = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnButton = new System.Windows.Forms.Panel();
            this.buttonHover2 = new System.Windows.Forms.ButtonHover();
            this.buttonHover1 = new System.Windows.Forms.ButtonHover();
            this.pnBody.SuspendLayout();
            this.pnTop.SuspendLayout();
            this.pnDown.SuspendLayout();
            this.pnRight.SuspendLayout();
            this.pnCarrito.SuspendLayout();
            this.pnDownCarrito.SuspendLayout();
            this.pnButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnBody
            // 
            this.pnBody.Controls.Add(this.pnProductos);
            this.pnBody.Controls.Add(this.pnTop);
            this.pnBody.Controls.Add(this.pnDown);
            this.pnBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnBody.Location = new System.Drawing.Point(0, 0);
            this.pnBody.Name = "pnBody";
            this.pnBody.Size = new System.Drawing.Size(1026, 825);
            this.pnBody.TabIndex = 0;
            // 
            // pnProductos
            // 
            this.pnProductos.AutoScroll = true;
            this.pnProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnProductos.Location = new System.Drawing.Point(0, 54);
            this.pnProductos.Name = "pnProductos";
            this.pnProductos.Size = new System.Drawing.Size(1026, 705);
            this.pnProductos.TabIndex = 2;
            // 
            // pnTop
            // 
            this.pnTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnTop.Controls.Add(this.pnSearch);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.Location = new System.Drawing.Point(0, 0);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(1026, 54);
            this.pnTop.TabIndex = 1;
            // 
            // pnSearch
            // 
            this.pnSearch.BackColor = System.Drawing.Color.White;
            this.pnSearch.Location = new System.Drawing.Point(32, 12);
            this.pnSearch.Name = "pnSearch";
            this.pnSearch.Size = new System.Drawing.Size(170, 24);
            this.pnSearch.TabIndex = 0;
            // 
            // pnDown
            // 
            this.pnDown.Controls.Add(this.fomrPaginador1);
            this.pnDown.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnDown.Location = new System.Drawing.Point(0, 759);
            this.pnDown.Name = "pnDown";
            this.pnDown.Size = new System.Drawing.Size(1026, 66);
            this.pnDown.TabIndex = 0;
            // 
            // fomrPaginador1
            // 
            this.fomrPaginador1.Location = new System.Drawing.Point(364, 7);
            this.fomrPaginador1.MaxPaginas = 10;
            this.fomrPaginador1.Name = "fomrPaginador1";
            this.fomrPaginador1.Size = new System.Drawing.Size(332, 47);
            this.fomrPaginador1.TabIndex = 0;
            // 
            // pnRight
            // 
            this.pnRight.Controls.Add(this.pnCarrito);
            this.pnRight.Controls.Add(this.pnButton);
            this.pnRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnRight.Location = new System.Drawing.Point(1026, 0);
            this.pnRight.Name = "pnRight";
            this.pnRight.Size = new System.Drawing.Size(453, 825);
            this.pnRight.TabIndex = 1;
            // 
            // pnCarrito
            // 
            this.pnCarrito.Controls.Add(this.pnCarritoCompra);
            this.pnCarrito.Controls.Add(this.pnTopCarrito);
            this.pnCarrito.Controls.Add(this.pnDownCarrito);
            this.pnCarrito.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnCarrito.Location = new System.Drawing.Point(0, 0);
            this.pnCarrito.Name = "pnCarrito";
            this.pnCarrito.Size = new System.Drawing.Size(453, 740);
            this.pnCarrito.TabIndex = 0;
            // 
            // pnCarritoCompra
            // 
            this.pnCarritoCompra.AutoScroll = true;
            this.pnCarritoCompra.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnCarritoCompra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnCarritoCompra.Location = new System.Drawing.Point(0, 54);
            this.pnCarritoCompra.Name = "pnCarritoCompra";
            this.pnCarritoCompra.Size = new System.Drawing.Size(453, 611);
            this.pnCarritoCompra.TabIndex = 1;
            // 
            // pnTopCarrito
            // 
            this.pnTopCarrito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnTopCarrito.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTopCarrito.Location = new System.Drawing.Point(0, 0);
            this.pnTopCarrito.Name = "pnTopCarrito";
            this.pnTopCarrito.Size = new System.Drawing.Size(453, 54);
            this.pnTopCarrito.TabIndex = 0;
            // 
            // pnDownCarrito
            // 
            this.pnDownCarrito.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnDownCarrito.Controls.Add(this.label2);
            this.pnDownCarrito.Controls.Add(this.label1);
            this.pnDownCarrito.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnDownCarrito.Location = new System.Drawing.Point(0, 665);
            this.pnDownCarrito.Name = "pnDownCarrito";
            this.pnDownCarrito.Size = new System.Drawing.Size(453, 75);
            this.pnDownCarrito.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(263, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(378, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // pnButton
            // 
            this.pnButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnButton.Controls.Add(this.buttonHover2);
            this.pnButton.Controls.Add(this.buttonHover1);
            this.pnButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnButton.Location = new System.Drawing.Point(0, 740);
            this.pnButton.Name = "pnButton";
            this.pnButton.Size = new System.Drawing.Size(453, 85);
            this.pnButton.TabIndex = 1;
            // 
            // buttonHover2
            // 
            this.buttonHover2.ButtonBorderStyle = System.Windows.Forms.ButtonBorderStyle.None;
            this.buttonHover2.Location = new System.Drawing.Point(163, 31);
            this.buttonHover2.Name = "buttonHover2";
            this.buttonHover2.Size = new System.Drawing.Size(129, 42);
            this.buttonHover2.TabIndex = 1;
            this.buttonHover2.Text = "buttonHover2";
            this.buttonHover2.UseVisualStyleBackColor = true;
            // 
            // buttonHover1
            // 
            this.buttonHover1.ButtonBorderStyle = System.Windows.Forms.ButtonBorderStyle.None;
            this.buttonHover1.Location = new System.Drawing.Point(318, 31);
            this.buttonHover1.Name = "buttonHover1";
            this.buttonHover1.Size = new System.Drawing.Size(123, 42);
            this.buttonHover1.TabIndex = 0;
            this.buttonHover1.Text = "buttonHover1";
            this.buttonHover1.UseVisualStyleBackColor = true;
            // 
            // VentanaVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1479, 825);
            this.Controls.Add(this.pnBody);
            this.Controls.Add(this.pnRight);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VentanaVenta";
            this.Text = "VentanaVenta";
            this.pnBody.ResumeLayout(false);
            this.pnTop.ResumeLayout(false);
            this.pnDown.ResumeLayout(false);
            this.pnRight.ResumeLayout(false);
            this.pnCarrito.ResumeLayout(false);
            this.pnDownCarrito.ResumeLayout(false);
            this.pnDownCarrito.PerformLayout();
            this.pnButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnBody;
        private System.Windows.Forms.FlowLayoutPanel pnProductos;
        private System.Windows.Forms.Panel pnTop;
        private System.Windows.Forms.Panel pnDown;
        private System.Windows.Forms.Panel pnRight;
        private System.Windows.Forms.Panel pnCarrito;
        private System.Windows.Forms.FlowLayoutPanel pnCarritoCompra;
        private System.Windows.Forms.Panel pnDownCarrito;
        private System.Windows.Forms.Panel pnButton;
        private System.Windows.Forms.ButtonHover buttonHover1;
        private System.Windows.Forms.Panel pnTopCarrito;
        private System.Windows.Forms.ButtonHover buttonHover2;
        private _Componentes.FomrPaginador fomrPaginador1;
        private _Componentes.PnBusqueda pnSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}