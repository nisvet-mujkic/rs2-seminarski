using BookDiary.API.Helpers.Controllers;
using BookDiary.API.IService;
using BookDiary.Model.Models;
using BookDiary.Model.Requests.UserRoles;

namespace BookDiary.API.Controllers
{
    public class UserRolesController : BaseController<Model.Models.UserRole, UserRolesSearchRequest>
    {
        public UserRolesController(IService<UserRole, UserRolesSearchRequest> service) : base(service)
        {
        }
    }
}