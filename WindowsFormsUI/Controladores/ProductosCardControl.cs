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

namespace WindowsFormsUI.Controladores
{
    public partial class ProductosCardControl : UserControl
    {
        Productos productos;
        Image notFound = Image.FromFile(Path.GetFullPath(@"_Imagenes\Iconos\imageNotFound.png"));
        public delegate void CargarPanel(Productos productos);
        public event CargarPanel showPanel;
        public ProductosCardControl(Productos _productos)
        {
            productos = _productos;
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
        }

        private void ptbxDelete_Click(object sender, EventArgs e)
        {

        }

        private void ptbxImage_Click(object sender, EventArgs e)
        {
            if (showPanel != null)
            {
                showPanel(productos);

            }
        }

        private void ptbxImage_MouseEnter(object sender, EventArgs e)
        {
            pnContenedor.Padding = new Padding(10, 10, 10, 10);
        }

        private void ptbxImage_MouseLeave(object sender, EventArgs e)
        {
            pnContenedor.Padding = new Padding(20, 20, 20, 20);
        }

        private void lbDesarrolladora_Click(object sender, EventArgs e)
        {

        }
    }
}
