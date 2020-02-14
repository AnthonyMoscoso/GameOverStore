using Entitidades.Concretas;
using Entitidades.Users;
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
using WindowsFormsUI.Ventanas._Componentes;

namespace WindowsFormsUI.Ventanas._FICHAS
{
    public partial class _FichaPersona : Form
    {
        private Socios socie;
        private Usuarios usuario;
        private bool IsUpdate = false;
        private int Id;
        private List<Permisos>ListPermisos;
        private string Imagen_Inicial;
        public string RUTA_IMAGENES_PERSONAS = @"_Imagenes\_Personas\";
        private IServicioPersona _PersonaServicio = CompositionRoot.Resolve<IServicioPersona>();
        private IServicioPermisos _servicioPermisos = CompositionRoot.Resolve<IServicioPermisos>();
        private IServicioUsuarios _servicioUsuarios = CompositionRoot.Resolve<IServicioUsuarios>();



        public _FichaPersona(Socios socio)
        {
            InitializeComponent();
            socie = socio;
            Id = socie.Id;
            LoadDataSocio(socie);
            btnActualizar.Click += BtnActualizarSocio_Click;
           
        }

        private void BtnActualizarSocio_Click(object sender, EventArgs e)
        {
            IsUpdate = true;
        }
       
        public _FichaPersona(Usuarios user)
        {
           
            InitializeComponent();
            usuario = user;
            usuario.Permisos = _servicioPermisos.GetPermisosByIdUsuario(usuario.Id);
            Id = usuario.Id;
            btnActualizar.Click += BtnActualizarUsuario_Click;
            LoadDataUsuario(usuario);
        }

        private void BtnActualizarUsuario_Click(object sender, EventArgs e)
        {
            IsUpdate = true;
        }

        private void LoadDataSocio(Socios Persona)
        {
           
         
        }
        private void LoadGeneralData(Personas Persona)
        {
            pnTop.MouseDown += Movement.Pn_MouseDown;
            pnDataNombre.Texto = Persona.Nombre;
            pnDataApellido.Texto = Persona.Apellido;
            pnDataEmail.Texto = Persona.Email;
            pnDataTelefono.Texto = Persona.Telefono;
            pnDataContraseña.Texto = Persona.Contraseña;
        
            if (File.Exists(Persona.Imagen))
            {
                ptbxImagen.Image = Image.FromFile(Persona.Imagen);
            }
            else
            {
                ptbxImagen.Image = Image.FromFile(ImagenControls.ImageNotFound);
                Persona.Imagen = ImagenControls.ImageNotFound;
            }
            Imagen_Inicial = Persona.Imagen;
            txtRutaImagen.Text = Persona.Imagen;
        }
        private void LoadDataUsuario(Usuarios Persona)
        {
          LoadGeneralData(Persona);
          LoadPermiso();

            
        }
        private void LoadPermiso()
        {
            
            ListPermisos = _servicioPermisos.GetAll();
            foreach (Permisos Permiso in ListPermisos)
            {
                CheckBox c = new CheckBox();
                c.Text = Permiso.Nombre;
                c.CheckedChanged += C_CheckedChanged;
                pnPermisos.Controls.Add(c);

                if (usuario.Permisos.Contains(Permiso) && usuario.Permisos!=null)
                {
                    c.Checked=true;
                }
            }

        }

        private void C_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            Permisos p =_servicioPermisos.Get("Nombre ='"+checkBox.Text+"'");
            if (checkBox.Checked)
            {
                if (!usuario.Permisos.Contains(p))
                {
                    usuario.Permisos.Add(p);
                }
              
            }
            else
            {
                usuario.Permisos.Remove(p);
            }
        }

        public bool HasBeenUpdate()
        {
            return IsUpdate;
        }

        public Socios GetSocio()
        {
            return socie;
        }
        public Usuarios GetUsuario()
        {
            return usuario;
        }
   
      

        private void btnOpenDialog_Click(object sender, EventArgs e)
        {
            ImagenControls.OpenFileDialogImage(alertImagen, ptbxImagen, txtRutaImagen, 250000);
        }

  
        
        private bool IsStringEnty(DataBox pnData)
        {
            string Data = pnData.Texto.TrimEnd();
            string Hint = pnData.TextoHint;
            if (Data.Trim().Length >= 0 && !Data.Equals(Hint))
            {
                return true;
            }
            pnData.SetErrorMessage("El campo "+pnData.Titule+" no  puede quedar vacio");
            return false;
           
        }
        private bool ExistData(DataBox pnData)
        {
            Personas p = _PersonaServicio.Get( pnData.Titule+"='"+pnData.Texto+"'");
            if(p != null && p.Id!=Id)
            {

                return true;
            }
            return false;
        }
      
   
     
        private bool isGeneralDataCorrect()
        {
            int n = 0;
            if (!IsStringEnty(pnDataNombre))
            {  
                n++;
            }
            if (!IsStringEnty(pnDataApellido))
            {
                n++;
            }
            if (!IsStringEnty(pnDataEmail) )
            {             
                n++;
            }
            if (!IsStringEnty(pnDataTelefono) || ExistData(pnDataTelefono))
            {
                n++;
            }
            if (!IsStringEnty(pnDataContraseña) || ExistData(pnDataContraseña))
            {
                n++;
            }

            if (n > 0)
            {
                return false;
            }
            return true;
        }

        private void Actualizar_Usuario()
        {

        }
        private void Actualizar_Socio()
        {

        }
    

        private void _FichaPersona_Load(object sender, EventArgs e)
        {

        }
      
      

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (isGeneralDataCorrect() )
            {
                if(usuario.Permisos!=null && usuario.Permisos.Count > 0)
                {
                    usuario.Nombre=pnDataNombre.Texto;
                    usuario.Apellido=pnDataApellido.Texto;
                    usuario.Email=pnDataEmail.Texto;
                    usuario.Contraseña=pnDataContraseña.Texto;
                    usuario.Apellido=pnDataApellido.Texto;
                   
                    if (!Imagen_Inicial.Equals(txtRutaImagen.Text))
                    {
                        ptbxImagen.Image.Dispose();
                     
                        ImagenControls.DeleteImagen(Imagen_Inicial);
                        usuario.Imagen = ImagenControls.SaveImagenIn(RUTA_IMAGENES_PERSONAS, txtRutaImagen.Text, usuario.Nombre);
                    }
                  
                    _PersonaServicio.Update(usuario);
                    _servicioUsuarios.Update(usuario);
                    IsUpdate = true;

                }
                else
                {
                    alertPermisos.SetErrorMessage("Necesita  tener Minimo un Permiso");
                }
            }

        }
    }
}
