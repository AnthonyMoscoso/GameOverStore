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
    public class GestorDevoluciones :BaseServicio<Devoluciones> ,IServicioDevoluciones
    {
        public GestorDevoluciones(IDevolucionesDal DevolucionesDal) : base(DevolucionesDal)
        {

        }
    }
}
