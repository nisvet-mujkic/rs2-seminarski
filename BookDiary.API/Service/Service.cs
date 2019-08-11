using AutoMapper;
using BookDiary.API.IService;
using BookDiary.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookDiary.API.Service
{
    public class Service<TModel, TSearch, TDatabase> : IService<TModel, TSearch>
        where TDatabase: class
    {
        protected readonly BookDiaryContext _context;
        protected readonly IMapper _mapper;
        public Service(BookDiaryContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public virtual async Task<IEnumerable<TModel>> Get(TSearch search)
        {
            var entities = await _context.Set<TDatabase>().ToListAsync();
            return _mapper.Map<IEnumerable<TModel>>(entities);
        }

        public virtual async Task<TModel> GetById(int id)
        {
            var entity = await _context.Set<TDatabase>().FindAsync(id);
            return _mapper.Map<TModel>(entity);
        }
    }
}
