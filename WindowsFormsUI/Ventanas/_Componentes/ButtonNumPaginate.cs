using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsUI.Ventanas._Componentes
{
    public partial class ButtonNumPaginate : UserControl
    {
        public ButtonNumPaginate(int n)
        {
            InitializeComponent();
            this.lbNum.Text = n.ToString();
            this.MouseEnter += ButtonNumPaginate_MouseEnter;
            this.MouseLeave += ButtonNumPaginate_MouseLeave;

        }

        private void ButtonNumPaginate_MouseLeave(object sender, EventArgs e)
        {
            this.Padding = new Padding(2);
        }

        private void ButtonNumPaginate_MouseEnter(object sender, EventArgs e)
        {
            this.Padding = new Padding(4);
        }


    }
}
