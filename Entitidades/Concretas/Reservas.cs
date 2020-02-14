using Entitidades.Users;
using Nucleo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitidades.Concretas
{
    public class Reservas :IEntidad
    {
        public int Id { get; set; }
        public Usuarios Usuarios { get; set; }
        public Personas Personas { get; set; }
        public int Id_Persona
        {
            get
            {
                return Personas.Id;
            }
        }
        public int Id_Producto
        {
            get
            {
                return Productos.Id;
            }
        }
        public int Id_Venta
        {
            get
            {
                return Ventas.Id;
            }
        }
       
        public int Id_Usuario
        {
            get
            {
                return Usuarios.Id;
            }
        }
        public Productos Productos { get; set; }
        public Ventas Ventas { get; set; }
        public int Cantidad { get; set; }
        public Decimal Precio { get; set; }
        public DateTime FechaReserva { get; set; }
    }
}
