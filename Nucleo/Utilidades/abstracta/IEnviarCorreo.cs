using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nucleo.Utilidades.abstracta
{
    public interface IEnviarCorreo
    {
        static void Enviar(string email,string codigo);
    }
}
