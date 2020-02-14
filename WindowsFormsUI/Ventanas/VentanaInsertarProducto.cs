using Entitidades.Concretas;
using Entitidades.Simples;
using Negocios.Abstractas.Compuestas;
using Negocios.Abstractas.Simples;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsUI.Eventos;

namespace WindowsFormsUI
{
    public partial class VentanaInsertarProducto : Form
    {
        IServicioIdiomas _servicioIdiomas;
        IServicioProductos _servicioProductos;
        IServicioDesarrolladoras _servicioDesarrolladoras;
        IServicioPlataformas _servicioPlataformas;
        IServicioGeneros _servicioGeneros;
        IServicioClasificaciones _servicioClasificaciones;
        public int PICTURE_VERTICAL = 0;
        public int PICTURE_HORIZONTAL = 1;
        public int PICTURE_LOGO = 2;
        public int PICTURE_TYPE;
        public string RUTA_IMAGENES_PRODUCTOS = @"_Imagenes\_Productos\";

        List<Plataformas> Load_plataformas;
        List<Idiomas> Load_Idiomas;
        List<Generos> Load_Generos;
        List<Plataformas> Plataformas_Productos = new List<Plataformas>();
        List<Generos>Generos_Productos=new List<Generos>();
        List<Idiomas> Idiomas_Productos = new List<Idiomas>();
        List<FlowLayoutPanel> panels = new List<FlowLayoutPanel>();
        string ImageNotFound = @"_Imagenes\Iconos\imageNotFound.png";
        Image notFound = Image.FromFile(Path.GetFullPath(@"_Imagenes\Iconos\imageNotFound.png"));


        public VentanaInsertarProducto(IServicioIdiomas servicioIdiomas, IServicioProductos servicioProductos, IServicioPlataformas servicioPlataformas,
            IServicioGeneros servicioGeneros, IServicioDesarrolladoras servicioDesarrolladoras,IServicioClasificaciones servicioClasificaciones)
        {
            _servicioIdiomas = servicioIdiomas;
            _servicioDesarrolladoras = servicioDesarrolladoras;
            _servicioGeneros = servicioGeneros;
            _servicioPlataformas = servicioPlataformas;
            _servicioProductos = servicioProductos;
            _servicioClasificaciones = servicioClasificaciones;

            Load_Idiomas = _servicioIdiomas.GetAll();
            Load_plataformas = _servicioPlataformas.GetAll();
            Load_Generos = _servicioGeneros.GetAll();

            InitializeComponent();
            LoadIdiomas("");
            LoadPlataformas("");
            LoadGeneros("");
            LoadDesarrolladoras();
            LoadClasificaciones();
            panels.Add(pnContainerIdiomas);
            panels.Add(pnContainerGeneros);
            panels.Add(pnContainerPlataformas);
        }
        private void LoadDesarrolladoras()
        {
            List<Desarrolladoras> desarrolladoras = _servicioDesarrolladoras.GetAll();
            cbxDesarrolladoras.DataSource = desarrolladoras;
            foreach (Desarrolladoras d in desarrolladoras)
            {
                cbxDesarrolladoras.AutoCompleteCustomSource.Add(d.ToString());
            }


        }
        private void LoadClasificaciones()
        {
            List<Clasificaciones> clasificaciones = _servicioClasificaciones.GetAll();
            cbxClasificaciones.DataSource = clasificaciones;
        }
        private void LoadIdiomas(string caract)
        {
            pnContainerIdiomas.Controls.Clear();
            foreach (Idiomas i in Load_Idiomas)
            {
                if (i.Nombre.Contains(caract))
                {
                    CheckBox check = new CheckBox();
                    check.Text = i.Nombre;
                    check.Height = 20;
                    check.Width = 100;
                    pnContainerIdiomas.Controls.Add(check);
                    check.CheckStateChanged += chekedidiomas;
                }
            }

        }
        private void chekedp(object sender , EventArgs e)
        {
            CheckBox c = sender as CheckBox;
            Plataformas p = _servicioPlataformas.Get("Name='" + c.Text + "'");
            if (c.Checked)
            {
               
                Plataformas_Productos.Add(p);
            }
            else
            {
                Plataformas_Productos.Remove(p);
            }
        
        }
        private void chekedidiomas(object sender, EventArgs e)
        {
            CheckBox c = sender as CheckBox;
            Idiomas p = _servicioIdiomas.Get("Nombre='" + c.Text + "'");
            if (c.Checked)
            {

                Idiomas_Productos.Add(p);
            }
            else
            {
               Idiomas_Productos.Remove(p);
            }

        }
        private void chekedGeneros(object sender, EventArgs e)
        {
            CheckBox c = sender as CheckBox;
            Generos p = _servicioGeneros.Get("Nombre='" + c.Text + "'");
            if (c.Checked)
            {

                Generos_Productos.Add(p);
            }
            else
            {
                Generos_Productos.Remove(p);
            }

        }
        private void LoadPlataformas(string caract)
        {
            pnContainerPlataformas.Controls.Clear();
            foreach (Plataformas i in Load_plataformas)
            {
                if (i.Nombre.Contains(caract))
                {
                    CheckBox check = new CheckBox();
                    check.Text = i.Nombre;
                    check.Height = 20;
                    check.Width = 130;
                    pnContainerPlataformas.Controls.Add(check);
                    check.CheckStateChanged += chekedp;
                }

            }
        }
        private void LoadGeneros(string caract)
        {
            pnContainerGeneros.Controls.Clear();
            foreach (Generos i in Load_Generos)
            {
                if (i.Nombre.Contains(caract))
                {
                    CheckBox check = new CheckBox();
                    check.Text = i.Nombre;
                    check.Height = 20;
                    check.Width = 100;
                    new ToolTip().SetToolTip(check, i.Descripcion);
                    pnContainerGeneros.Controls.Add(check);
                    check.CheckStateChanged += chekedGeneros;
                }


            }
        }
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void alertPictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
        private void ChangeViewPanels(FlowLayoutPanel panel, Button btn)
        {
            if (panel.Visible)
            {
                panel.Visible = false;
                btn.Text = ">";
            }
            else
            {
                panel.Visible = true;
                foreach (FlowLayoutPanel b in panels)
                {
                    if (b.Name.Equals(panel.Name))
                    {
                        b.Visible = true;
                    }
                    else
                    {
                        b.Visible = false;
                    }

                }
                btn.Text = "v";
            }
        }
        private void btnChangeViewPnContainerIdiomas_Click(object sender, EventArgs e)
        {

            ChangeViewPanels(pnContainerIdiomas, btnChangeViewPnContainerIdiomas);
        }

