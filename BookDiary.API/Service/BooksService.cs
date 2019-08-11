using AutoMapper;
using BookDiary.Infrastructure.Data;
using BookDiary.Model.Requests.Books;

namespace BookDiary.API.Service
{
    public class BooksService : CrudService<Model.Models.Book, BooksSearchRequest, Infrastructure.Entities.Book, BooksUpsertRequest, BooksUpsertRequest>
    {
        public BooksService(BookDiaryContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
