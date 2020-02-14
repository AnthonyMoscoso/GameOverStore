using Entitidades.Concretas;
using Entitidades.Simples;
using Negocios.Abstractas.Simples;
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
    public partial class VentanaEditAjustes : Form
    {
        IServicioPlataformas _servicioPlataformas;
        IServicioClasificaciones _servicioClasificaciones;
        IServicioDesarrolladoras _servicioDesarrolladoras;
        IServicioGeneros _servicioGeneros;
        IServicioIdiomas _servicioIdiomas;
        public delegate void backAjuste();
        public backAjuste _backAjuste;
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
        }

        public void adapter_sendDatos(int id,Image image , List<string>datos)
        {
            lbId.Text = id.ToString();
            pictureBox1.Image = image;
            txtNombre.Text = datos[0];
            if (datos.Count > 1)
            {
                hintText3.Text = datos[1];
            }
        }
        private void VentanaEditAjustes_Load(object sender, EventArgs e)
        {
            if (VentanaPrincipal.Codigo == 1)
            {
                List < Plataformas > List = _servicioPlataformas.GetAll();
                foreach(Plataformas p in List)
                {
                    AdapterAjuster a = new AdapterAjuster(p);
                    a._sendDatos += adapter_sendDatos;
                    pnContenedor.Controls.Add(a);
                }
            }
            else if (VentanaPrincipal.Codigo == 2)
            {
                List<Generos> List = _servicioGeneros.GetAll();
                foreach (Generos p in List)
                {
                    AdapterAjuster a = new AdapterAjuster(p);
                    a._sendDatos += adapter_sendDatos;
                    pnContenedor.Controls.Add(a);
                }
            }
            else if (VentanaPrincipal.Codigo == 3)
            {
                List<Clasificaciones> List= _servicioClasificaciones.GetAll();
                foreach (Clasificaciones p in List)
                {
                    AdapterAjuster a = new AdapterAjuster(p);
                    a._sendDatos += adapter_sendDatos;
                    pnContenedor.Controls.Add(a);
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
                }
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            if (_backAjuste != null)
            {
                _backAjuste();
            }
        }
    }
}
