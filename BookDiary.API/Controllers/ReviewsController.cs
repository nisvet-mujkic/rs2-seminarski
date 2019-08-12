using BookDiary.API.Helpers.Controllers;
using BookDiary.API.IService;
using BookDiary.Model.Models;
using BookDiary.Model.Requests.Reviews;

namespace BookDiary.API.Controllers
{
    public class ReviewsController : CrudController<Model.Models.Review, ReviewsSearchRequest, ReviewsUpsertRequest, ReviewsUpsertRequest>
    {
        public ReviewsController(ICrudService<Review, ReviewsSearchRequest, ReviewsUpsertRequest, ReviewsUpsertRequest> service) : base(service)
        {
        }
    }
}