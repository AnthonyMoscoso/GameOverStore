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
using static WindowsFormsUI.Controladores.pnCard;
using WindowsFormsUI.Ventanas;
using WindowsFormsUI.Eventos;

namespace WindowsFormsUI.Controladores
{
    public partial class AdapterAjuster : UserControl
    {
        public delegate void sendDatos(int Id, Image imagen, List<string> datos);
        public sendDatos _sendDatos;
        public delegate void sendToDelete(Tipo_dato tipo_Dato, int id);
        public sendToDelete _sendToDelete;

        Image notFound = Image.FromFile(Path.GetFullPath(@"_Imagenes\Iconos\imageNotFound.png"));
        public int IdAjuste;
        public List<string> datosAjuste;
        public Image ImageAjuste;
        private bool IsClicked;
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

      
        public AdapterAjuster(Idiomas d)
        {
            InitializeComponent();
            lbName.Text = d.Nombre;
            if (d.Imagen != null && File.Exists(d.Imagen))
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
            if (d.Imagen != null && File.Exists(d.Imagen))
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
            if (d.Imagen != null && File.Exists(d.Imagen))
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
            if (d.Imagen != null && File.Exists(d.Imagen))
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





        private void AdapterAjuster_Load(object sender, EventArgs e)
        {
            lbName.Click += AdapterAjuster_Click;
            lbName.MouseEnter += PnContenedor_MouseEnter;
            lbName.MouseLeave += PnContenedor_MouseLeave;
           
           
            IsClicked = false;
        }

        private void LbName_MouseCaptureChanged(object sender, EventArgs e)
        {
            MessageBox.Show("cambio");
        }

        private void AdapterAjuster_Click(object sender, EventArgs e)
        {
          //  pnContenedor.BackColor = ListaColores.BLUE;
            _sendDatos?.Invoke(IdAjuste, ImageAjuste, datosAjuste);
            if (!IsClicked)
            {
                IsClicked = true;
            }
            else
            {
                IsClicked = false;
            }

        }


        private void PnContenedor_MouseLeave(object sender, EventArgs e)
        {
            this.Padding = new Padding(10, 10, 10, 10);
            if (!IsClicked)
            {
                pnContenedor.BackColor = ListaColores.WHITE;
            }
           
        }

        private void PnContenedor_MouseEnter(object sender, EventArgs e)
        {
            this.Padding = new Padding(5, 5, 5, 5);

            
        }

        private void ptbxCancel_Click(object sender, EventArgs e)
        {
            _sendToDelete?.Invoke(VentanaPrincipal.tipo, IdAjuste);
            
        }

    }
}
