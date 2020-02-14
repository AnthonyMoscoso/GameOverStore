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

        private void Button1_Click(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = true;
           dataGridView1.DataSource= _servicioArticulo.GetAll();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }
    }
}
