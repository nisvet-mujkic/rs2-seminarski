using AutoMapper;
using BookDiary.API.IService;
using BookDiary.Infrastructure.Data;
using System.Threading.Tasks;

namespace BookDiary.API.Service
{
    public class CrudService<TModel, TSearch, TDatabase, TInsert, TUpdate> : Service<TModel, TSearch, TDatabase>, ICrudService<TModel, TSearch, TInsert, TUpdate> 
        where TDatabase : class
    {
        public CrudService(BookDiaryContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public virtual async Task<TModel> Insert(TInsert request)
        {
            var entity = _mapper.Map<TDatabase>(request);
            _context.Set<TDatabase>().Add(entity);
            
            await _context.SaveChangesAsync();

            return _mapper.Map<TModel>(entity);
        }

        public virtual async Task<TModel> Update(int id, TUpdate request)
        {
            var entity = await _context.Set<TDatabase>().FindAsync(id);
            _context.Set<TDatabase>().Attach(entity);
            _context.Set<TDatabase>().Update(entity);

            _mapper.Map(request, entity);

            await _context.SaveChangesAsync();
            return _mapper.Map<TModel>(entity);
        }
    }
}
