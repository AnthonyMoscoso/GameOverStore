using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsUI.Controladores
{
    public partial class pnCard : UserControl
    {
        public delegate void SendCodigo(int codigo);
        public SendCodigo _SendCodigo;
       public Padding PaddingInt { get; set; }

        public Padding PaddingOut { get; set; }

        public Image ImagePanel { get; set; }
        public string Texto { get; set; }
        public int Codigo_Envio { get; set; }
        public pnCard()
        {
            

            InitializeComponent();
            this.MouseEnter += ptbxImage_MouseEnter;
            this.MouseLeave += ptbxImage_MouseLeave;
            this.MouseHover+= ptbxImage_MouseEnter;

        }
      
        private void ptbxImage_MouseEnter(object sender, EventArgs e)
        {
            if (PaddingInt != null)
            {
                pnContainder.Padding = PaddingInt;
            }
            
        }

        private void ptbxImage_MouseLeave(object sender, EventArgs e)
        {
            if (PaddingOut != null)
            {
                pnContainder.Padding = PaddingOut;
            }
           
        }

        private void pnCard_Load(object sender, EventArgs e)
        {
            if (ImagePanel != null)
            {
                ptbxImage.Image = ImagePanel;
            }
            if (Texto != null)
            {
                lbText.Text = Texto;
            }
        }

        private void ptbxImage_Click(object sender, EventArgs e)
        {
            if (_SendCodigo != null)
            {
                _SendCodigo(this.Codigo_Envio);

            }
        }
    }
}
