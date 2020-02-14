using Entitidades.Concretas;
using Nucleo.AccesoDatos.Abstractas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Abstractas.ASimples
{
    public  interface IGenerosDal : IRepositorioEntidad<Generos>
    {
        List<Generos> GetGenerosByIdProducto(int Id);
    }
}
