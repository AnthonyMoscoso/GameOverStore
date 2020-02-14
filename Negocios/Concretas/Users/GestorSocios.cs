using AccesoDatos.Abstractas;
using Entitidades.Concretas;
using Negocios.Abstractas;
using Nucleo.Negocios.Concreto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios.Concretas
{
    public class GestorSocios : BaseServicio<Socios>, IServicioSocios
    {
        public GestorSocios(ISociosDal sociosDal) : base(sociosDal)
        {

        }

        public bool EliminarPersona(int id)
        {
            bool dev=true;
            Socios ant = GetById(id);
            if (ant != null)
                Delete(ant);
            else
                dev = false;
            return dev;
        }
    }
}
