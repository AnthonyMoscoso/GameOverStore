using AccesoDatos.Abstractas.Simples;
using Entitidades.Concretas;
using Nucleo.AccesoDatos.Concretos.Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Concretas.Dapper
{
    public class DapPermisosDal : DapBaseRepositorioEntitidad<Permisos, DapperContexto>, IPermisosDal
    {
        public DapPermisosDal() : base(
            tableName: "Permisos",
            colums: "Id,Nombre",
            parameters: "@Id,@Nombre")
        {

        }
    }
}
