using Entitidades.Users;
using Negocios.Abstractas.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Configuration;
using System.Net.Mail;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsUI.Eventos;
using WindowsFormsUI.Ventanas;

namespace WindowsFormsUI.Login
{
    public partial class VentanaLogin : Form
    {
    
        IServicioPersona _servicioPersona;
        public VentanaLogin(IServicioPersona servicioPersona)
        {
            
            InitializeComponent();
            _servicioPersona = servicioPersona;
            btnRegister.Click += BtnRegister_Click;
            pnTop.MouseDown+= Movement.Pn_MouseDown;
            pnDown.MouseDown += Movement.Pn_MouseDown;
            btnClose.Click += BtnClose_Click;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public static bool IsLogin { get; set; }
        

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            Personas p = _servicioPersona.Get("Email='"+email+"'");
            if (p != null)
            {
                string pass = txtPassword.Text;
                if (pass.Equals(p.Contraseña))
                {
                    this.Visible = false;
                    VentanaPrincipal ventana = new VentanaPrincipal();


                    
                    ventana.Show();
                    ventana.Disposed += Ventana_Disposed;
                   


                }
                else
                {
                    alertPassword.SetErrorMessage("Contraseña Incorrecta");
                }
            }
            else
            {
                alertEmail.SetErrorMessage("No existe un usuario con ese correo");
            }
        }

        private void Ventana_Disposed(object sender, EventArgs e)
        {
            this.Dispose(); 
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            VentanaRegisterSocio ventanaRegisterSocio = CompositionRoot.Resolve<VentanaRegisterSocio>();
            ventanaRegisterSocio.Show();
            ventanaRegisterSocio.gotoBack += Come_toback;
        }
        private void Come_toback()
        {
            this.Visible = true;
        }

        private void btnForgetPassword_Click(object sender, EventArgs e)
        {
            
        }

        private void ptxSeePassword_Click(object sender, EventArgs e)
        {

        }

     
    }
}
