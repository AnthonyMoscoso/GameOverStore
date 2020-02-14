using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsUI.Controladores;

namespace WindowsFormsUI.Ventanas
{
    public partial class VentanaAjustes : Form
    {
        public delegate void SendCodigoToPantallaPrincipal(int codigo);
        public SendCodigoToPantallaPrincipal _SendCodigoToPantallaPrincipal;
        public VentanaAjustes()
        {
            InitializeComponent();
            pnDesarrolladoras._SendCodigo += CardAjustes_SendCodigo;
            pnIdiomas._SendCodigo += CardAjustes_SendCodigo;
            pnClasificaciones._SendCodigo += CardAjustes_SendCodigo;
            pnPlataformas._SendCodigo += CardAjustes_SendCodigo;
            
         
        }

     

        private void pnDesarrolladoras_Load(object sender, EventArgs e)
        {

        } 
        private void CardAjustes_SendCodigo(int CodigoEnvio)
        {
            if (_SendCodigoToPantallaPrincipal != null)
            {
                _SendCodigoToPantallaPrincipal(CodigoEnvio);
            }
            
        }

      
    }
}