        private void btnChangeViewPnContainerGeneros_Click(object sender, EventArgs e)
        {
            ChangeViewPanels(pnContainerGeneros, btnChangeViewPnContainerGeneros);
        }

        private void btnChangeViewContainerPlataformas_Click(object sender, EventArgs e)
        {

            ChangeViewPanels(pnContainerPlataformas, btnChangeViewContainerPlataformas);
        }

        private void btnChargeVideo_Click(object sender, EventArgs e)
        {
            string html = "<html><head>";
            html += "<meta content='IE=Edge' http-equiv='X-UA-Compatible'/>";
            html += "<iframe id='video' src= 'https://www.youtube.com/embed/{0}' width='100%' height='100%' frameborder='0' fs=1' allowfullscreen webkitallowfullscreen mozallowfullscreen></iframe>";
            html += "</body></html>";

            /*  if (!wbYoutube.IsBusy)
              {
                  wbYoutube.DocumentText = string.Format(html, txtVideo.Text.Split('=')[1]);
              }
              else
              {
                  wbYoutube.Dispose();

              }*/
            try
            {
                if (txtVideo.Text.Trim().Length > 0)
                {
                    wbYoutube.DocumentText = string.Format(html, txtVideo.Text.Split('=')[1]);
                }
                else
                {
                    alertVideo.SetErrorMessage("Debe introducir un link primero");
                }
            }
            catch (Exception)
            {

            }

        }


        private void VentanaInsertarProducto_Deactivate(object sender, EventArgs e)
        {
            MessageBox.Show("hello");
        }

        private void ptbxHorz_Click(object sender, EventArgs e)
        {
            PICTURE_TYPE = PICTURE_HORIZONTAL;
            lbNamePicture.Text = "Introducir Imagen Horizontal";
            if (txtPtbxHz.Text.Trim().Length > 0)
            {
                try
                {
                    ptbxChange.Image = Image.FromFile(txtPtbxHz.Text);
                }
                catch (FileNotFoundException)
                {
                    ptbxChange.Image = notFound;

                }

            }
            else
            {
                ptbxChange.Image = notFound;
                ptbxHorz.Image = notFound;
            }

        }

        private void ptbxVer_Click(object sender, EventArgs e)
        {
            PICTURE_TYPE = PICTURE_VERTICAL;
            lbNamePicture.Text = "Introducir Imagen Vertical";
            if (txtPtbcV.Text.Trim().Length > 0)
            {
                try
                {
                    ptbxChange.Image = Image.FromFile(txtPtbcV.Text);

                }
                catch (FileNotFoundException)
                {
                    ptbxChange.Image = notFound;

                }

            }
            else
            {
                ptbxChange.Image = notFound;
                ptbxVer.Image = notFound;
            }
        }

