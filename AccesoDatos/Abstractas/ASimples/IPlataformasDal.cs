using Entitidades.Simples;
using Nucleo.AccesoDatos.Abstractas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Abstractas.Simples
{
    public interface IPlataformasDal : IRepositorioEntidad<Plataformas>
    {
        List<Plataformas> GetPlataformasByIdProducto(int Id);
    }
}
