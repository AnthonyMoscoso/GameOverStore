using Entitidades.Concretas;
using Negocios.Abstractas.Compuestas;
using Negocios.Abstractas.Simples;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsUI.Ventanas
{
    public partial class VentanaPrincipal : Form
    {
        public delegate void SendCodigo();
        public SendCodigo _SendCodigo;
        public static Image notFound = Image.FromFile(Path.GetFullPath(@"_Imagenes\Iconos\imageNotFound.png"));
        public VentanaPrincipal()
        {

            InitializeComponent();
        }
        public static Productos Producto
        {
            get; set;
        }
        public static int Codigo
        {
            get; set;
        }
        public static int  tipoPersona{ get; set; }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnResize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCaja_Click(object sender, EventArgs e)
        {
            VentanaInventario g = CompositionRoot.Resolve<VentanaInventario>();
            AbrirFormInPanel(g);
            g.showProducto += G_showProducto;
           


        }
        private void G_showProducto(Productos productos)
        {
            VentanaViewProducto view = CompositionRoot.Resolve<VentanaViewProducto>();
            Producto = productos;
            AbrirFormInPanel(view);
          

        }
        private void g_SendCodigoToPantallaPrincipal(int codigo )
        {
            VentanaEditAjustes view = CompositionRoot.Resolve<VentanaEditAjustes>();
            Codigo = codigo;
            AbrirFormInPanel(view);
            view._backAjuste += G_backAjustes;
        }
        private void G_backAjustes()
        {
            VentanaAjustes g = CompositionRoot.Resolve<VentanaAjustes>();
            AbrirFormInPanel(g);
            g._SendCodigoToPantallaPrincipal += g_SendCodigoToPantallaPrincipal;

        }



        private void AbrirFormInPanel(object formHijo)
        {
            if (pnContainer.Controls.Count > 0)
            {
                pnContainer.Controls.Clear();
            }
            Form fh = formHijo as Form;

            fh.TopLevel = false;


            fh.Dock = DockStyle.Fill;
            // fh.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom;

            pnContainer.Controls.Add(fh);
            pnContainer.Tag = fh;
            fh.Show();

            // 
        }

        private void VentanaPrincipal_Resize(object sender, EventArgs e)
        {

        }

        private void btnInventario_Click(object sender, EventArgs e) 
        {
            VentanaInsertarProducto g= CompositionRoot.Resolve<VentanaInsertarProducto>();
            AbrirFormInPanel(g);
        }

        private void VentanaPrincipal_MouseEnter(object sender, EventArgs e)
        {

        }

        private void btnAjustes_Click(object sender, EventArgs e)
        {
            VentanaAjustes g = CompositionRoot.Resolve<VentanaAjustes>();
            AbrirFormInPanel(g);
            g._SendCodigoToPantallaPrincipal += g_SendCodigoToPantallaPrincipal;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VentanaInsertarUsuario g = CompositionRoot.Resolve<VentanaInsertarUsuario>();
            AbrirFormInPanel(g);
            tipoPersona = 1;
        }
    }
}
