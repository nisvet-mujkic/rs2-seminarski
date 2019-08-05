using BookDiary.Core.Interfaces;
using BookDiary.Core.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BookDiary.Infrastructure.Data.Repositories
{
    public class Repository<T> : IRepository<T> where T : class, IBaseEntity
    {
        public void Add(T entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<T> FirstOrDefault(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<T> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> GetWhereAsync(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task SaveChangesAsync()
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }

        public void Update(int id)
        {
            throw new NotImplementedException();
        }
    }
}
