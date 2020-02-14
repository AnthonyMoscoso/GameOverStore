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
    public class DapReservasDal : DapBaseRepositorioEntitidad<Reservas, DapperContexto>, IReservasDal
    {
        public DapReservasDal() : base(
            tableName: "Reservas",
            colums: "Id_Persona,Id_Usuario,Id_Producto,Id_Venta,Cantidad,Precio,FechaReserva",
            parameters: "@Id_Persona,@Id_Usuario,@Id_Producto,@Id_Venta,@Cantidad,@Precio,@FechaReserva")
        {

        }
    }
}
