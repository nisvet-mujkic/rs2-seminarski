using BookDiary.API.IService;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookDiary.API.Controllers
{
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class RecommendationController
    {
        private readonly IRecommendationService _recommendationService;

        public RecommendationController(IRecommendationService recommendationService)
        {
            _recommendationService = recommendationService;
        }

        [HttpGet("{id}")]
        public async Task<List<Model.Models.Book>> GetById(int id)
        {
            return await _recommendationService.Recommend(id);
        }
    }   
}