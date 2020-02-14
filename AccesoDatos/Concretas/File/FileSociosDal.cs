using AccesoDatos.Abstractas;
using Entitidades.Concretas;
using Nucleo.AccesoDatos.Concretos.Fichero;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Concretas.File
{
    public class FileSociosDal: FileBaseRepositorioEntidad<Socios, FileContexto>, ISociosDal
    {
        public FileSociosDal()
            : base( nombre_fichero: "Persona.txt",
                columnas: "Id,Nombre,Apellido",
                separador: ',')
        {

        }
    }
}
