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
    public partial class AdapterViewProductos : UserControl
    {
        public delegate void CargarPanel(Productos productos);
        public event CargarPanel showPanel;
        Productos _productos;
        Image notFound = Image.FromFile(Path.GetFullPath(@"_Imagenes\Iconos\imageNotFound.png"));
        public AdapterViewProductos(Productos producto)
        {
            
            InitializeComponent();
            _productos = producto;
            ptbxImagenProducto.SizeMode = PictureBoxSizeMode.Zoom;
           if (File.Exists(Path.GetFullPath(@_productos.Imagen_Vertical)))
            {
                ptbxImagenProducto.Image = Image.FromFile(Path.GetFullPath(@_productos.Imagen_Vertical));
            }
            else
            {
                ptbxImagenProducto.SizeMode = PictureBoxSizeMode.StretchImage;
                ptbxImagenProducto.Image = notFound;
            }
        }

        private void ProductoAdapterControl_Load(object sender, EventArgs e)
        {

        }

        private void pnDatosProductos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnDatosProductos_Click(object sender, EventArgs e)
        {
            if (showPanel != null)
            {
                showPanel(_productos);

            }
        }
    }
}
