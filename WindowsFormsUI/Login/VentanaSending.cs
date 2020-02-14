using Nucleo.Utilidades.Concreta;
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
    public partial class VentanaSending : Form
    {
        public VentanaSending(string Email,string codigo)
        {
            InitializeComponent();
            CorreoSmtp.Enviar(Email, codigo);
            this.DialogResult = DialogResult.OK;
            Close();
        }
    }
}
