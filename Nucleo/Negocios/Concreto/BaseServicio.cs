using Nucleo.AccesoDatos.Abstractas;
using Nucleo.Entidades;
using Nucleo.Negocios.Abstracta;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Nucleo.Negocios.Concreto
{
    public class BaseServicio<T> : IServicio<T> where T : class, IEntidad, new()
    {
        private IRepositorioEntidad<T> _dataAccessBase;
        public BaseServicio(IRepositorioEntidad<T> dataAccessBase)
        {
            _dataAccessBase = dataAccessBase;
        }
        public T Add(T entity)
        {
            return _dataAccessBase.Add(entity);
        }

        public int Delete(T entity)
        {
            return _dataAccessBase.Delete(entity);
        }

        public T GetById(int entityId)
        {
            return _dataAccessBase.GetById(entityId);
        }

        public List<T> GetAll(Expression<Func<T, bool>> filter = null)
        {
            return _dataAccessBase.GetAll(filter);
        }

        public T Update(T entity)
        {
            return _dataAccessBase.Update(entity);
        }

        public virtual T Get(string filter)
        {
            return _dataAccessBase.Get(filter);
        }

        public T Get(Expression<Func<T, bool>> filter)
        {
            return _dataAccessBase.Get(filter);
        }

        public List<T> GetAll(string filter)
        {
            return _dataAccessBase.GetAll(filter);
        }

        public int Count()
        {
            return _dataAccessBase.Count();
        }


        public void SaveData()
        {
            _dataAccessBase.SaveData();
        }

        public List<T> GetPaginate(string filter, int OFFSET, int FETCH)
        {
            return _dataAccessBase.GetPaginate(filter, OFFSET, FETCH);
        }

        public List<T> GetPaginate(string filter, int OFFSET, int FETCH, string order)
        {
            return _dataAccessBase.GetPaginate(filter, OFFSET, FETCH,order);
        }

        public List<T> GetPaginate(int OFFSET, int FETCH, string order)
        {
            return _dataAccessBase.GetPaginate(OFFSET, FETCH,order);
        }

        public List<T> GetPaginate(int OFFSET, int FETCH)
        {
            return _dataAccessBase.GetPaginate( OFFSET, FETCH);
        }

        public List<T> GetAll(string filter, string order)
        {
            return _dataAccessBase.GetAll(filter,order);
        }

        public List<T> GetAllOrderBy(string order)
        {
            return _dataAccessBase.GetAllOrderBy(order);
        }
    }
}
