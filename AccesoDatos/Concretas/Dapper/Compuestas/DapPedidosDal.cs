using AccesoDatos.Abstractas;
using AccesoDatos.Abstractas.Compuestas;
using Entitidades.Concretas;
using Nucleo.AccesoDatos.Concretos.Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Concretas.Dapper.Compuestas
{
    public class DapPedidosDal : DapBaseRepositorioEntitidad<Pedidos, DapperContexto>, IPedidosDal
    {

        public DapPedidosDal() : base(
            tableName: "Pedidos",
            colums: "Id_Usuario,FechaPedido,Pagado",
            parameters: "@Id_Usuario ,@FechaPedido ,@Pagado")
        {

        }
    }
}
