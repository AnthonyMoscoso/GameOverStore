using Entitidades.Concretas;
using Nucleo.Negocios.Abstracta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios.Abstractas.Users
{
    public interface IServicioPermisos : IServicio<Permisos>
    {
        List<Permisos> GetPermisosByIdUsuario(int Id);
    }
}
