using BookDiary.API.IService;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BookDiary.API.Helpers.Controllers
{
    public class CrudController<T, TSearch, TInsert, TUpdate> : BaseController<T, TSearch>
    {
        private readonly ICrudService<T, TSearch, TInsert, TUpdate> _service = null;
        public CrudController(ICrudService<T, TSearch, TInsert, TUpdate> service) : base(service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<T> Insert(TInsert request)
        {
            return await _service.Insert(request);
        }

        [HttpPut("{id}")]
        public async Task<T> Update(int id, [FromBody]TUpdate request)
        {
            return await _service.Update(id, request);
        }
    }
}