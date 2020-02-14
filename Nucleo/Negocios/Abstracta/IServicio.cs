using Nucleo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Nucleo.Negocios.Abstracta
{
    public interface IServicio<T> where T : class, IEntidad, new()
    {
        T Add(T entity);
        T Update(T entity);
        int Delete(T entity);
        T GetById(int entityId);
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        List<T> GetAll(string filter);
        T Get(string filter);
        T Get(Expression<Func<T, bool>> filter);

        List<T> GetPaginate(string filter, int OFFSET, int FETCH, string order);

        List<T> GetPaginate(string filter, int OFFSET, int FETCH);
        List<T> GetPaginate(int OFFSET, int FETCH, string order);
        List<T> GetPaginate(int OFFSET, int FETCH);

        List<T> GetAll(string filter, string order);
        List<T> GetAllOrderBy(string order);
        int Count();
        void SaveData();
    }
}
