using AccesoDatos.Abstractas.Simples;
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
    public class GestorIdiomas : BaseServicio<Idiomas>, IServicioIdiomas
    {
        public IIdiomasDal _idiomasDal;
        public GestorIdiomas(IIdiomasDal IdiomasDal) : base(IdiomasDal)
        {
            _idiomasDal = IdiomasDal;
        }

        public List<Idiomas> GetIdiomasByIdProducto(int Id)
        {
            return _idiomasDal.GetIdiomasByIdProducto(Id);
        }
    }
}
