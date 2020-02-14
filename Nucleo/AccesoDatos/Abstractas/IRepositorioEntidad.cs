using Nucleo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Nucleo.AccesoDatos.Abstractas
{
   
    public interface IRepositorioEntidad<T> where T : class, IEntidad, new()
    {
        T Add(T entity);
        T Update(T entity);
        int Delete(T entity);
        List<T> GetAll(Expression<Func<T, bool>> filter = null); 
        List<T> GetAll(string filter);
        List<T> GetPaginate(string filter, int OFFSET, int FETCH, string order);

        List<T> GetPaginate(string filter, int OFFSET, int FETCH);
        List<T> GetPaginate( int OFFSET, int FETCH, string order);
        List<T> GetPaginate(int OFFSET, int FETCH);

        List<T> GetAll(string filter,string order);
        List<T> GetAllOrderBy(string order);
        T GetById(int entityId);
        T Get(string filter);
        T Get(Expression<Func<T, bool>> filter);
        int Count();
        void SaveData();
    }
}
