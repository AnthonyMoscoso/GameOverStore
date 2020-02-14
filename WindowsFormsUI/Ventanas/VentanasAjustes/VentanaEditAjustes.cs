using Entitidades.Concretas;
using Entitidades.Simples;
using Negocios.Abstractas.Simples;
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
using WindowsFormsUI.Controladores;
using WindowsFormsUI.Eventos;
using static WindowsFormsUI.Controladores.pnCard;

namespace WindowsFormsUI.Ventanas
{
    public partial class VentanaEditAjustes : Form
    {
        IServicioPlataformas _servicioPlataformas;
        IServicioClasificaciones _servicioClasificaciones;
        IServicioDesarrolladoras _servicioDesarrolladoras;
        IServicioGeneros _servicioGeneros;
        IServicioIdiomas _servicioIdiomas;
        public delegate void backAjuste();
        public backAjuste _backAjuste;
      
       
        public string RUTA_IMAGENES_AJUSTES = @"_Imagenes\_Ajustes\";
        public string imagen_original;
        public VentanaEditAjustes(IServicioPlataformas servicioPlataformas,
        IServicioClasificaciones servicioClasificaciones,
        IServicioDesarrolladoras servicioDesarrolladoras,
        IServicioGeneros servicioGeneros,
        IServicioIdiomas servicioIdiomas)
        {
            _servicioPlataformas = servicioPlataformas;
            _servicioIdiomas = servicioIdiomas;
            _servicioGeneros = servicioGeneros;
            _servicioClasificaciones = servicioClasificaciones;
            _servicioDesarrolladoras = servicioDesarrolladoras;
            InitializeComponent();
            gestion = Gestion.añadir;
        }
        public enum Gestion
        {
            añadir, actualizar
        }
        public Gestion gestion;

        public string nombre_original;
       

        public void adapter_sendDatos(int id, Image image, List<string> datos)
        {
            txtId.Text = id.ToString();
            ptxImage.Image = image;
            txtNombre.Text = datos[0];
            if (datos.Count > 1)
            {
                pnDescripcion.Visible = true;
                txtDescripcion.Text = datos[1];
            }
            btnAdd.Text = "Actualizar";
            gestion = Gestion.actualizar;
            nombre_original = datos[0].TrimEnd();
            imagen_original = image.ToString();
        }
        private void VentanaEditAjustes_Load(object sender, EventArgs e)
        {
            if (VentanaPrincipal.tipo == Tipo_dato.plataformas)
            {
                List<Plataformas> List = _servicioPlataformas.GetAll();
                foreach (Plataformas p in List)
                {
                    AdapterAjuster a = new AdapterAjuster(p);
                    a._sendDatos += adapter_sendDatos;
                    pnContenedor.Controls.Add(a);
                    a._sendToDelete += a_sendToDelete;

                }
            }
            else if (VentanaPrincipal.tipo == Tipo_dato.generos)
            {
                List<Generos> List = _servicioGeneros.GetAll();
                foreach (Generos p in List)
                {
                    AdapterAjuster a = new AdapterAjuster(p);
                    a._sendDatos += adapter_sendDatos;
                    pnContenedor.Controls.Add(a);
                    a._sendToDelete += a_sendToDelete;
                }
            }
            else if (VentanaPrincipal.tipo == Tipo_dato.clasificaciones)
            {
                List<Clasificaciones> List = _servicioClasificaciones.GetAll();
                foreach (Clasificaciones p in List)
                {
                    AdapterAjuster a = new AdapterAjuster(p);
                    a._sendDatos += adapter_sendDatos;
                    pnContenedor.Controls.Add(a);
                    a._sendToDelete += a_sendToDelete;

                }
            }
            else if (VentanaPrincipal.tipo == Tipo_dato.desarrolladoras)
            {
                List<Desarrolladoras> List = _servicioDesarrolladoras.GetAll();
                foreach (Desarrolladoras p in List)
                {
                    AdapterAjuster a = new AdapterAjuster(p);
                    a._sendDatos += adapter_sendDatos;
                    pnContenedor.Controls.Add(a);
                    a._sendToDelete += a_sendToDelete;

                }
            }
            else
            {
                List<Idiomas> List = _servicioIdiomas.GetAll();
                foreach (Idiomas p in List)
                {
                    AdapterAjuster a = new AdapterAjuster(p);
                    a._sendDatos += adapter_sendDatos;
                    pnContenedor.Controls.Add(a);
                    a._sendToDelete += a_sendToDelete;
                    
                }
            }
        }

