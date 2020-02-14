namespace WindowsFormsUI.Ventanas._FICHAS
{
    partial class _FichaPersona
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
            this.pnTop = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pnBody = new System.Windows.Forms.Panel();
            this.pnDatasPersona = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnPermisos = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.alertPermisos = new System.Windows.Forms.AlertPictureBox();
            this.lbPermisos = new System.Windows.Forms.Label();
            this.pnDataPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnDataTelefono = new WindowsFormsUI.Ventanas._Componentes.DataBox();
            this.pnDataEmail = new WindowsFormsUI.Ventanas._Componentes.DataBox();
            this.pnDataNombre = new WindowsFormsUI.Ventanas._Componentes.DataBox();
            this.pnDataContraseña = new WindowsFormsUI.Ventanas._Componentes.DataBox();
            this.g = new WindowsFormsUI.Ventanas._Componentes.DataBox();
            this.pnDataApellido = new WindowsFormsUI.Ventanas._Componentes.DataBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.alertImagen = new System.Windows.Forms.AlertPictureBox();
            this.txtRutaImagen = new System.Windows.Forms.TextBox();
            this.btnOpenDialog = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.ptbxImagen = new System.Windows.Forms.PictureHover();
            this.pnButtons = new System.Windows.Forms.Panel();
            this.btnActualizar = new System.Windows.Forms.ButtonHover();
            this.pnTop.SuspendLayout();
            this.pnBody.SuspendLayout();
            this.pnDatasPersona.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alertPermisos)).BeginInit();
            this.pnDataPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alertImagen)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbxImagen)).BeginInit();
            this.pnButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnTop
            // 
            this.pnTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnTop.Controls.Add(this.button1);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.Location = new System.Drawing.Point(0, 0);
            this.pnTop.Name = "pnTop";
            this.pnTop.Padding = new System.Windows.Forms.Padding(8);
            this.pnTop.Size = new System.Drawing.Size(1030, 43);
            this.pnTop.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.Location = new System.Drawing.Point(988, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 27);
            this.button1.TabIndex = 0;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pnBody
            // 
            this.pnBody.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnBody.Controls.Add(this.pnDatasPersona);
            this.pnBody.Controls.Add(this.panel3);
            this.pnBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnBody.Location = new System.Drawing.Point(0, 43);
            this.pnBody.Name = "pnBody";
            this.pnBody.Size = new System.Drawing.Size(1030, 480);
            this.pnBody.TabIndex = 1;
            // 
            // pnDatasPersona
            // 
            this.pnDatasPersona.Controls.Add(this.panel1);
            this.pnDatasPersona.Controls.Add(this.pnDataPanel);
            this.pnDatasPersona.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnDatasPersona.Location = new System.Drawing.Point(270, 0);
            this.pnDatasPersona.Name = "pnDatasPersona";
            this.pnDatasPersona.Size = new System.Drawing.Size(760, 480);
            this.pnDatasPersona.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnPermisos);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 231);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(760, 249);
            this.panel1.TabIndex = 1;
            // 
            // pnPermisos
            // 
            this.pnPermisos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnPermisos.Location = new System.Drawing.Point(0, 41);
            this.pnPermisos.Name = "pnPermisos";
            this.pnPermisos.Padding = new System.Windows.Forms.Padding(15);
            this.pnPermisos.Size = new System.Drawing.Size(760, 208);
            this.pnPermisos.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.alertPermisos);
            this.panel2.Controls.Add(this.lbPermisos);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(760, 41);
            this.panel2.TabIndex = 0;
            // 
            // alertPermisos
            // 
            this.alertPermisos.Location = new System.Drawing.Point(713, 7);
            this.alertPermisos.Name = "alertPermisos";
            this.alertPermisos.Size = new System.Drawing.Size(27, 22);
            this.alertPermisos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.alertPermisos.TabIndex = 1;
            this.alertPermisos.TabStop = false;
            this.alertPermisos.Visible = false;
            // 
            // lbPermisos
            // 
            this.lbPermisos.AutoSize = true;
            this.lbPermisos.Location = new System.Drawing.Point(16, 12);
            this.lbPermisos.Name = "lbPermisos";
            this.lbPermisos.Size = new System.Drawing.Size(66, 17);
            this.lbPermisos.TabIndex = 0;
            this.lbPermisos.Text = "Permisos";
            // 
            // pnDataPanel
            // 
            this.pnDataPanel.Controls.Add(this.tableLayoutPanel1);
            this.pnDataPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnDataPanel.Location = new System.Drawing.Point(0, 0);
            this.pnDataPanel.Name = "pnDataPanel";
            this.pnDataPanel.Size = new System.Drawing.Size(760, 231);
            this.pnDataPanel.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.pnDataTelefono, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.pnDataEmail, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pnDataNombre, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnDataContraseña, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.g, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.pnDataApellido, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(760, 231);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pnDataTelefono
            // 
            this.pnDataTelefono.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnDataTelefono.Imagen = global::WindowsFormsUI.Properties.Resources.call;
            this.pnDataTelefono.IsPassword = false;
            this.pnDataTelefono.Location = new System.Drawing.Point(383, 80);
            this.pnDataTelefono.Name = "pnDataTelefono";
            this.pnDataTelefono.Size = new System.Drawing.Size(374, 71);
            this.pnDataTelefono.TabIndex = 8;
            this.pnDataTelefono.Texto = "";
            this.pnDataTelefono.TextoHint = "Insertar Telefono";
            this.pnDataTelefono.Tipo_De_Texto = WindowsFormsUI.Ventanas._Componentes.DataBox.TipeText.ONLY_NUMBERS;
            this.pnDataTelefono.Titule = "Telefono";
            // 
            // pnDataEmail
            // 
            this.pnDataEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnDataEmail.Imagen = global::WindowsFormsUI.Properties.Resources.mail;
            this.pnDataEmail.IsPassword = false;
            this.pnDataEmail.Location = new System.Drawing.Point(3, 80);
            this.pnDataEmail.Name = "pnDataEmail";
            this.pnDataEmail.Size = new System.Drawing.Size(374, 71);
            this.pnDataEmail.TabIndex = 8;
            this.pnDataEmail.Texto = "";
            this.pnDataEmail.TextoHint = "Insertar Email";
            this.pnDataEmail.Tipo_De_Texto = WindowsFormsUI.Ventanas._Componentes.DataBox.TipeText.All;
            this.pnDataEmail.Titule = "Email";
            // 
            // pnDataNombre
            // 
            this.pnDataNombre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnDataNombre.Imagen = global::WindowsFormsUI.Properties.Resources.name;
            this.pnDataNombre.IsPassword = false;
            this.pnDataNombre.Location = new System.Drawing.Point(3, 3);
            this.pnDataNombre.Name = "pnDataNombre";
            this.pnDataNombre.Size = new System.Drawing.Size(374, 71);
            this.pnDataNombre.TabIndex = 8;
            this.pnDataNombre.Texto = "";
            this.pnDataNombre.TextoHint = "Introducir Nombre";
            this.pnDataNombre.Tipo_De_Texto = WindowsFormsUI.Ventanas._Componentes.DataBox.TipeText.All;
            this.pnDataNombre.Titule = "Nombre";
            // 
            // pnDataContraseña
            // 
            this.pnDataContraseña.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnDataContraseña.Imagen = global::WindowsFormsUI.Properties.Resources.programming;
            this.pnDataContraseña.IsPassword = true;
            this.pnDataContraseña.Location = new System.Drawing.Point(3, 157);
            this.pnDataContraseña.Name = "pnDataContraseña";
            this.pnDataContraseña.Size = new System.Drawing.Size(374, 71);
            this.pnDataContraseña.TabIndex = 9;
            this.pnDataContraseña.Texto = "";
            this.pnDataContraseña.TextoHint = "Insertar Contraseña";
            this.pnDataContraseña.Tipo_De_Texto = WindowsFormsUI.Ventanas._Componentes.DataBox.TipeText.All;
            this.pnDataContraseña.Titule = "Contraseña";
            // 
            // g
            // 
            this.g.Dock = System.Windows.Forms.DockStyle.Fill;
            this.g.Imagen = null;
            this.g.IsPassword = false;
            this.g.Location = new System.Drawing.Point(383, 157);
            this.g.Name = "g";
            this.g.Size = new System.Drawing.Size(374, 71);
            this.g.TabIndex = 8;
            this.g.Texto = "";
            this.g.TextoHint = null;
            this.g.Tipo_De_Texto = WindowsFormsUI.Ventanas._Componentes.DataBox.TipeText.All;
            this.g.Titule = null;
            // 
            // pnDataApellido
            // 
            this.pnDataApellido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnDataApellido.Imagen = global::WindowsFormsUI.Properties.Resources.pencil;
            this.pnDataApellido.IsPassword = false;
            this.pnDataApellido.Location = new System.Drawing.Point(383, 3);
            this.pnDataApellido.Name = "pnDataApellido";
            this.pnDataApellido.Size = new System.Drawing.Size(374, 71);
            this.pnDataApellido.TabIndex = 7;
            this.pnDataApellido.Texto = "";
            this.pnDataApellido.TextoHint = "Insertar Apellido";
            this.pnDataApellido.Tipo_De_Texto = WindowsFormsUI.Ventanas._Componentes.DataBox.TipeText.All;
            this.pnDataApellido.Titule = "Apellido";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(270, 480);
            this.panel3.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 269);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(270, 211);
            this.panel6.TabIndex = 2;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.alertImagen);
            this.panel7.Controls.Add(this.txtRutaImagen);
            this.panel7.Controls.Add(this.btnOpenDialog);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(270, 116);
            this.panel7.TabIndex = 1;
            // 
            // alertImagen
            // 
            this.alertImagen.Location = new System.Drawing.Point(230, 3);
            this.alertImagen.Name = "alertImagen";
            this.alertImagen.Size = new System.Drawing.Size(20, 21);
            this.alertImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.alertImagen.TabIndex = 1;
            this.alertImagen.TabStop = false;
            this.alertImagen.Visible = false;
            // 
            // txtRutaImagen
            // 
            this.txtRutaImagen.Location = new System.Drawing.Point(19, 75);
            this.txtRutaImagen.Name = "txtRutaImagen";
            this.txtRutaImagen.Size = new System.Drawing.Size(231, 22);
            this.txtRutaImagen.TabIndex = 1;
            this.txtRutaImagen.Visible = false;
            // 
            // btnOpenDialog
            // 
            this.btnOpenDialog.Location = new System.Drawing.Point(20, 24);
            this.btnOpenDialog.Name = "btnOpenDialog";
            this.btnOpenDialog.Size = new System.Drawing.Size(230, 36);
            this.btnOpenDialog.TabIndex = 0;
            this.btnOpenDialog.Text = "button2";
            this.btnOpenDialog.UseVisualStyleBackColor = true;
            this.btnOpenDialog.Click += new System.EventHandler(this.btnOpenDialog_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.ptbxImagen);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(20);
            this.panel5.Size = new System.Drawing.Size(270, 269);
            this.panel5.TabIndex = 1;
            // 
            // ptbxImagen
            // 
            this.ptbxImagen.Clicked = false;
            this.ptbxImagen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptbxImagen.Hover = false;
            this.ptbxImagen.ImageHover = null;
            this.ptbxImagen.Location = new System.Drawing.Point(20, 20);
            this.ptbxImagen.MargingOut = new System.Windows.Forms.Padding(0);
            this.ptbxImagen.Name = "ptbxImagen";
            this.ptbxImagen.Size = new System.Drawing.Size(230, 229);
            this.ptbxImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbxImagen.TabIndex = 0;
            this.ptbxImagen.TabStop = false;
            // 
            // pnButtons
            // 
            this.pnButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnButtons.Controls.Add(this.btnActualizar);
            this.pnButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnButtons.Location = new System.Drawing.Point(0, 523);
            this.pnButtons.Name = "pnButtons";
            this.pnButtons.Padding = new System.Windows.Forms.Padding(0, 5, 20, 5);
            this.pnButtons.Size = new System.Drawing.Size(1030, 48);
            this.pnButtons.TabIndex = 2;
            // 
            // btnActualizar
            // 
            this.btnActualizar.ButtonBorderStyle = System.Windows.Forms.ButtonBorderStyle.None;
            this.btnActualizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnActualizar.Location = new System.Drawing.Point(900, 5);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(110, 38);
            this.btnActualizar.TabIndex = 1;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // _FichaPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 571);
            this.Controls.Add(this.pnBody);
            this.Controls.Add(this.pnButtons);
            this.Controls.Add(this.pnTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "_FichaPersona";
            this.Text = "_FichaUsuarios";
            this.Load += new System.EventHandler(this._FichaPersona_Load);
            this.pnTop.ResumeLayout(false);
            this.pnBody.ResumeLayout(false);
            this.pnDatasPersona.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alertPermisos)).EndInit();
            this.pnDataPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alertImagen)).EndInit();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbxImagen)).EndInit();
            this.pnButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnTop;
        private System.Windows.Forms.Panel pnBody;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pnDatasPersona;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txtRutaImagen;
        private System.Windows.Forms.Button btnOpenDialog;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureHover ptbxImagen;
        private System.Windows.Forms.Panel pnDataPanel;
        private System.Windows.Forms.ButtonHover btnActualizar;
        private System.Windows.Forms.AlertPictureBox alertImagen;
        private System.Windows.Forms.Panel pnButtons;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private _Componentes.DataBox pnDataTelefono;
        private _Componentes.DataBox pnDataEmail;
        private _Componentes.DataBox pnDataNombre;
        private _Componentes.DataBox pnDataContraseña;
        private _Componentes.DataBox g;
        private _Componentes.DataBox pnDataApellido;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel pnPermisos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbPermisos;
        private System.Windows.Forms.AlertPictureBox alertPermisos;
    }
}