using AccesoDatos.Abstractas;
using Dapper;
using Entitidades.Concretas;
using Nucleo.AccesoDatos.Concretos.Dapper;
using System.Collections.Generic;
using System.Transactions;
using System.Linq;

namespace AccesoDatos.Concretas.Dapper
{
    public class DapUsuarioDal : DapBaseRepositorioEntitidad<Usuarios, DapperContexto>, IUsuarioDal
    {
        public DapUsuarioDal() : base(
            tableName: "Usuarios",
            colums: "Id,Pin,FechaContratacion,Descuento",
            parameters: "@Id,@Pin,@FechaContratacion,@Descuento")
        {

        }
        public new Usuarios Delete(Usuarios entity)
        {
            using (var transaction = new TransactionScope())
            {

                string sql = "Delete from UsuarioPermisos where id_Permiso in (select id_Permiso from UsuarioPermisos where id_Usuario =@Id);";
                connection.Execute(sql, new { Id = entity.Id });
                transaction.Complete();
            }

            return null;
        }
        public new Usuarios Add(Usuarios entity)
        {
            Usuarios addedEntity;
            List<Permisos>list=entity.Permisos;
            addedEntity = base.Add(entity);
            using (var transaction = new TransactionScope())
            {
               
                string sql = "INSERT INTO UsuarioPermisos (id_Usuario,id_Permiso) Values (@id_Usuario,@id_Permiso);";
                foreach (Permisos i in list)
                {
                    connection.Execute(sql, new { id_Usuario =entity.Id, id_Permiso = i.Id });
                }
                transaction.Complete();
            }

            return addedEntity;
        }
        public new Usuarios Update(Usuarios entity)
        {
            Usuarios addedEntity;
            List<Permisos> list = entity.Permisos;
            addedEntity = base.Update(entity);
            using (var transaction = new TransactionScope())
            {

                string sql = "Delete from UsuarioPermisos where id_Permiso in (select id_Permiso from UsuarioPermisos where id_Usuario =@Id);";
                connection.Execute(sql, new { Id = entity.Id });
                string sqlInsert = "INSERT INTO UsuarioPermisos (id_Usuario,id_Permiso) Values (@id_Usuario,@id_Permiso);";
                foreach (Permisos i in list)
                {
                    connection.Execute(sqlInsert, new { id_Usuario = entity.Id, id_Permiso = i.Id });
                }
                transaction.Complete();
            }

            return addedEntity;
        }
        public List<Usuarios> GetAllUsuarios()
        {
            var sql = "select * from Persona inner join Usuarios on Persona.Id =Usuarios.Id;";
            List<Usuarios> usuarios = connection.Query<Usuarios>(sql).ToList();
            return usuarios;
        }

    }
}