        private void a_sendToDelete(Tipo_dato dato,int id)
        {
            switch (dato)
            {
                case Tipo_dato.clasificaciones:
                    MessageBox.Show(/*_servicioClasificaciones.Delete*/(_servicioClasificaciones.GetById(id)).ToString());
                    break;
                case Tipo_dato.desarrolladoras:
                    MessageBox.Show(/*_servicioDesarrolladoras.Delete*/(_servicioDesarrolladoras.GetById(id)).ToString());
                    break;
                case Tipo_dato.generos:
                    MessageBox.Show(/*_servicioGeneros.Delete*/(_servicioGeneros.GetById(id)).ToString());
                    break;
                case Tipo_dato.idiomas:
                    MessageBox.Show(/*_servicioIdiomas.Delete*/(_servicioIdiomas.GetById(id)).ToString());
                    break;
                case Tipo_dato.plataformas:
                    MessageBox.Show(/*_servicioPlataformas.Delete*/(_servicioPlataformas.GetById(id)).ToString());
                    break;
            }
            pnContenedor.Refresh();
        }
        private void PtbxCancel_Click(object sender, EventArgs e)
        {
            PictureBox a = sender as PictureBox;
            a.Parent.Dispose();

            pnContenedor.Refresh();
            
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            if (_backAjuste != null)
            {
                _backAjuste();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            txtImagen.Text = "";
            ptxImage.Image = Image.FromFile(ImagenControls.ImageNotFound);
            btnAdd.Text = "Insertar";
            gestion = Gestion.añadir;
        }

        private bool isCorrectData()
        {

            if (txtNombre.Text.Trim().Length > 0 && !txtNombre.Text.Equals(txtNombre.Hint))
            {
                
                return true;

            }
            alertNombre.SetErrorMessage("Debe introducir un dato en el Nombre");
            return false;

        }
        private bool existDesarrolladora(string nombre)
        {
            Desarrolladoras d = _servicioDesarrolladoras.Get("Nombre='" + nombre + "'");
            if (d != null)
            {
                alertNombre.SetErrorMessage("Ya existe un dato con este nombre");
                return true;
            }

            return false;
        }
        private bool existGenero(string nombre)
        {
            Generos d = _servicioGeneros.Get("Nombre='" + nombre + "'");
            if (d != null)
            {
                alertNombre.SetErrorMessage("Ya existe un dato con este nombre");
                return true;
            }

            return false;
        }
        private bool existClasificaciones(string nombre)
        {
            Clasificaciones d = _servicioClasificaciones.Get("Nombre='" + nombre + "'");
            if (d != null)
            {
                alertNombre.SetErrorMessage("Ya existe un dato con este nombre");
                return true;
            }

            return false;
        }
        private bool existIdiomas(string nombre)
        {
            Idiomas d = _servicioIdiomas.Get("Nombre='" + nombre + "'");
            if (d != null)
            {
                alertNombre.SetErrorMessage("Ya existe un dato con este nombre");
                return true;
            }
          
            return false;
        }

        private bool existPlataformas(string nombre)
        {
            Plataformas d = _servicioPlataformas.Get("Nombre='" + nombre + "'");
            if (d != null)
            {
                alertNombre.SetErrorMessage("Ya existe un dato con este nombre");
                return true;
            }

            return false;
        }
        private bool canInsert(string nombre)
        {
            switch (VentanaPrincipal.tipo)
            {
                case Tipo_dato.clasificaciones:


                    if (!existClasificaciones(nombre))
                    {
                        
                        _servicioClasificaciones.Add(createClasificacion());
                       
                        return true;
                    }


                    break;
                case Tipo_dato.desarrolladoras:
                    if (!existDesarrolladora(nombre))
                    {
                       
                        _servicioDesarrolladoras.Add(createDesarrolladora());
                        return true;
                    }
                    break;
                case Tipo_dato.generos:
                    if (!existGenero(nombre))
                    {
                        
                        _servicioGeneros.Add(createGenero());
                        return true;
                    }
                    break;
                case Tipo_dato.idiomas:
                    if (!existIdiomas(nombre))
                    {
                        
                        _servicioIdiomas.Add(createIdioma());
                        return true;
                    }
                    break;
                case Tipo_dato.plataformas:
                    if (!existPlataformas(nombre))
                    {
                        
                        _servicioPlataformas.Add(createPlataforma());
                        return true;
                    }
                    break;
            }
            return false;
        }
    
        private Idiomas createIdioma()
        {
            Idiomas e = new Idiomas();
            e.Nombre = txtNombre.Text.TrimEnd();
            e.Imagen = ImagenControls.SaveImagenIn(RUTA_IMAGENES_AJUSTES,txtImagen.Text,e.Nombre);
            return e;
        }
        private Desarrolladoras createDesarrolladora()
        {
            Desarrolladoras e = new Desarrolladoras();
            e.Nombre = txtNombre.Text.TrimEnd();
            e.Imagen = ImagenControls.SaveImagenIn(RUTA_IMAGENES_AJUSTES, txtImagen.Text, e.Nombre);
            return e;
        }
        private Generos createGenero()
        {
            Generos e = new Generos();
            e.Nombre = txtNombre.Text.TrimEnd();
            e.Imagen = ImagenControls.SaveImagenIn(RUTA_IMAGENES_AJUSTES, txtImagen.Text, e.Nombre);
            if (txtDescripcion.Text.Trim().Length > 0 && !txtDescripcion.Text.Equals(txtDescripcion.Hint))
            {
                e.Descripcion = txtDescripcion.Text;
            }
            return e;
        }
        private Plataformas createPlataforma()
        {
            Plataformas e = new Plataformas();
            e.Nombre = txtNombre.Text.TrimEnd();
            e.Imagen = ImagenControls.SaveImagenIn(RUTA_IMAGENES_AJUSTES, txtImagen.Text, e.Nombre); ;
            return e;
        }
        private Clasificaciones createClasificacion()
        {
            Clasificaciones e = new Clasificaciones();
            e.Nombre = txtNombre.Text.TrimEnd();
            e.Imagen = ImagenControls.SaveImagenIn(RUTA_IMAGENES_AJUSTES, txtImagen.Text, e.Nombre);
            return e;
        }
        public void UpdateClasificacion(string nombre)
        {
            if (existClasificaciones(nombre) && nombre != nombre_original)
            {
                alertNombre.SetErrorMessage("Ya existe un elemento en la base de datos con este nombre");
            }
            else
            {
                Clasificaciones e = createClasificacion();
                e.Id = int.Parse(txtId.Text);
                if (e.Imagen != imagen_original)
                {
                    ImagenControls.DeleteImagen(imagen_original);
                  
                }
                _servicioClasificaciones.Update(e);
            }

        }
      
        
      
        private void UpdateDesarrolladora(string nombre)
        {
            if (existDesarrolladora(nombre) && nombre != nombre_original)
            {
                alertNombre.SetErrorMessage("Ya existe un elemento en la base de datos con este nombre");
            }
            else
            {
                Desarrolladoras e = createDesarrolladora();
                e.Id = int.Parse(txtId.Text);
                if (e.Imagen != imagen_original)
                {
                    ImagenControls.DeleteImagen(imagen_original);

                }
                _servicioDesarrolladoras.Update(e);
            }

        }
        private void UpdatePlataforma(string nombre)
        {
            if (existPlataformas(nombre) && nombre!= nombre_original)
            {
                alertNombre.SetErrorMessage("Ya existe un elemento en la base de datos con este nombre");
            }
            else
            {
                Plataformas e = createPlataforma();
                int Id= int.Parse(txtId.Text);
                e.Id = Id;
                if (e.Imagen != imagen_original){
                    ImagenControls.DeleteImagen(imagen_original);

                }
                _servicioPlataformas.Update(e);
            }

        }
       
        private void UpdateIdiomas(string nombre)
        {
            if (existIdiomas(nombre) && nombre != nombre_original)
            {
                alertNombre.SetErrorMessage("Ya existe un elemento en la base de datos con este nombre");
            }
            else
            {
                Idiomas e = createIdioma();
                e.Id = int.Parse(txtId.Text);
                if (e.Imagen != imagen_original)
                {
                    ImagenControls.DeleteImagen(imagen_original);

                }
                _servicioIdiomas.Update(e);
            }

        }
        private void UpdateGenero(string nombre)
        {
            if (existGenero(nombre) && nombre != nombre_original)
            {
                alertNombre.SetErrorMessage("Ya existe un elemento en la base de datos con este nombre");
            }
            else
            {
                Generos e = createGenero();
                e.Id = int.Parse(txtId.Text);
                if (e.Imagen != imagen_original)
                {
                    ImagenControls.DeleteImagen(imagen_original);

                }
                _servicioGeneros.Update(e);
            }

        }
        private void sendToUpdate(string nombre)
        {
            switch (VentanaPrincipal.tipo)
            {
                case Tipo_dato.clasificaciones:
                    UpdateClasificacion(nombre);
                    break;
                case Tipo_dato.generos:
                    UpdateGenero(nombre);
                    break;
                case Tipo_dato.idiomas:
                    UpdateIdiomas(nombre);
                    break;
                case Tipo_dato.plataformas:
                    UpdatePlataforma(nombre);
                    break;
                case Tipo_dato.desarrolladoras:
                    UpdateDesarrolladora(nombre);
                    break;
            }

        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (isCorrectData())
            {
                if (gestion == Gestion.añadir)
                {
                    if (canInsert(""))
                    {
                        alertNombre.isCorrect();
                        MessageBox.Show("Ingresado con exito");
                    }
                }
                else
                {
                    sendToUpdate(txtNombre.Text.TrimEnd());
                   
                }

            }
            Refresh();

        }

        private void btnOpenImage_Click(object sender, EventArgs e)
        {
            ImagenControls.OpenFileDialogImage(alertImagen,ptxImage,txtImagen,150000);
        }

        private void ptxImage_Click(object sender, EventArgs e)
        {

        }
    }
}
