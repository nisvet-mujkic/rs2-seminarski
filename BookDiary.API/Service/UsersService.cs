using AutoMapper;
using BookDiary.Infrastructure.Data;
using BookDiary.Model.Models;
using BookDiary.Model.Requests.Users;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookDiary.API.Service
{
    public class UsersService : CrudService<Model.Models.User, UsersSearchRequest, Infrastructure.Entities.User, UsersUpsertRequest, UsersUpsertRequest>
    {
        public UsersService(BookDiaryContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override async Task<IEnumerable<User>> Get(UsersSearchRequest search)
        {
            var query = _context.Set<Infrastructure.Entities.User>().AsQueryable();

            if (search.ShowDisabledUsers)
            {
                query = query.Where(user => user.Archived);
            }

            if (!string.IsNullOrEmpty(search.SearchTerm))
            {
                string term = search.SearchTerm;
                query = query.Where(user => (user.FirstName.StartsWith(term) || user.FirstName.Contains(term)) || 
                                (user.LastName.StartsWith(term) || user.LastName.Contains(term)) || 
                                (user.Email.StartsWith(term) || user.Email.Contains(term)) || 
                                (user.Username.StartsWith(term) || user.Username.Contains(term)));
            }

            var entities = await query.ToListAsync();

            return _mapper.Map<IEnumerable<Model.Models.User>>(entities);
        }
    }
}
