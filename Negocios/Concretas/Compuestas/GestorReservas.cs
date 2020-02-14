using AccesoDatos.Abstractas.Compuestas;
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
    class GestorReservas : BaseServicio<Reservas>, IServicioReservas
    {
        public GestorReservas(IReservasDal ReservasDal) : base(ReservasDal)
        {

        }
    }
}
