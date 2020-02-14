using AccesoDatos.Abstractas;
using AccesoDatos.Abstractas.ASimples;
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
    public class DapGenerosDal : DapBaseRepositorioEntitidad<Generos, DapperContexto>, IGenerosDal
    {
       
        public DapGenerosDal() : base(
            tableName: "Generos",
            colums: "Id,Nombre,Descripcion,Imagen",
            parameters: "@Id,@Nombre,@Descripcion,@Imagen")
        {

        }

        public List<Generos> GetGenerosByIdProducto(int Id)
        {
            var sql = " select * from Generos WHERE Generos.Id  in (select ProductoGeneros.Id_Generos from ProductoGeneros where ProductoGeneros.id_Productos = @id) ; ";
            List<Generos> generos = connection.Query<Generos>(sql, new { id = Id }).ToList();
            return generos;
        }
    }
}
