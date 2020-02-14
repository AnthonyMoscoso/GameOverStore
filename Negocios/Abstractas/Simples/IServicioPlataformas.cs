using Entitidades.Simples;
using Nucleo.Negocios.Abstracta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios.Abstractas.Simples
{
    public interface IServicioPlataformas : IServicio<Plataformas>
    {
        List<Plataformas> GetPlataformasByIdProducto(int Id);
    }
}
