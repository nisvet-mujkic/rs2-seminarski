using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BookDiary.Infrastructure.Data;
using BookDiary.Model.Models;
using BookDiary.Model.Requests.Reviews;
using Microsoft.EntityFrameworkCore;

namespace BookDiary.API.Service
{
    public class ReviewsService : CrudService<Model.Models.Review, ReviewsSearchRequest, Infrastructure.Entities.Review, ReviewsUpsertRequest, ReviewsUpsertRequest>
    {
        public ReviewsService(BookDiaryContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override async Task<IEnumerable<Review>> Get(ReviewsSearchRequest search)
        {
            var query = _context.Set<Infrastructure.Entities.Review>().AsQueryable();

            if (search.IsBooksLoadingEnabled == true)
                query = query.Include(x => x.Book);

            if (search.IsUsersLoadingEnabled == true)
                query = query.Include(x => x.User);

            if (search.ShowApprovedReviews)
                query = query.Where(x => x.Approved == true);

            if (search.ShowRejectedReviews)
                query = query.Where(x => x.Approved == false);

            if (search.ShowPendingReviews)
                query = query.Where(x => x.Approved == null);

            query = query.Where(x => x.CreatedAt > search.From && x.CreatedAt < search.To);

            query = query.OrderByDescending(x => x.CreatedAt);

            var entities = await query.ToListAsync();

            return _mapper.Map<IEnumerable<Model.Models.Review>>(entities);
        }

        public override async Task<Review> GetById(int id)
        {
            var query = _context.Set<Infrastructure.Entities.Review>().AsQueryable();
            query = query.Include(x => x.User);
            query = query.Include(x => x.Book);

            var entities = await query.FirstOrDefaultAsync(x => x.Id == id);

            return _mapper.Map<Model.Models.Review>(entities);
        }
    }
}
