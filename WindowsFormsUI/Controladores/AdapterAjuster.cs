using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entitidades.Simples;
using Entitidades.Concretas;
using System.IO;

namespace WindowsFormsUI.Controladores
{
    public partial class AdapterAjuster : UserControl
    {
        public delegate void sendDatos( int Id,Image imagen,List<string>datos);
        public sendDatos _sendDatos;

        Image notFound = Image.FromFile(Path.GetFullPath(@"_Imagenes\Iconos\imageNotFound.png"));
        public int IdAjuste;
        public List<string> datosAjuste;
        public Image ImageAjuste;
        public AdapterAjuster(Generos d)
        {
          
            InitializeComponent();
            lbName.Text = d.Nombre;
            if (d.Imagen != null)
            {
                ptbxImagen.Image = Image.FromFile(Path.GetFullPath(d.Imagen));
            }
            else
            {
                ptbxImagen.Image = notFound;
            }
            ImageAjuste = ptbxImagen.Image;
            IdAjuste = d.Id;
            datosAjuste = new List<string>();
            datosAjuste.Add(d.Nombre);
            datosAjuste.Add(d.Descripcion);
           

        }

        private void AdapterAjuster_Click(object sender, EventArgs e)
        {
            if (_sendDatos != null)
            {
                _sendDatos(IdAjuste, ImageAjuste, datosAjuste);
            }
          
        }

        public AdapterAjuster(Idiomas d)
        {
            InitializeComponent();
            lbName.Text = d.Nombre;
            if (d.Imagen != null)
            {
                ptbxImagen.Image = Image.FromFile(Path.GetFullPath(d.Imagen));
            }
            else
            {
                ptbxImagen.Image = notFound;
            }
            ImageAjuste = ptbxImagen.Image;
            IdAjuste = d.Id;
            datosAjuste = new List<string>();
            datosAjuste.Add(d.Nombre);
         


        }
        public AdapterAjuster(Plataformas d)
        {
            InitializeComponent();
            lbName.Text = d.Nombre;
            if (d.Imagen != null)
            {
                ptbxImagen.Image = Image.FromFile(Path.GetFullPath(d.Imagen));
            }
            else
            {
                ptbxImagen.Image = notFound;
            }
            ImageAjuste = ptbxImagen.Image;
            IdAjuste = d.Id;
            datosAjuste = new List<string>();
            datosAjuste.Add(d.Nombre);

           

        }
        public AdapterAjuster(Desarrolladoras d)
        {
            InitializeComponent();
            lbName.Text = d.Nombre;
            if (d.Imagen != null)
            {
                ptbxImagen.Image = Image.FromFile(Path.GetFullPath(d.Imagen));
            }
            else
            {
                ptbxImagen.Image = notFound;
            }
            ImageAjuste = ptbxImagen.Image;
            IdAjuste = d.Id;
            datosAjuste = new List<string>();
            datosAjuste.Add(d.Nombre);
            
        }
        public AdapterAjuster(Clasificaciones d)
        {
            InitializeComponent();
            lbName.Text = d.Nombre;
            if (d.Imagen != null)
            {
                ptbxImagen.Image = Image.FromFile(Path.GetFullPath(d.Imagen));
            }
            else
            {
                ptbxImagen.Image = notFound;
            }
            ImageAjuste = ptbxImagen.Image;
            IdAjuste = d.Id;
            datosAjuste = new List<string>();
            datosAjuste.Add(d.Nombre);
          

        }



        private void pnContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnContenedor_Click(object sender, EventArgs e)
        {

        }

        private void AdapterAjuster_Load(object sender, EventArgs e)
        {
            pnContenedor.Click += AdapterAjuster_Click;
            
            this.Click += AdapterAjuster_Click;
            pnContenedor.MouseEnter += PnContenedor_MouseEnter;
            pnContenedor.MouseLeave += PnContenedor_MouseLeave;
            pnContenedor.MouseHover += PnContenedor_MouseEnter;
            pictureBox1.MouseEnter += PnContenedor_MouseEnter;
            lbName.MouseEnter += PnContenedor_MouseEnter;
        }

        private void PnContenedor_MouseLeave(object sender, EventArgs e)
        {
            this.Padding = new Padding(10, 10, 10, 10);
        }

        private void PnContenedor_MouseEnter(object sender, EventArgs e)
        {
            this.Padding = new Padding(5, 5, 5, 5);
        }
    }
}
