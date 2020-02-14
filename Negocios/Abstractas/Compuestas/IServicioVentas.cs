using Entitidades.Concretas;
using Nucleo.Negocios.Abstracta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios.Abstractas.Compuestas
{
    public interface IServicioVentas : IServicio <Ventas>
    {
    }
}
