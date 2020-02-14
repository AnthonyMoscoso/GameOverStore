using Nucleo.Entidades.Enumerados;
using System;

namespace Nucleo.Entidades
{
    public class BaseEntidad
    {
        public DateTime Creado { get; set; }
        public EstadoDeFila Estado { get; set; }
    }
}
