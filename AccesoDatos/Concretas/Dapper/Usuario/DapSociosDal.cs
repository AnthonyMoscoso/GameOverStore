using AccesoDatos.Abstractas;
using Entitidades.Concretas;
using Nucleo.AccesoDatos.Concretos.Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Concretas.Dapper.Usuario
{
    public class DapSociosDal: DapBaseRepositorioEntitidad<Socios, DapperContexto>, ISociosDal
    {
        public DapSociosDal() : base(
            tableName: "Socios",
            colums: "Id,Dni,Descuento",
            parameters: "@Id,@Dni,@Descuento")
        {

        }
    }
}
