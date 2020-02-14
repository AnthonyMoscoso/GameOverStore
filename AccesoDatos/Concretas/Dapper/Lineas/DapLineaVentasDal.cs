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
    public class DapLineaVentasDal : DapBaseRepositorioEntitidad<LineaVentas, DapperContexto>, ILineaVentasDal
    {
        public DapLineaVentasDal() : base(
            tableName: "LineaVenta",
            colums: "Id,Id_Producto,Id_Venta,Cantidad,Precio",
            parameters: "@Id,@Id_Producto,@Id_Venta,@Cantidad,@Precio")
        {

        }
    }
    
}
