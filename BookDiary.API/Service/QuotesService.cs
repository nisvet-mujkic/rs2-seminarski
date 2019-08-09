using AutoMapper;
using BookDiary.Infrastructure.Data;
using BookDiary.Model.Models;
using BookDiary.Model.Requests.Quotes;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookDiary.API.Service
{
    public class QuotesService : CrudService<Model.Models.Quote, QuotesSearchRequest, Infrastructure.Entities.Quote, QuotesUpsertRequest, QuotesUpsertRequest>
    {
        public QuotesService(BookDiaryContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override async Task<IEnumerable<Quote>> Get(QuotesSearchRequest search)
        {
            var query = _context.Set<Infrastructure.Entities.Quote>().AsQueryable();

            if (search?.BookId.HasValue == true)
                query = query.Where(x => x.BookId == search.BookId);

            query = query.OrderBy(x => x.QuoteText);

            var entities = await query.ToListAsync();

            return _mapper.Map<IEnumerable<Model.Models.Quote>>(entities);
        }
    }
}
