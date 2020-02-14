using AccesoDatos.Abstractas.AUsuario;
using Entitidades.Users;
using Negocios.Abstractas.Users;
using Nucleo.Negocios.Concreto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios.Concretas.Users
{
    public class GestorPersonas : BaseServicio<Personas>, IServicioPersona
    {
        public GestorPersonas(IPersonasDal PersonasDal) : base(PersonasDal)
        {

        }
    }
   
}
