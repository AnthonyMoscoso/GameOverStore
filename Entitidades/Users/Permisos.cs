using Nucleo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitidades.Concretas
{
    public class Permisos :BaseEntidad , IEntidad ,IEquatable<Permisos>
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public override bool Equals(Object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                Permisos p = (Permisos)obj;
                return (Name == p.Name);
            }
        }

        public bool Equals(Permisos other)
        {
            if (other == null)
                return false;

            if (this.Name == other.Name)
                return true;
            else
                return false;
        }
        public override int GetHashCode()
        {
            return this.Name.GetHashCode();
        }
    }
}
