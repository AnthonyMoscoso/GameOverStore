using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsUI.Ventanas._Componentes
{
    public partial class FomrPaginador : UserControl
    {
        public int MaxPaginas { get; set; }
        public FomrPaginador()
        {
            InitializeComponent();
            this.Load += FomrPaginador_Load;
           
        }

        private void FomrPaginador_Load(object sender, EventArgs e)
        {
            if (MaxPaginas<=0)
            {
                MaxPaginas = 10;
            }
            for (int i = 0; i < MaxPaginas; i++)
            {
                ButtonNumPaginate button = new ButtonNumPaginate(i + 1);
                pnNumsPagine.Controls.Add(button);
            }
        }
    }
}
