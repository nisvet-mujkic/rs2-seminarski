using BookDiary.API.IService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookDiary.API.Helpers.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController<T, TSearch> : ControllerBase
    {
        private readonly IService<T, TSearch> _service;
        public BaseController(IService<T, TSearch> service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IEnumerable<T>> Get([FromQuery]TSearch search)
        {
            return await _service.Get(search);
        }

        [HttpGet("{id}")]
        public async Task<T> GetById(int id)
        {
            return await _service.GetById(id);
        }
    }
}