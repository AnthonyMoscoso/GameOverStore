using AccesoDatos.Abstractas;
using Entitidades.Concretas;
using Nucleo.AccesoDatos.Concretos.Dapper;

namespace AccesoDatos.Concretas.Dapper
{
    public class DapUsuarioDal : DapBaseRepositorioEntitidad<Usuarios, DapperContexto>, IUsuarioDal
    {
        public DapUsuarioDal() : base(
            tableName: "Usuarios",
            colums: "Id,Pin,FechaContratacion,Descuento",
            parameters: "@Id,@Pin,@FechaContratacion,@Descuento")
        {

        }

        
    }
}
