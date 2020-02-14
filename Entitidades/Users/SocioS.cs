using Entitidades.Users;
using Nucleo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitidades.Concretas
{
    public class Socios :Personas,IEntidad ,IEquatable<Socios>
    { 
    
        public string Dni { get; set; }
        public Decimal Descuento { get; set; }     

        public override bool Equals(Object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                Socios p = (Socios)obj;
                return (Email == p.Email);
            }
        }

        public bool Equals(Socios other)
        {
            throw new NotImplementedException();
        }

        public override int GetHashCode()
        {
            return this.Email.GetHashCode();
        }

    }
}
