using AccesoDatos.Abstractas.Simples;
using Dapper;
using Entitidades.Concretas;
using Nucleo.AccesoDatos.Concretos.Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Concretas.Dapper
{
    public class DapPermisosDal : DapBaseRepositorioEntitidad<Permisos, DapperContexto>, IPermisosDal
    {
        public DapPermisosDal() : base(
            tableName: "Permisos",
            colums: "Nombre",
            parameters: "@Nombre")
        {

        }
        public List<Permisos> GetPermisosByIdUsuario(int Id)
        {
            var sql = " select * from Permisos WHERE Permisos.Id  in (select UsuarioPermisos.id_Permiso from UsuarioPermisos where UsuarioPermisos.id_Usuario = @id) ; ";
            List<Permisos> permisos = connection.Query<Permisos>(sql, new { id = Id }).ToList();
            return permisos;
        }
    }
}
