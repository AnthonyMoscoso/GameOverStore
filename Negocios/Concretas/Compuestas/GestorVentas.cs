using AccesoDatos.Abstractas;
using Entitidades.Concretas;
using Negocios.Abstractas.Compuestas;
using Nucleo.Negocios.Concreto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios.Concretas.Compuestas
{
    class GestorVentas : BaseServicio<Ventas>, IServicioVentas
    {
        public GestorVentas(IVentasDal VentasDal) : base(VentasDal)
        {

        }
    }
}
