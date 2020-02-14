using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Nucleo.AccesoDatos.Concretos.Fichero
{
    public static class FileConnectionExtensions
    {
        public static Object ConvertirDato(PropertyInfo tipo, String dato)
        {
            switch (tipo.PropertyType.Name)
            {
                case "Int32":
                    return Int32.Parse(dato);
                case "Single":
                    return Convert.ToSingle(dato);
                default:
                    return dato.ToString();
            }
        }
    }
}
