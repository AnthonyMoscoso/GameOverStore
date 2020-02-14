using Negocios.Abstractas;
using Negocios.Abstractas.Users;
using System;
using System.Windows.Forms;

namespace WindowsFormsUI
{
    public partial class Form1 : Form
    {
        IServicioUsuarios _servicioArticulo;
      
        public Form1(IServicioUsuarios servicioArticulo)
        {
            _servicioArticulo = servicioArticulo;
         
             
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource= _servicioArticulo.GetAll();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form formulario= CompositionRoot.Resolve<Form2>() ;
            formulario.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
