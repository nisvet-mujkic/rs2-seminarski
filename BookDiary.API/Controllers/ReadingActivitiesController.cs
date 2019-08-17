using BookDiary.API.Helpers.Controllers;
using BookDiary.API.IService;
using BookDiary.Model.Models;
using BookDiary.Model.Requests.ReadingActivities;

namespace BookDiary.API.Controllers
{
    public class ReadingActivitiesController : CrudController<Model.Models.ReadingActivity, ReadingActivitiesSearchRequest, ReadingActivitiesUpsertRequest, ReadingActivitiesUpsertRequest>
    {
        public ReadingActivitiesController(ICrudService<ReadingActivity, ReadingActivitiesSearchRequest, ReadingActivitiesUpsertRequest, ReadingActivitiesUpsertRequest> service) : base(service)
        {
        }
    }
}