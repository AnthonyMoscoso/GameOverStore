using AccesoDatos.Abstractas.Simples;
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
    public class GestorPlataformas : BaseServicio<Plataformas>, IServicioPlataformas
    {
        IPlataformasDal _PlataformasDal;
        public GestorPlataformas(IPlataformasDal PlataformasDal) : base(PlataformasDal)
        {
            _PlataformasDal = PlataformasDal;
        }

        public List<Plataformas> GetPlataformasByIdProducto(int Id)
        {
            return _PlataformasDal.GetPlataformasByIdProducto(Id);
        }
    }
}
