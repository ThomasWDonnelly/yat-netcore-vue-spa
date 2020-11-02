using System;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace YatVueApp.Repository
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected RepositoryContext _repository { get; set; }

        public RepositoryBase(RepositoryContext repository)
        {
            this._repository = repository;
        }

        public IQueryable<T> FindAll()
        {
            return this._repository.Set<T>().AsNoTracking();
        }

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression)
        {
            return this._repository.Set<T>().Where(expression).AsNoTracking();
        }

        public void Create(T entity)
        {
            this._repository.Set<T>().Add(entity);
        }

        public void Update(T entity)
        {
            this._repository.Set<T>().Update(entity);
        }

        public void Delete(T entity)
        {
            this._repository.Set<T>().Remove(entity);
        }
    }
}