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

namespace WindowsFormsUI
{
    public partial class Form2 : Form
    {
        IServicioUsuarios _servicioArticulo;
        public Form2(IServicioUsuarios servicioArticulo)
        {
            _servicioArticulo = servicioArticulo;
            InitializeComponent();
        }

     
    }
}
