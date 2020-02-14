using Entitidades.Users;
using Nucleo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitidades.Concretas
{
    public class Usuarios : Personas, IEntidad
    {
        public string Pin { get; set; }
        public DateTime FechaContratacion { get; set; }
        public List<Permisos> Permisos { get; set; }

        public int Descuento
        {
            get
            {
                return 15;
            }
        }
    }
}
