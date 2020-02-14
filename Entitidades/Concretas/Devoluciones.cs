using Entitidades.Lineas;
using Nucleo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitidades.Concretas
{
    public class Devoluciones : IEntidad
    {
        public int Id { get; set; }
        public int Cantidad { get; set; }
        public DateTime FechaDevolucion { get; set; }
        public Socios Socios { get; set; }
        public Usuarios Usuarios { get; set; }
        public LineaVentas LineaVentas{get;set;}
    }
}
