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

namespace WindowsFormsUI.Controladores
{
    public partial class ProductoAdapterControl : UserControl
    {
        public ProductoAdapterControl(Productos producto)
        {
            
            InitializeComponent();
            lbGeneros.Text = producto.Generos.ToString();
        }

        private void ProductoAdapterControl_Load(object sender, EventArgs e)
        {

        }
    }
}
