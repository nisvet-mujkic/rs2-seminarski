using BookDiary.API.Helpers.Controllers;
using BookDiary.API.IService;
using BookDiary.Model.Models;

namespace BookDiary.API.Controllers
{
    public class GenresController : BaseController<Model.Models.Genre, object>
    {
        public GenresController(IService<Genre, object> service) : base(service)
        {
        }
    }
}