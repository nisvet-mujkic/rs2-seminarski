using BookDiary.API.Helpers.Controllers;
using BookDiary.API.IService;
using BookDiary.Model.Models;
using BookDiary.Model.Requests.Authors;

namespace BookDiary.API.Controllers
{
    public class AuthorsController : CrudController<Model.Models.Author, AuthorsSearchRequest, AuthorsUpsertRequest, AuthorsUpsertRequest>
    {
        public AuthorsController(ICrudService<Author, AuthorsSearchRequest, AuthorsUpsertRequest, AuthorsUpsertRequest> service) : base(service)
        {
        }
    }
}