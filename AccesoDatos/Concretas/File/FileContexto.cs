using Nucleo.AccesoDatos.Abstractas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Concretas.File
{

    public class FileContexto : IContexto
    {
        public string CadenaConexion { get; set; }
        public FileContexto()
        {
            CadenaConexion = @"datos";
        }
    }
}
