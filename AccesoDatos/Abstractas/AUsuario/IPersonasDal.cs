using Entitidades.Users;
using Nucleo.AccesoDatos.Abstractas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Abstractas.AUsuario
{
    public interface IPersonasDal : IRepositorioEntidad<Personas>
    {
    }
}
