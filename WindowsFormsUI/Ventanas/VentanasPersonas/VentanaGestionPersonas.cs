using Entitidades.Concretas;
using Entitidades.Users;
using Negocios.Abstractas;
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
using WindowsFormsUI.Eventos;

namespace WindowsFormsUI.Ventanas.VentanasPersonas
{
    public partial class VentanaGestionPersonas : Form
    {
        IServicioPersona _IservicioPersona;
        IServicioUsuarios _ServicioUsuarios;
        IServicioSocios _servicioSocios;

        List<Usuarios> List_Usuarios;
        List<Socios> List_Socios;
        public VentanaGestionPersonas(IServicioPersona servicioPersona, IServicioUsuarios servicioUsuarios,IServicioSocios servicioSocios)
        {
            
            InitializeComponent();
            _IservicioPersona = servicioPersona;
            _ServicioUsuarios = servicioUsuarios;
            List_Usuarios = _ServicioUsuarios.GetAllUsuarios();
            LoadCardUsuarios();
            
        }

        private void LoadCardUsuarios()
        {
            pnContainer.Controls.Clear();
            foreach (Usuarios p in List_Usuarios)
            {
                CardViewPersona card = new CardViewPersona(p);
                pnContainer.Controls.Add(card);
               
            }
            fomrPaginador1.MaxPaginas = 5;

        }
      
        private void LoadAdapterUsuarios()
        {
            pnContainer.Controls.Clear();
            foreach (Usuarios p in List_Usuarios)
            {
                AdapterViewPersonas card = new AdapterViewPersonas(p);
                card.Width = pnContainer.Width;
                pnContainer.Controls.Add(card);
                card.SendToDelete += Card_Delete;
                
             
            }
        }
        public void Card_Delete(Usuarios usuarios)
        {
            _IservicioPersona.Delete(usuarios);
            List_Usuarios.Remove(usuarios);
            LoadCardUsuarios();
        }

        private void ptbxCardView_Click(object sender, EventArgs e)
        {
            ptbxCardView.Enabled = false;
            ptbxListView.Enabled = true;
            LoadCardUsuarios();
        }

        private void ptbxListView_Click(object sender, EventArgs e)
        {
            ptbxListView.Enabled = false;
            ptbxCardView.Enabled = true;
            LoadAdapterUsuarios();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
