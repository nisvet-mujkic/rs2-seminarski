using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BookDiary.Infrastructure.Data;
using BookDiary.Model.Models;
using BookDiary.Model.Requests.ReadingActivities;
using Microsoft.EntityFrameworkCore;

namespace BookDiary.API.Service
{
    public class ReadingActivitiesService : CrudService<Model.Models.ReadingActivity, ReadingActivitiesSearchRequest, Infrastructure.Entities.ReadingActivity, ReadingActivitiesUpsertRequest, ReadingActivitiesUpsertRequest>
    {
        public ReadingActivitiesService(BookDiaryContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override async Task<IEnumerable<ReadingActivity>> Get(ReadingActivitiesSearchRequest search)
        {
            var query = _context.Set<Infrastructure.Entities.ReadingActivity>().AsQueryable();

            if (search.IsUserBooksLoadingEnabled == true)
                query = query.Include(x => x.UserBook);

            if (search.UserBookId.HasValue)
                query = query.Where(x => x.UserBookId == search.UserBookId);

            var entities = await query.ToListAsync();

            return _mapper.Map<IEnumerable<Model.Models.ReadingActivity>>(entities);
        }
    }
}
