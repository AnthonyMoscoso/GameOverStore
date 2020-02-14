using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nucleo.Utilidades.abstracta
{
    public interface IPaginador
    {
        void PaginaSigiente();
        void PaginaAnterior();
        void CambiaTamañoPagina(int num);
        void CambiaTotalRegistros(int num);

        int ObtenerOFFSET();
        int ObtenerFETCH();
        int ObtenerTotal();
        int ObtenerTamPag();

    }
}
