using BookDiary.API.Helpers.Controllers;
using BookDiary.API.IService;
using BookDiary.Model.Models;
using BookDiary.Model.Requests.Books;

namespace BookDiary.API.Controllers
{
    public class RecommendationController : BaseController<Model.Models.Book, BooksSearchRequest>
    {
        public RecommendationController(IService<Book, BooksSearchRequest> service) : base(service)
        {
        }
    }
}