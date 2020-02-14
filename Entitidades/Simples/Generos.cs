using Nucleo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitidades.Concretas
{
    public class Generos : IEntidad,IEquatable<Generos>
    {
        public int Id { get ; set ; }
        public string Nombre { get ; set; }
        public string Imagen { get; set; }
        public string Descripcion{ get; set; }
        public override bool Equals(Object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                Generos p = (Generos)obj;
                return (Nombre == p.Nombre);
            }
        }

        public bool Equals(Generos other)
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
