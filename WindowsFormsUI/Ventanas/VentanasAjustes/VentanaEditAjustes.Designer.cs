namespace WindowsFormsUI.Ventanas
{
    partial class VentanaEditAjustes
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
            this.ptxImage = new System.Windows.Forms.PictureBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnDatos = new System.Windows.Forms.Panel();
            this.pnDescripcion = new System.Windows.Forms.Panel();
            this.alertDescripcion = new System.Windows.Forms.AlertPictureBox();
            this.lbDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.HintText();
            this.pnNombre = new System.Windows.Forms.Panel();
            this.alertNombre = new System.Windows.Forms.AlertPictureBox();
            this.lbNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.HintText();
            this.pnId = new System.Windows.Forms.Panel();
            this.lbId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.HintText();
            this.panel2 = new System.Windows.Forms.Panel();
            this.alertImagen = new System.Windows.Forms.AlertPictureBox();
            this.btnOpenImage = new System.Windows.Forms.Button();
            this.txtImagen = new System.Windows.Forms.HintText();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pnContenedor = new System.Windows.Forms.FlowLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnVolver = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel6 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ptxImage)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnDatos.SuspendLayout();
            this.pnDescripcion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alertDescripcion)).BeginInit();
            this.pnNombre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alertNombre)).BeginInit();
            this.pnId.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alertImagen)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // ptxImage
            // 
            this.ptxImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptxImage.Image = global::WindowsFormsUI.Properties.Resources._59517;
            this.ptxImage.Location = new System.Drawing.Point(28, 18);
            this.ptxImage.Name = "ptxImage";
            this.ptxImage.Size = new System.Drawing.Size(207, 190);
            this.ptxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptxImage.TabIndex = 1;
            this.ptxImage.TabStop = false;
            this.ptxImage.Click += new System.EventHandler(this.ptxImage_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAdd.Location = new System.Drawing.Point(581, 15);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(99, 39);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClear.Location = new System.Drawing.Point(472, 15);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(109, 39);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnDatos);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(695, 321);
            this.panel1.TabIndex = 7;
            // 
            // pnDatos
            // 
            this.pnDatos.Controls.Add(this.pnDescripcion);
            this.pnDatos.Controls.Add(this.pnNombre);
            this.pnDatos.Controls.Add(this.pnId);
            this.pnDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnDatos.Location = new System.Drawing.Point(255, 0);
            this.pnDatos.Name = "pnDatos";
            this.pnDatos.Size = new System.Drawing.Size(440, 321);
            this.pnDatos.TabIndex = 11;
            // 
            // pnDescripcion
            // 
            this.pnDescripcion.Controls.Add(this.alertDescripcion);
            this.pnDescripcion.Controls.Add(this.lbDescripcion);
            this.pnDescripcion.Controls.Add(this.txtDescripcion);
            this.pnDescripcion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnDescripcion.Location = new System.Drawing.Point(0, 108);
            this.pnDescripcion.Name = "pnDescripcion";
            this.pnDescripcion.Size = new System.Drawing.Size(440, 213);
            this.pnDescripcion.TabIndex = 11;
            this.pnDescripcion.Visible = false;
            // 
            // alertDescripcion
            // 
            this.alertDescripcion.Location = new System.Drawing.Point(343, 16);
            this.alertDescripcion.Name = "alertDescripcion";
            this.alertDescripcion.Size = new System.Drawing.Size(29, 29);
            this.alertDescripcion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.alertDescripcion.TabIndex = 9;
            this.alertDescripcion.TabStop = false;
            this.alertDescripcion.Visible = false;
            // 
            // lbDescripcion
            // 
            this.lbDescripcion.AutoSize = true;
            this.lbDescripcion.Location = new System.Drawing.Point(29, 18);
            this.lbDescripcion.Name = "lbDescripcion";
            this.lbDescripcion.Size = new System.Drawing.Size(82, 17);
            this.lbDescripcion.TabIndex = 8;
            this.lbDescripcion.Text = "Descripcion";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.ForeColor = System.Drawing.Color.Gray;
            this.txtDescripcion.Hint = "Descripcion  aquellos dias del 12 de octubre";
            this.txtDescripcion.Location = new System.Drawing.Point(32, 51);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(340, 139);
            this.txtDescripcion.TabIndex = 4;
            this.txtDescripcion.Text = "Descripcion  aquellos dias del 12 de octubre";
            // 
            // pnNombre
            // 
            this.pnNombre.Controls.Add(this.alertNombre);
            this.pnNombre.Controls.Add(this.lbNombre);
            this.pnNombre.Controls.Add(this.txtNombre);
            this.pnNombre.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnNombre.Location = new System.Drawing.Point(0, 49);
            this.pnNombre.Name = "pnNombre";
            this.pnNombre.Size = new System.Drawing.Size(440, 59);
            this.pnNombre.TabIndex = 10;
            // 
            // alertNombre
            // 
            this.alertNombre.Location = new System.Drawing.Point(343, -1);
            this.alertNombre.Name = "alertNombre";
            this.alertNombre.Size = new System.Drawing.Size(29, 29);
            this.alertNombre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.alertNombre.TabIndex = 5;
            this.alertNombre.TabStop = false;
            this.alertNombre.Visible = false;
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(22, 11);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(58, 17);
            this.lbNombre.TabIndex = 4;
            this.lbNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.ForeColor = System.Drawing.Color.Gray;
            this.txtNombre.Hint = "Nombre : Ejemplo etc";
            this.txtNombre.Location = new System.Drawing.Point(25, 31);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(340, 22);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.Text = "Nombre : Ejemplo etc";
            // 
            // pnId
            // 
            this.pnId.Controls.Add(this.lbId);
            this.pnId.Controls.Add(this.txtId);
            this.pnId.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnId.Location = new System.Drawing.Point(0, 0);
            this.pnId.Name = "pnId";
            this.pnId.Size = new System.Drawing.Size(440, 49);
            this.pnId.TabIndex = 9;
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(284, 18);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(21, 17);
            this.lbId.TabIndex = 7;
            this.lbId.Text = "ID";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.ForeColor = System.Drawing.Color.Gray;
            this.txtId.Hint = null;
            this.txtId.Location = new System.Drawing.Point(326, 11);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(46, 22);
            this.txtId.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.alertImagen);
            this.panel2.Controls.Add(this.btnOpenImage);
            this.panel2.Controls.Add(this.txtImagen);
            this.panel2.Controls.Add(this.ptxImage);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(255, 321);
            this.panel2.TabIndex = 10;
            // 
            // alertImagen
            // 
            this.alertImagen.Location = new System.Drawing.Point(206, 282);
            this.alertImagen.Name = "alertImagen";
            this.alertImagen.Size = new System.Drawing.Size(29, 29);
            this.alertImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.alertImagen.TabIndex = 8;
            this.alertImagen.TabStop = false;
            this.alertImagen.Visible = false;
            // 
            // btnOpenImage
            // 
            this.btnOpenImage.Location = new System.Drawing.Point(28, 214);
            this.btnOpenImage.Name = "btnOpenImage";
            this.btnOpenImage.Size = new System.Drawing.Size(207, 34);
            this.btnOpenImage.TabIndex = 9;
            this.btnOpenImage.Text = "button3";
            this.btnOpenImage.UseVisualStyleBackColor = true;
            this.btnOpenImage.Click += new System.EventHandler(this.btnOpenImage_Click);
            // 
            // txtImagen
            // 
            this.txtImagen.ForeColor = System.Drawing.Color.Gray;
            this.txtImagen.Hint = null;
            this.txtImagen.Location = new System.Drawing.Point(28, 254);
            this.txtImagen.Name = "txtImagen";
            this.txtImagen.Size = new System.Drawing.Size(207, 22);
            this.txtImagen.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnClear);
            this.panel3.Controls.Add(this.btnAdd);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 321);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(15);
            this.panel3.Size = new System.Drawing.Size(695, 69);
            this.panel3.TabIndex = 9;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(481, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(695, 690);
            this.panel4.TabIndex = 10;
            // 
            // pnContenedor
            // 
            this.pnContenedor.AutoScroll = true;
            this.pnContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContenedor.Location = new System.Drawing.Point(0, 0);
            this.pnContenedor.Name = "pnContenedor";
            this.pnContenedor.Size = new System.Drawing.Size(481, 690);
            this.pnContenedor.TabIndex = 11;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnVolver);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1176, 57);
            this.panel5.TabIndex = 12;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(12, 12);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(102, 39);
            this.btnVolver.TabIndex = 0;
            this.btnVolver.Text = "<";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 747);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1176, 35);
            this.flowLayoutPanel2.TabIndex = 13;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.pnContenedor);
            this.panel6.Controls.Add(this.panel4);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 57);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1176, 690);
            this.panel6.TabIndex = 14;
            // 
            // VentanaEditAjustes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 782);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.panel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VentanaEditAjustes";
            this.Text = "VentanaEditAjustes";
            this.Load += new System.EventHandler(this.VentanaEditAjustes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptxImage)).EndInit();
            this.panel1.ResumeLayout(false);
            this.pnDatos.ResumeLayout(false);
            this.pnDescripcion.ResumeLayout(false);
            this.pnDescripcion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alertDescripcion)).EndInit();
            this.pnNombre.ResumeLayout(false);
            this.pnNombre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alertNombre)).EndInit();
            this.pnId.ResumeLayout(false);
            this.pnId.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alertImagen)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox ptxImage;
        private System.Windows.Forms.HintText txtNombre;
        private System.Windows.Forms.HintText txtImagen;
        private System.Windows.Forms.HintText txtDescripcion;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.FlowLayoutPanel pnContenedor;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.HintText txtId;
        private System.Windows.Forms.Button btnOpenImage;
        private System.Windows.Forms.Label lbDescripcion;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Panel pnDatos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnDescripcion;
        private System.Windows.Forms.Panel pnNombre;
        private System.Windows.Forms.Panel pnId;
        private System.Windows.Forms.AlertPictureBox alertDescripcion;
        private System.Windows.Forms.AlertPictureBox alertNombre;
        private System.Windows.Forms.AlertPictureBox alertImagen;
    }
}