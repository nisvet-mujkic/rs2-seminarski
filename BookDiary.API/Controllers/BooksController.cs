using BookDiary.API.Helpers.Controllers;
using BookDiary.API.IService;
using BookDiary.Model.Models;
using BookDiary.Model.Requests.Books;

namespace BookDiary.API.Controllers
{
    public class BooksController : CrudController<Model.Models.Book, BooksSearchRequest, BooksUpsertRequest, BooksUpsertRequest>
    {
        public BooksController(ICrudService<Book, BooksSearchRequest, BooksUpsertRequest, BooksUpsertRequest> service) : base(service)
        {
            
        }
    }
}