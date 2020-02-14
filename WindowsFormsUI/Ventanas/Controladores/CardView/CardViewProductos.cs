using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entitidades.Concretas;
using System.IO;
using Negocios.Abstractas.Compuestas;
using Negocios.Abstractas.Simples;

namespace WindowsFormsUI.Controladores
{
    public partial class CardViewProductos : UserControl
    {
        Productos productos;
        Image notFound = Image.FromFile(Path.GetFullPath(@"_Imagenes\Iconos\imageNotFound.png"));
        public delegate void CargarPanel(Productos productos);
        public event CargarPanel showPanel;
        private IServicioProductos _servicioProductos = CompositionRoot.Resolve<IServicioProductos>();
        private IServicioDesarrolladoras _servicioDesarrolladoras = CompositionRoot.Resolve<IServicioDesarrolladoras>();
        public CardViewProductos(Productos _productos)
        {
            productos = _productos;
            productos.Desarrolladora = _servicioDesarrolladoras.GetById(productos.Desarrolladora_id);
            InitializeComponent();
            panel1.Parent = ptbxImage;
            CargarProducto();
        }
        private void CargarProducto()
        {
            lbNombre.Text = productos.Nombre;
            lbPrecioVenta.Text = productos.Precio_Venta.ToString();
            lbDesarrolladora.Text = productos.Desarrolladora.Nombre;
            ptbxImage.SizeMode = PictureBoxSizeMode.Zoom;
            if (File.Exists(Path.GetFullPath(@productos.Imagen_Vertical)))
            {
                ptbxImage.Image = Image.FromFile(Path.GetFullPath(@productos.Imagen_Vertical));
            }
            else
            {
                ptbxImage.SizeMode = PictureBoxSizeMode.StretchImage;
                ptbxImage.Image = notFound;
            }
            ptbxImage.MouseClick += PtbxImage_MouseClick;
            ptbxImage.MouseEnter += PtbxImage_MouseEnter;
            ptbxImage.MouseLeave += PtbxImage_MouseLeave;
        }

        private void PtbxImage_MouseLeave(object sender, EventArgs e)
        {
            pnContenedor.Padding = new Padding(20, 20, 20, 20);
        }

        private void PtbxImage_MouseClick(object sender, MouseEventArgs e)
        {
            showPanel?.Invoke(productos);
           
        }


      
        private void PtbxImage_MouseEnter(object sender, EventArgs e)
        {
            pnContenedor.Padding = new Padding(10, 10, 10, 10);
        }

    

        private void lbDesarrolladora_Click(object sender, EventArgs e)
        {

        }
    }
}
