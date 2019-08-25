using BookDiary.API.IService;
using BookDiary.Infrastructure.Results;
using BookDiary.Model.Requests.Reports;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookDiary.API.Controllers
{
    //[Authorize]
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ReportsController : ControllerBase
    {
        private readonly IReportsService _reportsService;

        public ReportsController(IReportsService reportsService)
        {
            _reportsService = reportsService;
        }

        [HttpGet]
        public async Task<List<MostActiveUsers>> MostActiveUsers([FromQuery]MostActiveUsersRequest request)
        {
            return await _reportsService.GetMostActiveUsers(request);
        }

        [HttpGet]
        public async Task<List<GenreComparison>> GenreComparison()
        {
            return await _reportsService.GetGenreComparison();
        }

        [HttpGet]
        public async Task<List<MostPopularBook>> MostPopularBooks([FromQuery]MostPopularBookRequest request)
        {
            return await _reportsService.GetMostPopularBooks(request);
        }
    }
}