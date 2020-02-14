namespace WindowsFormsUI.Controladores
{
    partial class AdapterViewProductos
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
            this.ptbxImagenProducto = new System.Windows.Forms.PictureBox();
            this.pnImagenProductos = new System.Windows.Forms.Panel();
            this.pnDatosProductos = new System.Windows.Forms.Panel();
            this.lbPrecioCompra = new System.Windows.Forms.Label();
            this.lbPrecioVenta = new System.Windows.Forms.Label();
            this.lbFechaLanzamiento = new System.Windows.Forms.Label();
            this.lbClasificacion = new System.Windows.Forms.Label();
            this.lbDesarrolladora = new System.Windows.Forms.Label();
            this.lbTitulo_Compra = new System.Windows.Forms.Label();
            this.lbTitulo_Clasificacion = new System.Windows.Forms.Label();
            this.lbGeneros = new System.Windows.Forms.Label();
            this.lbTitulo_Desarrolladora = new System.Windows.Forms.Label();
            this.lbTitulo_Genero = new System.Windows.Forms.Label();
            this.lbTitulo_FechaLanzamiento = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbTitutlo_Nombre = new System.Windows.Forms.Label();
            this.lbTitulo_Venta = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptbxImagenProducto)).BeginInit();
            this.pnImagenProductos.SuspendLayout();
            this.pnDatosProductos.SuspendLayout();
            this.SuspendLayout();
            // 
            // ptbxImagenProducto
            // 
            this.ptbxImagenProducto.Location = new System.Drawing.Point(19, 12);
            this.ptbxImagenProducto.Name = "ptbxImagenProducto";
            this.ptbxImagenProducto.Size = new System.Drawing.Size(139, 77);
            this.ptbxImagenProducto.TabIndex = 0;
            this.ptbxImagenProducto.TabStop = false;
            // 
            // pnImagenProductos
            // 
            this.pnImagenProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnImagenProductos.Controls.Add(this.ptbxImagenProducto);
            this.pnImagenProductos.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnImagenProductos.Location = new System.Drawing.Point(0, 0);
            this.pnImagenProductos.Name = "pnImagenProductos";
            this.pnImagenProductos.Size = new System.Drawing.Size(178, 103);
            this.pnImagenProductos.TabIndex = 0;
            // 
            // pnDatosProductos
            // 
            this.pnDatosProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnDatosProductos.Controls.Add(this.lbPrecioCompra);
            this.pnDatosProductos.Controls.Add(this.lbPrecioVenta);
            this.pnDatosProductos.Controls.Add(this.lbFechaLanzamiento);
            this.pnDatosProductos.Controls.Add(this.lbClasificacion);
            this.pnDatosProductos.Controls.Add(this.lbDesarrolladora);
            this.pnDatosProductos.Controls.Add(this.lbTitulo_Compra);
            this.pnDatosProductos.Controls.Add(this.lbTitulo_Clasificacion);
            this.pnDatosProductos.Controls.Add(this.lbGeneros);
            this.pnDatosProductos.Controls.Add(this.lbTitulo_Desarrolladora);
            this.pnDatosProductos.Controls.Add(this.lbTitulo_Genero);
            this.pnDatosProductos.Controls.Add(this.lbTitulo_FechaLanzamiento);
            this.pnDatosProductos.Controls.Add(this.lbNombre);
            this.pnDatosProductos.Controls.Add(this.lbTitutlo_Nombre);
            this.pnDatosProductos.Controls.Add(this.lbTitulo_Venta);
            this.pnDatosProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnDatosProductos.Location = new System.Drawing.Point(178, 0);
            this.pnDatosProductos.Name = "pnDatosProductos";
            this.pnDatosProductos.Size = new System.Drawing.Size(932, 103);
            this.pnDatosProductos.TabIndex = 1;
            this.pnDatosProductos.Click += new System.EventHandler(this.pnDatosProductos_Click);
            this.pnDatosProductos.Paint += new System.Windows.Forms.PaintEventHandler(this.pnDatosProductos_Paint);
            // 
            // lbPrecioCompra
            // 
            this.lbPrecioCompra.AutoSize = true;
            this.lbPrecioCompra.Location = new System.Drawing.Point(743, 72);
            this.lbPrecioCompra.Name = "lbPrecioCompra";
            this.lbPrecioCompra.Size = new System.Drawing.Size(52, 17);
            this.lbPrecioCompra.TabIndex = 13;
            this.lbPrecioCompra.Text = "23.45€";
            // 
            // lbPrecioVenta
            // 
            this.lbPrecioVenta.AutoSize = true;
            this.lbPrecioVenta.Location = new System.Drawing.Point(743, 46);
            this.lbPrecioVenta.Name = "lbPrecioVenta";
            this.lbPrecioVenta.Size = new System.Drawing.Size(52, 17);
            this.lbPrecioVenta.TabIndex = 12;
            this.lbPrecioVenta.Text = "45.56€";
            // 
            // lbFechaLanzamiento
            // 
            this.lbFechaLanzamiento.AutoSize = true;
            this.lbFechaLanzamiento.Location = new System.Drawing.Point(476, 72);
            this.lbFechaLanzamiento.Name = "lbFechaLanzamiento";
            this.lbFechaLanzamiento.Size = new System.Drawing.Size(82, 17);
            this.lbFechaLanzamiento.TabIndex = 11;
            this.lbFechaLanzamiento.Text = "12-12-2020";
            // 
            // lbClasificacion
            // 
            this.lbClasificacion.AutoSize = true;
            this.lbClasificacion.Location = new System.Drawing.Point(430, 46);
            this.lbClasificacion.Name = "lbClasificacion";
            this.lbClasificacion.Size = new System.Drawing.Size(56, 17);
            this.lbClasificacion.TabIndex = 10;
            this.lbClasificacion.Text = "Pegi 12";
            // 
            // lbDesarrolladora
            // 
            this.lbDesarrolladora.Location = new System.Drawing.Point(124, 72);
            this.lbDesarrolladora.Name = "lbDesarrolladora";
            this.lbDesarrolladora.Size = new System.Drawing.Size(208, 17);
            this.lbDesarrolladora.TabIndex = 9;
            this.lbDesarrolladora.Text = "From Software";
            // 
            // lbTitulo_Compra
            // 
            this.lbTitulo_Compra.AutoSize = true;
            this.lbTitulo_Compra.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbTitulo_Compra.Location = new System.Drawing.Point(624, 72);
            this.lbTitulo_Compra.Name = "lbTitulo_Compra";
            this.lbTitulo_Compra.Size = new System.Drawing.Size(101, 17);
            this.lbTitulo_Compra.TabIndex = 8;
            this.lbTitulo_Compra.Text = "Precio Compra";
            // 
            // lbTitulo_Clasificacion
            // 
            this.lbTitulo_Clasificacion.AutoSize = true;
            this.lbTitulo_Clasificacion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbTitulo_Clasificacion.Location = new System.Drawing.Point(338, 46);
            this.lbTitulo_Clasificacion.Name = "lbTitulo_Clasificacion";
            this.lbTitulo_Clasificacion.Size = new System.Drawing.Size(86, 17);
            this.lbTitulo_Clasificacion.TabIndex = 7;
            this.lbTitulo_Clasificacion.Text = "Clasificacion";
            // 
            // lbGeneros
            // 
            this.lbGeneros.Location = new System.Drawing.Point(89, 44);
            this.lbGeneros.Name = "lbGeneros";
            this.lbGeneros.Size = new System.Drawing.Size(231, 17);
            this.lbGeneros.TabIndex = 6;
            this.lbGeneros.Text = "Rol , Multijugador,Terror,Accion";
            // 
            // lbTitulo_Desarrolladora
            // 
            this.lbTitulo_Desarrolladora.AutoSize = true;
            this.lbTitulo_Desarrolladora.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbTitulo_Desarrolladora.Location = new System.Drawing.Point(20, 72);
            this.lbTitulo_Desarrolladora.Name = "lbTitulo_Desarrolladora";
            this.lbTitulo_Desarrolladora.Size = new System.Drawing.Size(102, 17);
            this.lbTitulo_Desarrolladora.TabIndex = 5;
            this.lbTitulo_Desarrolladora.Text = "Desarrolladora";
            // 
            // lbTitulo_Genero
            // 
            this.lbTitulo_Genero.AutoSize = true;
            this.lbTitulo_Genero.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbTitulo_Genero.Location = new System.Drawing.Point(19, 44);
            this.lbTitulo_Genero.Name = "lbTitulo_Genero";
            this.lbTitulo_Genero.Size = new System.Drawing.Size(56, 17);
            this.lbTitulo_Genero.TabIndex = 4;
            this.lbTitulo_Genero.Text = "Genero";
            // 
            // lbTitulo_FechaLanzamiento
            // 
            this.lbTitulo_FechaLanzamiento.AutoSize = true;
            this.lbTitulo_FechaLanzamiento.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbTitulo_FechaLanzamiento.Location = new System.Drawing.Point(338, 72);
            this.lbTitulo_FechaLanzamiento.Name = "lbTitulo_FechaLanzamiento";
            this.lbTitulo_FechaLanzamiento.Size = new System.Drawing.Size(132, 17);
            this.lbTitulo_FechaLanzamiento.TabIndex = 3;
            this.lbTitulo_FechaLanzamiento.Text = "Fecha Lanzamiento";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbNombre.Location = new System.Drawing.Point(108, 15);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(86, 19);
            this.lbNombre.TabIndex = 2;
            this.lbNombre.Text = "Dark Soul";
            // 
            // lbTitutlo_Nombre
            // 
            this.lbTitutlo_Nombre.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitutlo_Nombre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbTitutlo_Nombre.Location = new System.Drawing.Point(19, 12);
            this.lbTitutlo_Nombre.Name = "lbTitutlo_Nombre";
            this.lbTitutlo_Nombre.Size = new System.Drawing.Size(112, 32);
            this.lbTitutlo_Nombre.TabIndex = 1;
            this.lbTitutlo_Nombre.Text = "Nombre :";
            // 
            // lbTitulo_Venta
            // 
            this.lbTitulo_Venta.AutoSize = true;
            this.lbTitulo_Venta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbTitulo_Venta.Location = new System.Drawing.Point(624, 44);
            this.lbTitulo_Venta.Name = "lbTitulo_Venta";
            this.lbTitulo_Venta.Size = new System.Drawing.Size(89, 17);
            this.lbTitulo_Venta.TabIndex = 0;
            this.lbTitulo_Venta.Text = "Precio Venta";
            // 
            // ProductoAdapterControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnDatosProductos);
            this.Controls.Add(this.pnImagenProductos);
            this.Name = "ProductoAdapterControl";
            this.Size = new System.Drawing.Size(1110, 103);
            this.Load += new System.EventHandler(this.ProductoAdapterControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbxImagenProducto)).EndInit();
            this.pnImagenProductos.ResumeLayout(false);
            this.pnDatosProductos.ResumeLayout(false);
            this.pnDatosProductos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbxImagenProducto;
        private System.Windows.Forms.Panel pnImagenProductos;
        private System.Windows.Forms.Panel pnDatosProductos;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbTitutlo_Nombre;
        private System.Windows.Forms.Label lbTitulo_Venta;
        private System.Windows.Forms.Label lbPrecioCompra;
        private System.Windows.Forms.Label lbPrecioVenta;
        private System.Windows.Forms.Label lbFechaLanzamiento;
        private System.Windows.Forms.Label lbClasificacion;
        private System.Windows.Forms.Label lbDesarrolladora;
        private System.Windows.Forms.Label lbTitulo_Compra;
        private System.Windows.Forms.Label lbTitulo_Clasificacion;
        private System.Windows.Forms.Label lbGeneros;
        private System.Windows.Forms.Label lbTitulo_Desarrolladora;
        private System.Windows.Forms.Label lbTitulo_Genero;
        private System.Windows.Forms.Label lbTitulo_FechaLanzamiento;
    }
}
