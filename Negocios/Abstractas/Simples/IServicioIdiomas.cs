using Entitidades.Concretas;
using Nucleo.Negocios.Abstracta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios.Abstractas.Simples
{
    public interface IServicioIdiomas : IServicio<Idiomas>
    {
        List<Idiomas> GetIdiomasByIdProducto(int Id);
    }
}
