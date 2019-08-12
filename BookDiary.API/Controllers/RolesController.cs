using BookDiary.API.Helpers.Controllers;
using BookDiary.API.IService;
using BookDiary.Model.Models;

namespace BookDiary.API.Controllers
{
    public class RolesController : BaseController<Model.Models.Role, object>
    {
        public RolesController(IService<Role, object> service) : base(service)
        {
        }
    }
}