using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BookDiary.Infrastructure.Data;
using BookDiary.Model.Models;
using BookDiary.Model.Requests.UserBooks;
using Microsoft.EntityFrameworkCore;

namespace BookDiary.API.Service
{
    public class UserBooksService : CrudService<Model.Models.UserBook, UserBooksSearchRequest, Infrastructure.Entities.UserBook, UserBooksUpsertRequest, UserBooksUpsertRequest>
    {
        public UserBooksService(BookDiaryContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override async Task<IEnumerable<UserBook>> Get(UserBooksSearchRequest search)
        {
            var query = _context.Set<Infrastructure.Entities.UserBook>().AsQueryable();

            if (search.IsUsersLoadingEnabled == true)
                query = query.Include(x => x.User);

            if (search.IsBooksLoadingEnabled == true)
                query = query.Include(x => x.Book);

            query = query.Where(x => x.UserId == search.UserId && !x.Archived);

            query = query.OrderByDescending(x => x.StartedReadingOn);

            var entities = await query.ToListAsync();

            return _mapper.Map<IEnumerable<Model.Models.UserBook>>(entities);
        }

        public override async Task<UserBook> GetById(int id)
        {
            var query = _context.Set<Infrastructure.Entities.UserBook>().AsQueryable();

            query = query.Include(x => x.User);
            query = query.Include(x => x.Book);

            var entity = await query.FirstOrDefaultAsync(x => x.Id == id);

            return _mapper.Map<Model.Models.UserBook>(entity);
        }
    }
}
