using Entitidades.Concretas;
using Nucleo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitidades.Lineas
{
    public class LineaVentas :IEntidad 
    {
        public int Id { get; set; }
        public Productos Productos { get; set; }
        public int Cantidad { get; set; }
        public Decimal Precio { get; set; }

        public override bool Equals(Object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                LineaVentas p = (LineaVentas)obj;
                return (Productos == p.Productos);
            }
        }
        public Decimal GetPrecioTotal()
        {
            return Cantidad * Precio;
        }
        public LineaVentas GetLineaForProduto(List<LineaVentas> lineas) 
        {
            foreach(LineaVentas linea in lineas)
            {
                if(linea.Productos == Productos)
                {
                    return linea;
                }
            }
            return null;
        }
    }
}
