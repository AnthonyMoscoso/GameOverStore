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
using Entitidades.Users;
using WindowsFormsUI.Eventos;
using System.IO;
using WindowsFormsUI.Ventanas._FICHAS;

namespace WindowsFormsUI.Controladores
{
    public partial class AdapterViewPersonas : UserControl
    {
        public delegate void SendUsuario(Usuarios us);
        public SendUsuario SendToDelete;
        public SendUsuario SendToOpen;
        private Usuarios user;
        private Socios socie;

        public AdapterViewPersonas(Socios p)
        {
            InitializeComponent();
            socie = p;
           

        }
        private void LoadGeneralData(Personas p)
        {
            lbName.Text = p.Nombre + " " + p.Apellido;
            lbTelefono.Text = p.Telefono;
            lbEmail.Text = p.Email;

            if (File.Exists(p.Imagen))
            {
                ImagenAdapterView.Image = Image.FromFile(p.Imagen);
            }
            else
            {
                ImagenAdapterView.Image = Image.FromFile(ImagenControls.ImageNotFound);
            }
        }
        public AdapterViewPersonas(Usuarios p)
        {
            InitializeComponent();
            user = p;
            LoadGeneralData(p);
            lbCalendar.Text = p.FechaContratacion.ToString();
            btnEdit.Click += BtnEdit_Click;


        }
        private void OpenFichaUsuario()
        {
            ImagenAdapterView.Image.Dispose();
            _FichaPersona ficha = new _FichaPersona(user);
            DialogResult dialogResult = ficha.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                bool HasBeenActualizado = ficha.HasBeenUpdate();
                if (HasBeenActualizado)
                {
                    user = ficha.GetUsuario();
                    LoadGeneralData(user);

                }



            }

        }
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            OpenFichaUsuario();
        }
    }
}
