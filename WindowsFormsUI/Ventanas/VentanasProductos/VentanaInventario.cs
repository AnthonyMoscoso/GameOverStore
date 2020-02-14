using Entitidades.Concretas;
using Negocios.Abstractas.Compuestas;
using Negocios.Abstractas.Simples;
using Negocios.Abstractas.Users;
using Nucleo.Utilidades.Concreta;
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
        Paginador pag;
        public delegate void ShowProducto(Productos productos);
        public event ShowProducto showProducto;
       /*- private int CardPorPagina = 2;
        private int Saltos = 3;*/

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
            this.pnBusqueda1._DinamicSearch += Busqueda_Dinamica;
            this.pnBusqueda1._EnviarTexto += Busqueda_Especifica;
            pag = new Paginador(_servicioProductos.Count());
            CargarCardViewProductos(null);
      

        }
        private void Busqueda_Dinamica(string texto)
        {
            Search("Nombre Like '" + texto+"%'");
        }
        private void Busqueda_Especifica(string texto)
        {
            Search("Nombre='" + texto+"'");
        }
        public void CargarCardViewProductos(string query)
        {
            pag.PaginaSigiente();
            List<Productos> productos;
            if (query != null)
            {
                productos = _servicioProductos.GetPaginate(query, pag.ObtenerOFFSET(), pag.ObtenerOFFSET());
               
            }
            else
            {
                productos = _servicioProductos.GetPaginate(0, 10);
            }
           
            foreach (Productos p in productos)
            {
                p.Desarrolladora = _servicioDesarrolladoras.GetById(p.Desarrolladora_id);
                
                CardViewProductos cardControls = new CardViewProductos(p);
                pnContainerElements.Controls.Add(cardControls);
                cardControls.showPanel += CardControls_showPanel;
            }
        }

        private void CardControls_showPanel(Productos productos)
        {
            showProducto?.Invoke(productos);
        }

        private void btnOpenClosePlataformas_Click(object sender, EventArgs e)
        {

        }

        private void CargarAdapterViewProductos(string query)
        {
            ViewList.Enabled = false;
            pnContainerElements.Controls.Clear();
            List<Productos> productos;
            if (query != null)
            {
                productos = _servicioProductos.GetPaginate(query, 0, 10);

            }
            else
            {
                productos = _servicioProductos.GetPaginate(0, 10);
            }

            foreach (Productos p in productos)
            {
                p.Desarrolladora = _servicioDesarrolladoras.GetById(p.Desarrolladora_id);
                AdapterViewProductos cardControls = new AdapterViewProductos(p);
                pnContainerElements.Controls.Add(cardControls);
                cardControls.showPanel += CardControls_showPanel;
                cardControls.Width = pnContainerElements.Width - 8;
            }
        }
        private void ViewList_Click(object sender, EventArgs e)
        {
            CargarAdapterViewProductos(null);
            
        }

      
        public void Search(string busqueda)
        {
            CargarAdapterViewProductos(busqueda);
        }

        private void ViewCard_Click(object sender, EventArgs e)
        {
            ViewCard.Enabled = false;
        }
    }
}
