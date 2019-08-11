using BookDiary.API.Helpers.Controllers;
using BookDiary.API.IService;
using BookDiary.Model.Models;
using BookDiary.Model.Requests.Users;

namespace BookDiary.API.Controllers
{
    public class UsersController : CrudController<Model.Models.User, UsersSearchRequest, UsersUpsertRequest, UsersUpsertRequest>
    {
        public UsersController(ICrudService<User, UsersSearchRequest, UsersUpsertRequest, UsersUpsertRequest> service) : base(service)
        {
        }
    }
}