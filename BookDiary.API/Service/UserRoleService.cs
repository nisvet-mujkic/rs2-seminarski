using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BookDiary.Infrastructure.Data;
using BookDiary.Model.Models;
using BookDiary.Model.Requests.UserRoles;
using Microsoft.EntityFrameworkCore;

namespace BookDiary.API.Service
{
    public class UserRoleService: Service<Model.Models.UserRole, UserRolesSearchRequest, Infrastructure.Entities.UserRole>
    {
        public UserRoleService(BookDiaryContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override async Task<IEnumerable<UserRole>> Get(UserRolesSearchRequest search)
        {
            var query = _context.Set<Infrastructure.Entities.UserRole>().AsQueryable();

            if (search.RoleId.HasValue)
                query = query.Where(x => x.RoleId == search.RoleId);

            if (search.UserId.HasValue)
                query = query.Where(x => x.UserId == search.UserId);

            if (search.IsRolesLoadingEnabled)
                query = query.Include(x => x.Role);

            if (search.IsUsersLoadingEnabled)
                query = query.Include(x => x.User);

            var entities = await query.ToListAsync();

            return _mapper.Map<IEnumerable<Model.Models.UserRole>>(entities);
        }

    }
}
