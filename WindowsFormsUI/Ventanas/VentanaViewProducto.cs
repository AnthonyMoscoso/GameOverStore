using Entitidades.Concretas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsUI.Ventanas
{
    public partial class VentanaViewProducto : Form
    {
     
        Productos _producto;
        public VentanaViewProducto()
        {
       
            
            InitializeComponent();

           
           
        }

        
    

        private void VentanaViewProducto_Load(object sender, EventArgs e)
        {
            _producto = VentanaPrincipal.Producto;
    
            string html = "<html><head>";
            html += "<meta content='IE=Edge' http-equiv='X-UA-Compatible'/>";
            html += "<iframe id='video' src= 'https://www.youtube.com/embed/{0}' width='100%' height='100%' frameborder='0' fs=1' allowfullscreen webkitallowfullscreen mozallowfullscreen></iframe>";
            html += "</body></html>";
            webBrowser1.DocumentText = string.Format(html, _producto.Url.ToString().Split('=')[1]);
        }
    }
}
