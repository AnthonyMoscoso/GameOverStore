using AccesoDatos.Abstractas;
using AccesoDatos.Abstractas.ASimples;
using Entitidades.Concretas;
using Negocios.Abstractas.Simples;
using Nucleo.Negocios.Concreto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios.Concretas.Simples
{
    public class GestorGeneros : BaseServicio<Generos>, IServicioGeneros
    {
        IGenerosDal _GenerosDal;
        public GestorGeneros(IGenerosDal GenerosDal) : base(GenerosDal)
        {
            _GenerosDal = GenerosDal;
        }

        public List<Generos> GetGenerosByIdProducto(int Id)
        {
            return _GenerosDal.GetGenerosByIdProducto(Id);
        }
    }
}
