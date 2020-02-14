using Entitidades.Concretas;
using Negocios.Abstractas.Compuestas;
using Negocios.Abstractas.Simples;
using Negocios.Abstractas.Users;
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
    public partial class VentanaInventario : Form
    {
        IServicioProductos _servicioProductos;
        IServicioClasificaciones _servicioClasificaciones;
        IServicioDesarrolladoras _servicioDesarrolladoras;
        IServicioPlataformas _servicioPlataformas;
        IServicioIdiomas _servicioIdiomas;
        IServicioGeneros _ServicioGeneros;
        
        public delegate void ShowProducto(Productos productos);
        public event ShowProducto showProducto;

        public VentanaInventario(IServicioProductos servicioProductos, IServicioIdiomas servicioIdiomas
            , IServicioDesarrolladoras servicioDesarrolladoras, IServicioGeneros servicioGeneros
            , IServicioPlataformas servicioPlataformas ,IServicioClasificaciones servicioClasificaciones)
        {
            _servicioProductos = servicioProductos;
            _servicioClasificaciones = servicioClasificaciones;
            _servicioIdiomas = servicioIdiomas;
            _servicioPlataformas = servicioPlataformas;
            _servicioDesarrolladoras = servicioDesarrolladoras;
            _ServicioGeneros = servicioGeneros;
            InitializeComponent();
            CargarProductos();
        }
        public void CargarProductos()
        {
            List<Productos> productos = _servicioProductos.GetAll();
            foreach(Productos p in productos) 
            {

                /*p.Clasificacion = _servicioClasificaciones.GetById(p.Clasificacion_id);
               
                p.Idiomas = _servicioIdiomas.GetIdiomasByIdProducto(p.Id);
                p.Plataformas = _servicioPlataformas.GetPlataformasByIdProducto(p.Id);
                p.Generos = _ServicioGeneros.GetGenerosByIdProducto(p.Id);*/
                p.Desarrolladora = _servicioDesarrolladoras.GetById(p.Desarrolladora_id);
                ProductosCardControl cardControls = new ProductosCardControl(p);
                pnContainerElements.Controls.Add(cardControls);
                cardControls.showPanel += CardControls_showPanel;
            }
        }

        private void CardControls_showPanel(Productos productos)
        {
            if (showProducto != null)
            {
                showProducto(productos);
            }
        }

        private void btnOpenClosePlataformas_Click(object sender, EventArgs e)
        {

        }
    }
}
