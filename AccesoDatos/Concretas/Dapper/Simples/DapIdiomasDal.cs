using AccesoDatos.Abstractas.Simples;
using Dapper;
using Entitidades.Concretas;
using Nucleo.AccesoDatos.Concretos.Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Concretas.Dapper.Simples
{
    public class DapIdiomasDal: DapBaseRepositorioEntitidad<Idiomas, DapperContexto>, IIdiomasDal
    {
        public DapIdiomasDal() : base(
            tableName: "Idiomas",
            colums: "Id,Nombre,Imagen",
            parameters: "@Id,@Nombre,@Imagen")
        {

        }
        public List<Idiomas> GetIdiomasByIdProducto(int Id)
        {
            var sql = " select * from Idiomas WHERE Idiomas.Id  in (select ProductoIdiomas.id_Idiomas from ProductoIdiomas where ProductoIdiomas.id_Productos = @id) ;";
            List<Idiomas> idiomas = connection.Query<Idiomas>(sql, new { id = Id }).ToList();
            return idiomas;
        }
    }
}
