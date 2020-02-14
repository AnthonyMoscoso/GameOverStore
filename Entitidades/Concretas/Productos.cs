using Entitidades.Simples;
using Nucleo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitidades.Concretas
{
    public class Productos :BaseEntidad ,IEntidad { 
        public int Id { get; set; }
        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        public string Introduccion { get; set; }
        public Clasificaciones Clasificacion { get; set; }

        private int clas_id;
        public int Clasificacion_id { get
            {
                return Clasificacion != null ? Clasificacion.Id : clas_id;
            }
            set { clas_id = value; }
        }
        private int des_id;

        public DateTime Fecha { get; set; }
        public Desarrolladoras Desarrolladora { get; set; }

        public int Desarrolladora_id {
            get
            {
                return Desarrolladora != null ? Desarrolladora.Id : des_id;
            }
            set { des_id = value; }
        }
        public Decimal Precio_Compra { get; set; }
        public Decimal Precio_Venta { get; set; }
        public int Descuento { get; set; }
        public string Imagen_Horizontal { get; set; }
        public string Imagen_Vertical { get; set; }
        public string Imagen_Logo { get; set; }

        public int Multijugador { get; set; }

        public List<Idiomas> Idiomas { get; set; }

        public List<Plataformas> Plataformas { get; set; }

        public List<Generos> Generos { get; set; }

        public string Url { get; set; }
        public override bool Equals(Object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                Productos p = (Productos)obj;
                return (Nombre == p.Nombre);
            }
        }

        public bool Equals(Productos other)
        {
            if (other == null)
                return false;

            if (this.Nombre == other.Nombre)
                return true;
            else
                return false;
        }
        public override int GetHashCode()
        {
            return this.Nombre.GetHashCode();
        }
    }
}
