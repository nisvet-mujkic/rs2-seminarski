using BookDiary.API.Helpers.Controllers;
using BookDiary.API.IService;
using BookDiary.Model.Models;
using BookDiary.Model.Requests.UserBooks;

namespace BookDiary.API.Controllers
{
    public class UserBooksController : CrudController<Model.Models.UserBook, UserBooksSearchRequest, UserBooksUpsertRequest, UserBooksUpsertRequest>
    {
        public UserBooksController(ICrudService<UserBook, UserBooksSearchRequest, UserBooksUpsertRequest, UserBooksUpsertRequest> service) : base(service)
        {
        }
    }
}