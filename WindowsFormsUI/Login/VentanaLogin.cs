using Entitidades.Users;
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
    public partial class VentanaLogin : Form
    {
        IServicioPersona _servicioPersona;
        public VentanaLogin(IServicioPersona servicioPersona)
        {
            _servicioPersona = servicioPersona;
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            Personas p = _servicioPersona.Get("Email='"+email+"'");
            if (p != null)
            {
                string pass = txtPassword.Text;
                if (pass == p.Contraseña)
                {
                    alertPassword.SetErrorMessage("Contraseña Incorrecta");
                }
            }
            else
            {
                alertEmail.SetErrorMessage("No existe un usuario con ese correo");
            }
        }
    }
}
