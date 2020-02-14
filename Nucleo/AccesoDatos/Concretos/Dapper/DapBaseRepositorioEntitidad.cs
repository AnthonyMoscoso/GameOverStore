using Nucleo.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using System.Linq.Expressions;
using Nucleo.AccesoDatos.Abstractas;


namespace Nucleo.AccesoDatos.Concretos.Dapper
{

    public abstract class DapBaseRepositorioEntitidad<TEntidad, TContexto> : IRepositorioEntidad<TEntidad>
        where TEntidad : class, IEntidad, new()
        where TContexto : class, IContexto, new()
    {
        private string TableName { get; set; }
        private string Colums { get; set; }
        private string Params { get; set; }
      

        public DapBaseRepositorioEntitidad(string tableName, string colums, string parameters)
        {
            TableName = tableName;
            Colums = colums;
            Params = parameters;
            
        }

        private const string INSERT_QUERY = "INSERT INTO {0} ({1}) VALUES ({2}) SELECT * FROM {0} WHERE [{0}].Id = @@IDENTITY";
        private const string UPDATE_QUERY = "UPDATE {0} SET {1} WHERE [{0}].Id = @Id";
        private const string DELETE_QUERY = "DELETE FROM {0} WHERE [{0}].Id = @Id";
        private const string SELECT_ALL_QUERY = "SELECT * FROM {0}";
        private const string SELECT_FIRST_QUERY = "SELECT * FROM {0} WHERE [{0}].Id=@Id";
        private const string SELECT_CUSTOM_WHERE_QUERY = "SELECT * FROM {0} WHERE [{0}].{1}";
        private const string SELECT_ORDER_BY = "SELECT * FROM {0}  ORDER  BY {1}";
        private const string SELECT_FILTER_ORDER = "SELECT * FROM {0} WHERE {1} ORDER  BY {2}";
        private const string SELECT_ALL_PAGINATE = "SELECT * FROM {0}  ORDER  BY Id OFFSET {1} ROWS FETCH NEXT {2} ROWS ONLY";
        private const string SELECT_FILTER_PAGINATE = "SELECT * FROM {0} WHERE {1} ORDER BY Id OFFSET {2} ROWS FETCH NEXT {3} ROWS ONLY";
        private const string SELECT_ALL_ORDER_PAGINATE = "SELECT * FROM {0}  ORDER  BY {3} I OFFSET {1} ROWS FETCH NEXT {2} ROWS ONLY";
        private const string SELECT_FILTER_ORDER_PAGINATE = "SELECT * FROM {0} WHERE {1} ORDER  BY {4}  OFFSET {2} ROWS FETCH NEXT {3} ROWS ONLY";
        private const string COUNT_QUERY = "SELECT COUNT(Id) FROM {0};";

        protected SqlConnection connection = new SqlConnection(new TContexto().CadenaConexion);
      

        public TEntidad Add(TEntidad entity)
        {
            if (entity is BaseEntidad)
            {
                (entity as BaseEntidad).Creado = DateTime.Now;
                (entity as BaseEntidad).Estado = Entidades.Enumerados.EstadoDeFila.Nuevo;
            }
            string sql = string.Format(INSERT_QUERY, TableName, Colums, Params);
            TEntidad addedEntity = connection.QueryFirstOrDefault<TEntidad>(sql, entity);
            return addedEntity;
        }

        public int Delete(TEntidad entity)
        {
            var sql =string.Format(DELETE_QUERY, TableName);
               var affectedRow = connection.Execute(sql,entity);
            return affectedRow;
        }

        public TEntidad Update(TEntidad entity)
        {
            if (entity is BaseEntidad)
            {
                (entity as BaseEntidad).Estado = Entidades.Enumerados.EstadoDeFila.Actualizado;
            }
            var updateCmd = string.Join(",", Colums.Split(',').Select(x => string.Format("[{0}].[{1}] = @{1}", TableName, x)));
            var entityList = connection.Query<TEntidad>(string.Format(UPDATE_QUERY, TableName, updateCmd), entity);

            return GetById(entity.Id);
        }

        public List<TEntidad> GetAll(Expression<Func<TEntidad, bool>> filter = null)
        {
            
            List<TEntidad> entityList = connection.Query<TEntidad>(string.Format(SELECT_ALL_QUERY, TableName),filter).ToList();
            return entityList;
        }

        public TEntidad GetById(int entityId)
        {
            var entity = connection.QueryFirstOrDefault<TEntidad>(string.Format(SELECT_FIRST_QUERY, TableName), new { Id = entityId });
            return entity;
        }
        public TEntidad Get(string filter)
        {
           // var queryFilter = QueryBuilder<TEntidad>.FromExpression(filter);

            string sql = string.Format(SELECT_CUSTOM_WHERE_QUERY, TableName, filter);
            var entity = connection.QueryFirstOrDefault<TEntidad>(sql);
            return entity;
        }

        public TEntidad Get(Expression<Func<TEntidad, bool>> filter)
        {
            
            var entity = connection.QueryFirstOrDefault < TEntidad >(string.Format(SELECT_CUSTOM_WHERE_QUERY, TableName, filter));
            return entity;
        }

        public List<TEntidad> GetAll(string filter)
        {
            var entity = connection.Query<TEntidad>(string.Format(SELECT_CUSTOM_WHERE_QUERY, TableName, filter)).ToList();
            return entity;
        }

        public List<TEntidad> GetPaginate(string filter, int OFFSET, int FETCH)
        {
            var sql = string.Format(SELECT_FILTER_PAGINATE, TableName, filter, OFFSET, FETCH);
            var entity = connection.Query<TEntidad>(sql).ToList();
            return entity;
        }
        public List<TEntidad> GetPaginate(string filter, int OFFSET, int FETCH, string order)
        {
            var sql = string.Format(SELECT_FILTER_ORDER_PAGINATE, TableName, filter, OFFSET, FETCH,order);
            var entity = connection.Query<TEntidad>(sql).ToList();
            return entity;
        }

        public List<TEntidad> GetPaginate(int OFFSET, int FETCH, string order)
        {
            var sql = string.Format(SELECT_ALL_ORDER_PAGINATE, TableName,  OFFSET, FETCH,order);
            var entity = connection.Query<TEntidad>(sql).ToList();
            return entity;
        }

        public List<TEntidad> GetPaginate(int OFFSET, int FETCH)
        {
            var sql = string.Format(SELECT_ALL_PAGINATE, TableName, OFFSET, FETCH);
            var entity = connection.Query<TEntidad>(sql).ToList();
            return entity;
        }
        public List<TEntidad> GetAll(string filter, string order)
        {
            var sql = string.Format(SELECT_FILTER_ORDER, TableName, filter,order);
            var entity = connection.Query<TEntidad>(sql).ToList();
            return entity;
        }

        public List<TEntidad> GetAllOrderBy(string order)
        {
            var sql = string.Format(SELECT_ORDER_BY, TableName, order);
            var entity = connection.Query<TEntidad>(sql).ToList();
            return entity;
        }
        public int Count()
        {
            return connection.ExecuteScalar<int>(string.Format(COUNT_QUERY, TableName));
        }


        public void SaveData()
        {
            
        }

        
    }
}
