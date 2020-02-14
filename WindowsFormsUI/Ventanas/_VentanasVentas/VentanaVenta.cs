using Entitidades.Concretas;
using Entitidades.Lineas;
using Negocios.Abstractas.Compuestas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsUI.Controladores;
using WindowsFormsUI.Ventanas.Controladores.AdapterView;

namespace WindowsFormsUI.Ventanas
{
    public partial class VentanaVenta : Form
    {
        IServicioProductos _servicioProductos;
        List<Productos> ListProductos;
        List<LineaVentas> CarritoCompra=new List<LineaVentas>();
        List<AdapterViewLineaVenta> viewLineaVentas = new List<AdapterViewLineaVenta>();
        public VentanaVenta(IServicioProductos servicioProductos)
        {
            InitializeComponent();
            _servicioProductos = servicioProductos;
            this.Load += VentanaVenta_Load;
       
        }

        private void VentanaVenta_Load(object sender, EventArgs e)
        {
            ListProductos = _servicioProductos.GetAll("Cantidad_Inventario >" + 0);
            foreach(Productos p in ListProductos)
            {
                CardViewProductos card = new CardViewProductos(p);
                pnProductos.Controls.Add(card);
                card.showPanel += Card_showPanel;
            }

        }

        private void Card_showPanel(Productos productos)
        {
            LineaVentas linea = new LineaVentas();
            linea.Productos = productos;
            if (CarritoCompra.Contains(linea))
            {
                linea = linea.GetLineaForProduto(CarritoCompra);
                if (linea.Productos.Cantidad_Inventario > 0 )
                {
                    linea.Productos.Cantidad_Inventario--;
                    linea.Cantidad++;
                    foreach(AdapterViewLineaVenta v in viewLineaVentas)
                    {
                        if (v.Name == linea.Productos.Nombre)
                        {
                            v.Cantidad = linea.Cantidad;
                            break;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No puede vender mas productos de los que tienes en stock");
                }
               
            }
            else
            {
                linea.Cantidad = 1;
                linea.Productos.Cantidad_Inventario--;
                linea.Precio = productos.Precio_Venta;
                CarritoCompra.Add(linea);
                AdapterViewLineaVenta adapter = new AdapterViewLineaVenta(linea);
                adapter.Name = linea.Productos.Nombre;
                viewLineaVentas.Add(adapter);
                pnCarritoCompra.Controls.Add(adapter);
            }
            
        }

        private void Card_Click(object sender, EventArgs e)
        {
           
           
  
        }
    }
}
