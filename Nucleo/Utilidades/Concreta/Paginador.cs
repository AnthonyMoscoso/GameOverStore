using Nucleo.Utilidades.abstracta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nucleo.Utilidades.Concreta
{
    public class Paginador : IPaginador
    {
        private int _total;
        private int _numElementosPag;
        private int _actualPag;
        private int _totalPag;
        private int _OFFSET;
        private int _FECTH;
        public Paginador( int total, int numElementosPag = 10) {
            _total = total;
            _numElementosPag = numElementosPag;
            _actualPag = 1;
            _totalPag =(int) Math.Ceiling((double)_total / _numElementosPag);
            _FECTH = _numElementosPag;
            _OFFSET = 0;
        }
        public void CambiaTamañoPagina(int num)
        {
            if(num>=1 && num<= _totalPag){ 
                _actualPag = num;
                _OFFSET = (num - 1) * _numElementosPag;
            }
        }

        public void CambiaTotalRegistros(int num)
        {
            throw new NotImplementedException();
        }

        public int ObtenerFETCH()
        {
            return _numElementosPag;
        }

        public int ObtenerOFFSET()
        {
            return _OFFSET;
        }

        public int ObtenerTamPag()
        {
            throw new NotImplementedException();
        }

        public int ObtenerTotal()
        {
            throw new NotImplementedException();
        }

        public void PaginaAnterior()
        {
            if (_actualPag > 1)
            {
                _actualPag--;
                _OFFSET =( _actualPag -1)* _numElementosPag;
            }
        }

        public void PaginaSigiente()
        {
           if(_actualPag< _totalPag)
            {
                _OFFSET = _actualPag * _numElementosPag;
                _actualPag++;
            }
        }
    }
}
