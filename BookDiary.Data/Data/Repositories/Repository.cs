using BookDiary.Core.Interfaces;
using BookDiary.Core.IRepositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace BookDiary.Infrastructure.Data.Repositories
{
    public class Repository<T> : IRepository<T> where T : class, IBaseEntity
    {
        internal RepositoryContext RepositoryContext { get; private set; }
        public Repository(RepositoryContext repositoryContext)
        {
            RepositoryContext = repositoryContext;
        }
        public void Add(T entity)
        {
            RepositoryContext.Set<T>().Add(entity); 
        }

        public void Delete(T entity)
        {
            RepositoryContext.Set<T>().Remove(entity);
        }

        public async Task<T> FirstOrDefaultAsync(int id)
        {
            return await RepositoryContext.Set<T>().FindAsync(id);
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await RepositoryContext.Set<T>().ToListAsync();
        }

        public async Task<IEnumerable<T>> GetWhereAsync(Expression<Func<T, bool>> predicate)
        {
            return await RepositoryContext.Set<T>().Where(predicate).ToListAsync();
        }

        public async Task SaveChangesAsync()
        {
            await RepositoryContext.SaveChangesAsync();
        }

        public void Update(T entity)
        {
            RepositoryContext.Set<T>().Update(entity);
        }
    }
}
