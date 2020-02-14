using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entitidades.Lineas;

namespace WindowsFormsUI.Ventanas.Controladores.AdapterView
{
    public partial class AdapterViewLineaVenta : UserControl
    {
        public delegate void ModificarCantidad();
        public ModificarCantidad _ReducirCantidad;
        public ModificarCantidad _AumentarCantidad;
        public delegate void EliminarLineaVenta(LineaVentas linea);
        public EliminarLineaVenta _EliminarLinea;
        
        public int Cantidad
        {
            set
            {
                lbCantidad.Text = value.ToString();
            }
        }
        public AdapterViewLineaVenta(LineaVentas lineaVentas)
        {
            InitializeComponent();
            Name= lineaVentas.Productos.Nombre;
            lbNombre.Text = lineaVentas.Productos.Nombre;
            lbPrecio.Text = lineaVentas.Productos.Precio_Venta.ToString() + "€";
            ImagenProducto.Image = Image.FromFile(lineaVentas.Productos.Imagen_Vertical);
            lbCantidad.Text = lineaVentas.Cantidad.ToString();
        }
    }
}
