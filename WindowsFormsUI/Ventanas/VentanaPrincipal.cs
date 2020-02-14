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
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsUI.Eventos;
using WindowsFormsUI.Login;
using WindowsFormsUI.Ventanas.VentanasPersonas;
using static WindowsFormsUI.Controladores.pnCard;
using static WindowsFormsUI.Ventanas.VentanaViewProducto;

namespace WindowsFormsUI.Ventanas
{
    public partial class VentanaPrincipal : Form
    {
        public delegate void ChangeOpacity(int opacity);
        public ChangeOpacity change;
        public static Image notFound = Image.FromFile(Path.GetFullPath(@"_Imagenes\Iconos\imageNotFound.png"));
        public static int tipeCallUsuarios { get; set; }

        public VentanaPrincipal()
        {
          /*  VentanaLogin view = CompositionRoot.Resolve<VentanaLogin>();
            this.Opacity = 0;*/
          //*  view.Show();
           // view.change += login_opaccity;
            InitializeComponent();
            pnTop.MouseDown += Movement.Pn_MouseDown;



                  }

     
        private void login_opaccity(int n)
        {
            this.Opacity = n;


        }
        public static Productos Producto
        {
            get; set;
        }
        public enum TIPO_LLAMADA_PERSONA {
             ACTUALIZAR_SOCIO, ACTUALIZAR_USUARIO, INSERTAR_SOCIO, INSERTAR_USUARIO
        };
        public static TIPO_LLAMADA_PERSONA _TIPO_LLAMADA_PERSONA;
        public static Tipo_dato tipo { get; set; }
        public static int  tipoPersona{ get; set; }

        private void btnClose_Click(object sender, EventArgs e)
        {

            this.Dispose(); this.Close();


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
            view._GoBackInventario += G_GoBackInventario;



        }
        private void G_GoBackInventario()
        {

            VentanaInventario g = CompositionRoot.Resolve<VentanaInventario>();
            AbrirFormInPanel(g);
            g.showProducto += G_showProducto;

        }
        private void g_SendCodigoToPantallaPrincipal(Tipo_dato tipo_Dato )
        {
            VentanaEditAjustes view = CompositionRoot.Resolve<VentanaEditAjustes>();
            tipo = tipo_Dato;
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
                pnContainer.Controls[0].Dispose();
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
            _TIPO_LLAMADA_PERSONA = TIPO_LLAMADA_PERSONA.INSERTAR_USUARIO;
            VentanaInsertarUsuario g = CompositionRoot.Resolve<VentanaInsertarUsuario>();
            AbrirFormInPanel(g);
            
        }

        private void VentanaPrincipal_Load(object sender, EventArgs e)
        {
           
         //  VentanaLogin v = CompositionRoot.Resolve<VentanaLogin>();
          //  v.Visible = true;
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VentanaGestionPersonas g = CompositionRoot.Resolve<VentanaGestionPersonas>();
            AbrirFormInPanel(g);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            VentanaVenta g = CompositionRoot.Resolve<VentanaVenta>();
            AbrirFormInPanel(g);
        }
    }
}
