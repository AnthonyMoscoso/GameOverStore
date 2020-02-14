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
    public class DapDevolucionesDal : DapBaseRepositorioEntitidad<Devoluciones, DapperContexto>, IDevolucionesDal
    {
        public DapDevolucionesDal() : base(
            tableName: "Devoluciones",
            colums: "Id,Id_LineaDeVenta,Cantidad,Id_Usuario,Id_Socio,FechaDevolucion",
            parameters: "@Id,@IdLineaDeVenta,@Cantidad,@IdUsuario,@IdSocio,@FechaDevolucion")
        {

        }
    }
}