        private void ptbxLogo_Click(object sender, EventArgs e)
        {
            PICTURE_TYPE = PICTURE_LOGO;
            lbNamePicture.Text = "Introducir Logo del Juego";
            if (txtPtbxLogo.Text.Trim().Length > 0)
            {
                try
                {
                    ptbxChange.Image = Image.FromFile(txtPtbxLogo.Text);
                }
                catch (FileNotFoundException)
                {
                    ptbxChange.Image = notFound;

                }

            }
            else
            {
                ptbxChange.Image = notFound;
                ptbxLogo.Image = notFound;
            }


        }
        private string guardarImagen(string imagen)
        {
            if (imagen.Trim().Length >= 0)
            {
                try
                {
                    Image guardar = Image.FromFile(imagen);

                    guardar.Save(Path.GetFullPath(Path.Combine(RUTA_IMAGENES_PRODUCTOS, Path.GetFileName(imagen))));
                    guardar.Dispose();
                    return Path.Combine(RUTA_IMAGENES_PRODUCTOS, Path.GetFileName(imagen));
                }
                catch (Exception)
                {
                    return ImageNotFound;
                }
            }
            else
            {
                return ImageNotFound;
            }


        }
        private void btnOpenDialogPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Imagenes |*.jpg;*.png;";
            open.Title = "CHOOSE IMAGE";

            if (open.ShowDialog() == DialogResult.OK)
            {
                

                string url_imagen = open.FileName;
               
                //Image image = Image.FromFile(url_imagen);
                long len = (new System.IO.FileInfo(url_imagen)).Length;
                if(len> 250000)
                {
                    alertPicture.SetErrorMessage("La imagen es demasiado grande , la imagen debe pesar 250000 o menos ");
                
                }
                else
                {
                    ptbxChange.Load(url_imagen);
                    if (PICTURE_TYPE == PICTURE_HORIZONTAL)
                    {

                        txtPtbxHz.Text = url_imagen;
                        ptbxHorz.Image = Image.FromFile(url_imagen);
                    }
                    else if (PICTURE_TYPE == PICTURE_VERTICAL)
                    {
                        txtPtbcV.Text = url_imagen;
                        ptbxVer.Image = Image.FromFile(url_imagen);
                    }
                    else
                    {
                        txtPtbxLogo.Text = url_imagen;
                        ptbxLogo.Image = Image.FromFile(url_imagen);
                    }
                }
              
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            string name = txtName.Text;
            if (name.Trim().Length > 0 && !name.Equals(txtName.Hint))
            {
                Productos p = _servicioProductos.Get("Nombre='" + name + "'");
                if (p != null)
                {
                    alertNombre.SetErrorMessage("Ya existe un producto con el nombre " + name);
                }
                else
                {
                    alertNombre.isCorrect();
                }
            }
            else
            {
                alertNombre.Visible = false;
            }

        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (IsValidProducto())
            {
                Productos p = new Productos();
                p.Nombre = txtName.Text;
                p.Introduccion = txtIntroduccion.Text;
                p.Descripcion = txtDescripcion.Text;
                p.Clasificacion = cbxClasificaciones.SelectedItem as Clasificaciones;
     
                p.Fecha = dtFechaLanzamiento.Value;
                p.Desarrolladora = cbxDesarrolladoras.SelectedItem as Desarrolladoras;
                Decimal compra = Convert.ToDecimal(txtCompra.Text);
                Decimal venta = Convert.ToDecimal(txtPrecioVenta.Text);
                p.Precio_Compra = compra;
                p.Precio_Venta = venta;
                p.Idiomas = Idiomas_Productos;
                p.Generos = Generos_Productos;
                p.Plataformas = Plataformas_Productos;
                p.Imagen_Vertical=guardarImagen(txtPtbcV.Text);
                p.Imagen_Horizontal= guardarImagen(txtPtbxHz.Text);
                p.Imagen_Logo=guardarImagen(txtPtbxLogo.Text);
                p.Url = txtVideo.Text;

                p.Multijugador = 0;


                _servicioProductos.Add(p);

            }
        }
        public bool IsValidProducto()
        {
            int valid = 0;
            if (!IsNameValid())
            {
                valid++;
            }
            if (!IsDesarrolladoraValid())
            {
                valid++;
            }
            if (!IsValidString(txtDescripcion))
            {
                alertDescripcion.SetErrorMessage("No puede dejar este campo vacio");
                valid++;
            }
            if (!IsValidString(txtVideo))
            {
                alertVideo.SetErrorMessage("Dato Erroneo no puede dejar este campo vacio");
                valid++;
            }
            if (!IsValidString(txtIntroduccion))
            {
              alertIntroduccion.SetErrorMessage("Dato Erroneo no puede dejar este campo vacio");
                valid++;
            }
            if (!isValidMoney(txtPrecioVenta))
            {
                alertPrecioVenta.SetErrorMessage("Dato Erroneo no puede dejar este campo vacio");
                valid++;
            }
            if (!isValidMoney(txtCompra))
            {
                alertCompra.SetErrorMessage("Dato Erroneo no puede dejar este campo vacio");
                valid++;
            }
            if (Plataformas_Productos.Count==0)
            {
                alertPlataformas.SetErrorMessage("Tiene que seleccionar minimo un Plataforma");
                valid++;
            }
            if (Idiomas_Productos.Count == 0)
            {
                alertIdiomas.SetErrorMessage("Tiene que seleccionar minimo un Idioma");
                valid++;
            }
            if (Generos_Productos.Count == 0)
            {
                alertGeneros.SetErrorMessage("Tiene que selecciona minimo un Genero");
            }
            if (valid > 0)
            {
                return false;
            }
            return true;
        }
     
