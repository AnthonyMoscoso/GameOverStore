using Entitidades.Concretas;
using Entitidades.Users;
using Negocios.Abstractas;
using Negocios.Abstractas.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsUI.Login
{
    public partial class VentanaRegisterSocio : Form
    {
        IServicioPersona _servicioPersona;
        IServicioSocios _servicioSocios;
        public delegate void gotoBackLogin();
        public gotoBackLogin gotoBack;
        public VentanaRegisterSocio(IServicioPersona servicioPersona,IServicioSocios servicioSocios)
        {
            _servicioPersona = servicioPersona;
            _servicioSocios = servicioSocios;
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Personas p = new Personas();
          /*  p.Nombre = txtNombre.Text;
            p.Apellido = txtApellido.Text;
            p.Email = txtEmail.Text;
            p.Contraseña = txtContraseña.Text;
            p.Telefono = txtTelefono.Text;
            p.tipo = Personas.Tipo.Socio;
            p.Imagen = null;
            _servicioPersona.Add(p);


            Socios s= new Socios();
            Personas a = _servicioPersona.Get("Nombre='" + p.Nombre + "'");
            s.Id = a.Id;
            s.Codigo = txtContraseña.Text;
            s.NickName = txtNombre.Text;
            s.Dni = txtNombre.Text;
            s.Descuento = 0;*/
            
          //  _servicioSocios.Add(s);

            if (gotoBack != null)
            {
                gotoBack();
            }
            this.Dispose();
        }

        private void alertPictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
