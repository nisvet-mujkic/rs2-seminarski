using BookDiary.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BookDiary.Core.IRepositories
{
    public interface IRepository<T> where T: IBaseEntity
    {
        Task<T> GetById(int id);
        Task<IEnumerable<T>> GetAllAsync();
        Task<IEnumerable<T>> GetWhereAsync(Expression<Func<T, bool>> predicate);
        Task<T> FirstOrDefault(int id);
        void Add(T entity);
        void Update(T entity);
        void Update(int id);
        void Delete(T entity);
        Task SaveChangesAsync();
    }
}
