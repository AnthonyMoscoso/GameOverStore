using AccesoDatos.Abstractas.Lineas;
using Entitidades.Lineas;
using Negocios.Abstractas.Lineas;
using Nucleo.Negocios.Concreto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios.Concretas.Lineas
{
    class GestorLineaVentas : BaseServicio<LineaVentas>, IServicioLineaVentas
    {
        public GestorLineaVentas(ILineaVentasDal LineaVentasDal) : base(LineaVentasDal)
        {

        }
    }
}
