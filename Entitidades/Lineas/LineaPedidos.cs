using Entitidades.Concretas;
using Nucleo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitidades.Lineas
{
    public class LineaPedidos : IEntidad 
    {
        public int Id { get; set; }
        public Productos Productos { get; set; }
        public int Cantidad { get; set; }
        public Decimal Precio { get; set; }

     
    }
}
