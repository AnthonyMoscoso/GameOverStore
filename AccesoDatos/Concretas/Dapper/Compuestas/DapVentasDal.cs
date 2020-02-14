using AccesoDatos.Abstractas;
using Entitidades.Concretas;
using Nucleo.AccesoDatos.Concretos.Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Concretas.Dapper.Compuestas
{
    public class DapVentasDal : DapBaseRepositorioEntitidad<Ventas, DapperContexto>, IVentasDal
    {

        public DapVentasDal() : base(
            tableName: "Ventas",
            colums: "Id,FechaVenta,Pagado,Id_Usuario,Id_Persona",
            parameters: "@Id,@FechaVenta,@Pagado,@Id_Usuario,@Id_Persona")
        {

        }
    }
}
