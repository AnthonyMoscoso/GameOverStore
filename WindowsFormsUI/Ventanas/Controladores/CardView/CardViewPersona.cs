using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entitidades.Users;
using Entitidades.Concretas;
using System.IO;
using WindowsFormsUI.Eventos;
using WindowsFormsUI.Ventanas._FICHAS;
using Negocios.Abstractas.Users;
using Negocios.Abstractas;

namespace WindowsFormsUI.Controladores
{
    public partial class CardViewPersona : UserControl
    {

        public string RUTA_IMAGENES_PERSONAS = @"_Imagenes\_Personas\";
        private IServicioUsuarios _servicioUsuarios = CompositionRoot.Resolve<IServicioUsuarios>();
        private IServicioSocios _servicioSocios = CompositionRoot.Resolve<IServicioSocios>();



        private Socios socio;
        private Usuarios user;

        public CardViewPersona(Socios socie)
        {
      
            InitializeComponent();
            socio = socie;
            LoadDataSocio(socie);
         
           
        }
        public CardViewPersona(Usuarios usuarios)
        {
            InitializeComponent();
            user = usuarios;
            LoadDataUsuario(usuarios);
        }
        private void LoadDataUsuario(Usuarios persona)
        {
            LoadGeneralData(persona);
            btnDelete.Click += BtnDeleteUsuario_Click;
            btnEdit.Click += BtnEditUsuario_Click;
        }

        public void LoadGeneralData(Personas persona)
        {
            lbNomre.Text = persona.Nombre + " " + persona.Apellido;
            lbTelefono.Text = persona.Telefono;
            lbEmail.Text = persona.Email;

            if (File.Exists(persona.Imagen))
            {
                ImagenCardView.Image = Image.FromFile(persona.Imagen);
            }
            else
            {
                ImagenCardView.Image = Image.FromFile(ImagenControls.ImageNotFound);
            }
        }
       
        private void LoadDataSocio(Socios persona)
        {
            LoadGeneralData(persona);
            btnDelete.Click += BtnDeleteSocio_Click;
            btnEdit.Click += BtnEditSocio_Click;
        }

      


      

        private void BtnDeleteUsuario_Click(object sender, EventArgs e)
        {
            string ruta = user.Imagen;
            ImagenCardView.Image.Dispose();
            _servicioUsuarios.Delete(user);
            ImagenControls.DeleteImagen(ruta);
            Dispose();
        }

        private void BtnEditUsuario_Click(object sender, EventArgs e)
        {
            OpenFichaUsuario();
        }
        private void BtnEditSocio_Click(object sender, EventArgs e)
        {
            OpenFichaSocio();
        }

        private void OpenFichaSocio()
        {
            _FichaPersona ficha = new _FichaPersona(socio);
            DialogResult dialogResult = ficha.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                bool HasBeenActualizado = ficha.HasBeenUpdate();
                if (HasBeenActualizado)
                {
                       
                    LoadDataSocio(socio);
                }
            }
            
        }
        private void OpenFichaUsuario()
        {
            ImagenCardView.Image.Dispose();
            _FichaPersona ficha = new _FichaPersona(user);
            DialogResult dialogResult = ficha.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                bool HasBeenActualizado = ficha.HasBeenUpdate();
                if (HasBeenActualizado)
                {
                    user = ficha.GetUsuario();
                    LoadDataUsuario(user);
                 
                }



            }
            
        }
        private void BtnDeleteSocio_Click(object sender, EventArgs e)
        {
           
        }

        private void CardViewPersona_Load(object sender, EventArgs e)
        {
        }

       
    }
}
