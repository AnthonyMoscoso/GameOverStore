using AccesoDatos.Abstractas.ASimples;
using Entitidades.Simples;
using Negocios.Abstractas.Simples;
using Nucleo.Negocios.Concreto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios.Concretas.Simples
{
    public class GestorDesarrolladoras : BaseServicio<Desarrolladoras>, IServicioDesarrolladoras
    {
        public GestorDesarrolladoras(IDesarrolladorasDal DesarrolladorasDal) : base(DesarrolladorasDal)
        {

        }
    }
}
