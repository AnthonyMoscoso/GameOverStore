using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocios.Abstractas.Users;
using Entitidades.Users;

namespace WindowsFormsUI.Login
{
    public partial class VentanaRecuperarContreseña : Form
    {
        IServicioPersona servicioPersona = CompositionRoot.Resolve<IServicioPersona>();

        private string codigo;
        public VentanaRecuperarContreseña()
        {
            InitializeComponent();
            buttonHover2.Click += BtnComprobar_Click;
        }

        private void BtnComprobar_Click(object sender, EventArgs e)
        {

            string email = DataEmail.Texto;
            if(email.Trim().Length>0 && !email.TrimEnd().Equals(DataEmail.TextoHint))
            {
                Personas p = servicioPersona.Get("email='"+email+"'");
                if (p != null)
                {
                    Guid g = Guid.NewGuid();
                    codigo = g.ToString();
                    pnSendCodigo.Dispose();
                    Visible = false;
                    VentanaSending view = new VentanaSending(email,codigo);
                    DialogResult dialogResult = view.ShowDialog();
                    if (dialogResult == DialogResult.OK)
                    {
                     
                    }

                    view.Show();
                }
                else
                {
                    DataEmail.SetErrorMessage("No existe ningun usuario con este mail ");
                }
            }
        }

      
    }
}
