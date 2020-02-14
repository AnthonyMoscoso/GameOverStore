using AccesoDatos.Abstractas.Lineas;
using Entitidades.Lineas;
using Nucleo.AccesoDatos.Concretos.Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Concretas.Dapper.Lineas
{
    public class DapLineaPedidosDal : DapBaseRepositorioEntitidad<LineaPedidos, DapperContexto>, ILineaPedidosDal
    {
        public DapLineaPedidosDal() : base(
            tableName: "LineaPedidos",
            colums: "Id_Producto,Id_Pedido,Cantidad,Precio",
            parameters: "@Id_Producto,@Id_Pedido,@Cantidad,@Precio")
        {

        }
    
    }
}
