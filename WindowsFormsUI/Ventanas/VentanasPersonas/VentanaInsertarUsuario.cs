using Entitidades.Concretas;
using Entitidades.Users;
using Negocios.Abstractas;
using Negocios.Abstractas.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsUI.Eventos;
using static WindowsFormsUI.Ventanas.VentanaPrincipal;

namespace WindowsFormsUI.Ventanas
{
    public partial class VentanaInsertarUsuario : Form
    {
        IServicioPermisos _servicioPermisos;
        IServicioPersona _servicioPersona;
        IServicioUsuarios _ServicioUsuario;
        IServicioSocios _servicioSocios;
        public string RUTA_IMAGENES_PERSONAS = @"_Imagenes\_Personas\";

        public List<Permisos> PermisosUsuario=new List<Permisos>();
       
     
        public VentanaInsertarUsuario(IServicioPermisos servicioPermisos,IServicioUsuarios servicioUsuarios,IServicioPersona servicioPersona,IServicioSocios servicioSocios)
        {
            _servicioPermisos = servicioPermisos;
            _servicioPersona = servicioPersona;
            _ServicioUsuario = servicioUsuarios;
            _servicioSocios = servicioSocios;
            InitializeComponent();
           
            if (VentanaPrincipal._TIPO_LLAMADA_PERSONA==TIPO_LLAMADA_PERSONA.ACTUALIZAR_USUARIO)
            {
                LoadPermisos();
            }
            else  if(VentanaPrincipal._TIPO_LLAMADA_PERSONA==TIPO_LLAMADA_PERSONA.ACTUALIZAR_SOCIO)
            {
             
            }
            else if (VentanaPrincipal._TIPO_LLAMADA_PERSONA==TIPO_LLAMADA_PERSONA.INSERTAR_SOCIO)
            {
                btnBack.Visible = false;
                pnContainerPermisos.Visible = false;
                pnTopPermisos.Visible = false;
            }
            else
            {
                btnBack.Visible = false;
                LoadPermisos();
            }
           
            txtPassword.UseSystemPasswordChar = PasswordPropertyTextAttribute.Yes.Password;
        }
        private void LoadPermisos()
        {
            List<Permisos> list = _servicioPermisos.GetAll();
            foreach(Permisos p in list){
                CheckBox c = new CheckBox();
                c.Width = 200;
                c.Height = 30;
                c.CheckStateChanged += C_CheckStateChanged;
                c.Text = p.Nombre;
                pnContainerPermisos.Controls.Add(c);
           
            }
        }

        private void C_CheckStateChanged(object sender, EventArgs e)
        {
            CheckBox c = sender as CheckBox;
            Permisos P = _servicioPermisos.Get("Nombre ='" + c.Text + "'");
            if (c.Checked){    
                PermisosUsuario.Add(P);
            }
            else
            {
                PermisosUsuario.Remove(P);
            }
        }

        private void ptbxSeePass_Click(object sender, EventArgs e)
        {
            if (txtPassword.UseSystemPasswordChar == PasswordPropertyTextAttribute.Yes.Password)
            {
                txtPassword.UseSystemPasswordChar = PasswordPropertyTextAttribute.No.Password;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = PasswordPropertyTextAttribute.Yes.Password;


            }
        }
        
        private void btnSeePermisos_Click(object sender, EventArgs e)
        {
            if (!pnContainerPermisos.Visible)
            {
                pnContainerPermisos.Visible = true;
            }
            else
            {
                pnContainerPermisos.Visible = false;
            }
           

        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.NumerosDecimales(e);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ImagenControls.OpenFileDialogImage(alertImage,BoxImagePersona,txtUrlImagen,250000);
          
        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            if (_TIPO_LLAMADA_PERSONA== TIPO_LLAMADA_PERSONA.ACTUALIZAR_USUARIO)
            {
                ActualizarUsuario();
            }
            else if (_TIPO_LLAMADA_PERSONA == TIPO_LLAMADA_PERSONA.ACTUALIZAR_SOCIO)
            {

            }
            else if (_TIPO_LLAMADA_PERSONA == TIPO_LLAMADA_PERSONA.INSERTAR_SOCIO)
            {
                InsertarSocio();
            }
            else
            {
                InsertarUsuario();
            }

        }
        private string actualizarImagen(string oldImage,string newImage)
        {
            return null;
        }
   
        private void InsertarUsuario()
        {
            Usuarios usuarios = new Usuarios();
            usuarios.Nombre = txtNombre.Text;
            usuarios.Apellido = txtApellido.Text;
            usuarios.Email = txtEmail.Text;
            usuarios.Telefono = txtTelefono.Text;
            usuarios.Contraseña = txtPassword.Text;
            usuarios.tipo = Personas.Tipo.Usuario;
            usuarios.Imagen = ImagenControls.SaveImagenIn(RUTA_IMAGENES_PERSONAS,txtUrlImagen.Text,usuarios.Nombre);
            usuarios.Id = _servicioPersona.Add(usuarios).Id;
            usuarios.FechaContratacion = DateTime.Now;
            usuarios.Permisos = PermisosUsuario;
            usuarios.Pin = usuarios.Nombre;
            _ServicioUsuario.Add(usuarios);
        }
        private void ActualizarUsuario()
        {
            Usuarios usuarios = new Usuarios();
            usuarios.Nombre = txtNombre.Text;
            usuarios.Apellido = txtApellido.Text;
            usuarios.Email = txtEmail.Text;
            usuarios.Telefono = txtTelefono.Text;

            usuarios.Imagen = ImagenControls.SaveImagenIn(RUTA_IMAGENES_PERSONAS, txtUrlImagen.Text, usuarios.Nombre);
            usuarios.tipo = Personas.Tipo.Usuario;
            usuarios.Id = _servicioPersona.Add(usuarios).Id;
            _ServicioUsuario.Add(usuarios);
        }
        private void ActualizarSocio()
        {

        }
        private void InsertarSocio()
        {
            Socios socio = new Socios();
            socio.Nombre = txtNombre.Text;
            socio.Apellido = txtApellido.Text;
            socio.Email = txtEmail.Text;
            socio.Telefono = txtTelefono.Text;
            socio.Imagen = ImagenControls.SaveImagenIn(RUTA_IMAGENES_PERSONAS, txtUrlImagen.Text, socio.Nombre);
            socio.Dni = txtDni.Text;
            socio.Descuento = 0;
            socio.Id = _servicioPersona.Add(socio).Id;
            _servicioSocios.Add(socio);

        }
      

        private void pnEmail_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
