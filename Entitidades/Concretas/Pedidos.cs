using Entitidades.Lineas;
using Nucleo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitidades.Concretas
{
    public class Pedidos :IEntidad
    {
        public int Id { get; set; }
        public Usuarios Usuarios { get; set; }
        public DateTime FechaPedido { get; set; }
        public bool IsPagado { get; set; }
        public List<LineaPedidos> LineaPedidos { get; set; }
    }
}
