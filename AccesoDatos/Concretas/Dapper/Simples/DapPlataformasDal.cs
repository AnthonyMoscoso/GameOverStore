using AccesoDatos.Abstractas.Simples;
using Dapper;
using Entitidades.Simples;
using Nucleo.AccesoDatos.Concretos.Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Concretas.Dapper.Simples
{
    public class DapPlataformasDal : DapBaseRepositorioEntitidad<Plataformas, DapperContexto>, IPlataformasDal
    {
        public DapPlataformasDal() : base(
            tableName: "Plataformas",
            colums: "Nombre,Imagen",
            parameters: "@Nombre,@Imagen")
        {

        }
        public List<Plataformas> GetPlataformasByIdProducto(int Id)
        {
            var sql = " select * from Plataformas WHERE Plataformas.Id  in (select ProductoPlataformas.Id_Plataformas from ProductoPlataformas where ProductoPlataformas.id_Productos = @id );";
            List<Plataformas> plataformas = connection.Query<Plataformas>(sql, new { id = Id }).ToList();
            return plataformas;
        }
    }
}