        private bool isValidMoney(HintText text)
        {
            string txt = text.Text;
            if (txt.Trim().Length > 0 && !txt.Equals(text.Hint))
            {
                try
                {
                    Decimal d = Convert.ToDecimal(txt);
                    return true;
                }
                catch (FormatException)
                {
                    return false;
                }
               
            }
            return false;
        }
        private bool IsValidString(HintText text)
        {
            string txt = text.Text;
            if (txt.Trim().Length > 0 && !txt.Equals(text.Hint))
            {
                return true;
            }
            return false;
        }
       
  
        public bool IsDesarrolladoraValid()
        {
            try
            {
                Desarrolladoras d = cbxDesarrolladoras.SelectedItem as Desarrolladoras;
                if (d != null)
                {
                    return true;
                }
            }
            catch (Exception e)
            {
                alertDesarrolladora.SetErrorMessage("Dato Erroneo "+e.Message);
                return false;
            }
            return false;
        }
        public bool IsNameValid()
        {
            string name = txtName.Text;
            if (name.Trim().Length > 0 && !name.Equals(txtName.Hint))
            {
                Productos p = _servicioProductos.Get("Nombre='" + name + "'");
                if (p == null)
                {
                    return true;
                }
                else
                {
                    alertNombre.SetErrorMessage("Ya existe un juego con este nombre");
                }

            }
            else
            {
                alertNombre.SetErrorMessage("No puede dejar este valor vacio");
            }
            return false;
        }
        private void txtCompra_TextChanged(object sender, EventArgs e)
        {
            comprobarTxt(txtCompra, alertCompra);
        }

        private void comprobarTxt(HintText txtBox, AlertPictureBox alert)
        {
            string txt = txtBox.Text;
            if (txt.Trim().Length > 0 && !txt.Equals(txtBox.Hint))
            {
                try
                {

                    Decimal d = Convert.ToDecimal(txt);
                    alert.isCorrect();
                }
                catch (FormatException)
                {
                    alert.SetErrorMessage("Formato incorrecto");
                }
            }
            else if (txt.Equals(txtBox.Hint))
            {
                alert.Visible = false;
            }
            else
            {
                alert.Visible = false;
            }
        }

        private void txtCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.NumerosDecimales(e);
        }

        private void txtPrecioVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.NumerosDecimales(e);
        }

        private void txtPrecioVenta_TextChanged(object sender, EventArgs e)
        {
            comprobarTxt(txtPrecioVenta, alertPrecioVenta);
        }
        private void ChargeChexboxByString(HintText hintText, int n)
        {
            string search = hintText.Text;
            if (!search.Equals(hintText.Hint))
            {
                if (n == 0)
                {
                    LoadIdiomas(hintText.Text);
                }
                else if (n == 1)
                {
                    LoadGeneros(hintText.Text);
                }
                else
                {
                    LoadPlataformas(hintText.Text);
                }
            }
        }
        private void txtSearchIdiomas_TextChanged(object sender, EventArgs e)
        {
            ChargeChexboxByString(txtSearchIdiomas, 0);

        }

        private void txtSearchGeneros_TextChanged(object sender, EventArgs e)
        {
            ChargeChexboxByString(txtSearchGeneros, 1);
        }

        private void txtSearchPlataformas_TextChanged(object sender, EventArgs e)
        {
            ChargeChexboxByString(txtSearchPlataformas, 2);

        }


        private void cbxDesarrolladoras_TextChanged(object sender, EventArgs e)
        {
            string text = cbxDesarrolladoras.Text;

            Desarrolladoras d = _servicioDesarrolladoras.Get("Nombre='" + text + "'");
            if (d != null)
            {
                alertDesarrolladora.isCorrect();

            }
            else
            {
                alertDesarrolladora.SetErrorMessage("La de desarrolladora no existe , para ingresar una nueva desarrolladora ingresela en ajuste");
            }
        }

        private void cbxClasificaciones_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
