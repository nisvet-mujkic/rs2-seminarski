using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BookDiary.Infrastructure.Data;
using BookDiary.Model.Models;
using BookDiary.Model.Requests.Books;
using Microsoft.EntityFrameworkCore;

namespace BookDiary.API.Service
{
    public class BooksService : CrudService<Model.Models.Book, BooksSearchRequest, Infrastructure.Entities.Book, BooksUpsertRequest, BooksUpsertRequest>
    {
        public BooksService(BookDiaryContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override async Task<IEnumerable<Book>> Get(BooksSearchRequest search)
        {
            var query = _context.Set<Infrastructure.Entities.Book>().AsQueryable();

            if (search.IsAuthorsLoadingEnabled == true)
                query = query.Include(x => x.Author);

            if (search.IsGenresLoadingEnabled == true)
                query = query.Include(x => x.Genre);

            if (!string.IsNullOrEmpty(search.SearchTerm))
                query = query.Where(x => (x.Name.StartsWith(search.SearchTerm) || x.Name.Contains(search.SearchTerm)));

            if (search.GenreId.HasValue && search.GenreId.Value != 0)
                query = query.Where(x => x.GenreId == search.GenreId.Value);

            if (search.AuthorId.HasValue && search.AuthorId.Value != 0)
                query = query.Where(x => x.AuthorId == search.AuthorId.Value);

            query = query.OrderBy(x => x.Name);

            var entities = await query.ToListAsync();

            return _mapper.Map<IEnumerable<Model.Models.Book>>(entities);
        }

        public override async Task<Book> GetById(int id)
        {
            var query = _context.Set<Infrastructure.Entities.Book>().AsQueryable();

            query = query.Include(x => x.Genre);
            query = query.Include(x => x.Author);

            var entity = await query.FirstOrDefaultAsync(x => x.Id == id);

            return _mapper.Map<Model.Models.Book>(entity);
        }
    }
}
