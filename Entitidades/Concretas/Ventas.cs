using Entitidades.Lineas;
using Entitidades.Users;
using Nucleo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitidades.Concretas
{
    public class Ventas :IEntidad
    {
        public int Id { get; set; }
        public DateTime FechaVenta { get; set; }
        public bool IsPagado { get; set; }
        public Usuarios Usuarios { get; set; }
        public int Id_Usuario
        {
            get
            {
                return Usuarios.Id;
            }
        }
        public Personas Personas { get; set; }
        public int Id_Persona
        {
            get
            {
                return Personas.Id;
            }
        }
        public List<LineaVentas> LineaVentas { get; set; }
    }
}
