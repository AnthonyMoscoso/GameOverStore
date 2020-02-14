using AccesoDatos.Abstractas.ASimples;
using Entitidades.Simples;
using Nucleo.AccesoDatos.Concretos.Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Concretas.Dapper.Simples
{
    public class DapClasificacionesDal : DapBaseRepositorioEntitidad<Clasificaciones, DapperContexto>, IClasificacionesDal
    {
        public DapClasificacionesDal() : base(
            tableName: "Clasificaciones",
            colums: "Id,Nombre,Valor,Imagen",
            parameters: "@Id,@Nombre,@Valor,@Imagen")
        {

        }
    }
}
