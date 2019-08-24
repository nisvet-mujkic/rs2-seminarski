using BookDiary.API.IService;
using BookDiary.Model.Requests.Users;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookDiary.API.Controllers
{
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUsersService _service;
        public UsersController(IUsersService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<List<Model.Models.User>> Get([FromQuery]UsersSearchRequest request)
        {
            return await _service.Get(request);
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<Model.Models.User> Insert(UsersUpsertRequest request)
        {
            return await _service.Insert(request);
        }

        [Authorize(Roles = "Admin")]
        [HttpPut("{id}")]
        public async Task<Model.Models.User> Update(int id, [FromBody]UsersUpsertRequest request)
        {
            return await _service.Update(id, request);
        }

        [HttpGet("{id}")]
        public async Task<Model.Models.User> GetById(int id)
        {
            return await _service.GetById(id);
        }
    }
}