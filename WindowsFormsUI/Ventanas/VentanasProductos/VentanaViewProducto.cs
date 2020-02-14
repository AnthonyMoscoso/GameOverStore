using Entitidades.Concretas;
using Entitidades.Simples;
using Negocios.Abstractas.Compuestas;
using Negocios.Abstractas.Simples;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsUI.Ventanas
{
    public partial class VentanaViewProducto : Form
    {

        public delegate void GoBackInventario();
        public GoBackInventario _GoBackInventario;
        Productos _producto;
        IServicioIdiomas _servicioIdiomas;
        IServicioGeneros _servicioGeneros;
        IServicioPlataformas _ServicioPlataformas;
        IServicioClasificaciones _servicioClasificaciones;
        private WebBrowser _WebBrowser;

        Image notFound = Image.FromFile(Path.GetFullPath(@"_Imagenes\Iconos\imageNotFound.png"));
        public VentanaViewProducto(IServicioProductos servicioProductos,
        IServicioIdiomas servicioIdiomas,
        IServicioGeneros servicioGeneros,
        IServicioPlataformas ServicioPlataformas,
        IServicioClasificaciones servicioClasificaciones)
        {
            _servicioClasificaciones = servicioClasificaciones;
            _ServicioPlataformas = ServicioPlataformas;
            _servicioIdiomas = servicioIdiomas;
            _servicioGeneros = servicioGeneros;
            
            InitializeComponent();



            this.Disposed += VentanaViewProducto_Disposed;
            
        }

        private void VentanaViewProducto_Disposed(object sender, EventArgs e)
        {
            _WebBrowser.Dispose();
        }

        private void VentanaViewProducto_Load(object sender, EventArgs e)
        {
            _producto = VentanaPrincipal.Producto;

            addWebView();

           
           
            _producto.Clasificacion = _servicioClasificaciones.GetById(_producto.Clasificacion_id);
            _producto.Generos = _servicioGeneros.GetGenerosByIdProducto(_producto.Id);
            _producto.Idiomas = _servicioIdiomas.GetIdiomasByIdProducto(_producto.Id);
            _producto.Plataformas = _ServicioPlataformas.GetPlataformasByIdProducto(_producto.Id);
          
            lbDescripcion.Text = _producto.Descripcion;
            lbNombre.Text = _producto.Nombre;
            lbPrecio.Text = _producto.Precio_Venta.ToString();
            lbGeneros.Text = getGeneros();
            lbClasificacion.Text = _producto.Clasificacion.Nombre;
            lbIdiomas.Text = getIdiomas();
            showPlataformas();
          

        }
        private void addWebView()
        {
            string html = "<html><head>";
            html += "<meta content='IE=Edge' http-equiv='X-UA-Compatible'/>";
            html += "<iframe id='video' src= 'https://www.youtube.com/embed/{0}' width=100%; height=800%;  frameborder='0' fs=1' allowfullscreen webkitallowfullscreen mozallowfullscreen mozResquestFillScream></iframe>";
            html += "</body></html>";
            _WebBrowser = new WebBrowser();
            _WebBrowser.Dock = DockStyle.Fill;
            _WebBrowser.DocumentText = string.Format(html, _producto.Url.ToString().Split('=')[1]);
            pnContainerImages.Controls.Add(_WebBrowser);
        }
        private void showPlataformas()
        {
            _producto.Plataformas = _ServicioPlataformas.GetPlataformasByIdProducto(_producto.Id);
            foreach (Plataformas p in _producto.Plataformas)
            {
                PictureBox picture = new PictureBox();
                picture.SizeMode = PictureBoxSizeMode.StretchImage;
                picture.Width = 25;
                picture.Height = 25;
                try
                {
                    if (File.Exists(Path.GetFullPath(@p.Imagen)))
                    {
                        picture.Image = Image.FromFile(Path.GetFullPath(@p.Imagen));
                    }
                    else
                    {

                        picture.Image = notFound;
                       
                    }
                   
                }
                catch (Exception)
                {
                    picture.Image = notFound;
                    
                }
                pnContainerPlataformas.Controls.Add(picture);

            }
        }
        private string getIdiomas()
        {
            string idiomas = "";
            foreach (Idiomas g in _producto.Idiomas)
            {
                idiomas += g.Nombre+" ";
            }
            return idiomas;
        }
        private string getGeneros()
        {
            string generos = "";
            foreach (Generos g in _producto.Generos)
            {
                generos += g.Nombre+" ";
            }
            return generos;
        }

        private void panel15_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            pnContenido.Scroll += PnContenido_Scroll; ;
            PictureBox ptbxImageHz = new PictureBox();
            ptbxImageHz.Dock = DockStyle.Fill;
            ptbxImageHz.SizeMode = PictureBoxSizeMode.StretchImage;
          
            try
            {
                if (File.Exists(Path.GetFullPath(_producto.Imagen_Horizontal)))
                {
                    ptbxImageHz.Image = Image.FromFile(Path.GetFullPath(_producto.Imagen_Horizontal));

                }
                else
                {
                    ptbxImageHz.Image = notFound;

                }
            }
            catch (Exception)
            {
                ptbxImageHz.Image = notFound;
            }
            btnBefore.Visible = true;
            btnNext.Visible = false;
            _WebBrowser.Refresh();
            pnContainerImages.Controls.Clear();
            pnContainerImages.Controls.Add(ptbxImageHz);
            
        }

        private void PnContenido_Scroll(object sender, ScrollEventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void btnBefore_Click(object sender, EventArgs e)
        {
            btnNext.Visible = true;
            btnBefore.Visible = false;
            pnContainerImages.Controls.Clear();
            addWebView();
           
           
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            _GoBackInventario?.Invoke();
        }
    }
}
