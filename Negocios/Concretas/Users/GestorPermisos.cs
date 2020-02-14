using AccesoDatos.Abstractas.Simples;
using Entitidades.Concretas;
using Negocios.Abstractas.Users;
using Nucleo.Negocios.Concreto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios.Concretas.Users
{
    public class GestorPermisos : BaseServicio<Permisos>, IServicioPermisos
    {
        public GestorPermisos(IPermisosDal PermisosDal) : base(PermisosDal)
        {

        }
    }
}
