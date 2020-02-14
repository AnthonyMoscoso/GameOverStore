using Nucleo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entitidades.Simples
{
    public class Desarrolladoras :IEntidad 
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Imagen { get; set; }
        public override string ToString()
        {
            return Nombre;
        }
    }
}
