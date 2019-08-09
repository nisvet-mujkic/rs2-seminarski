using BookDiary.API.Helpers.Controllers;
using BookDiary.API.IService;
using BookDiary.Model.Models;
using BookDiary.Model.Requests.Quotes;

namespace BookDiary.API.Controllers
{
    public class QuotesController : CrudController<Model.Models.Quote, QuotesSearchRequest, QuotesUpsertRequest, QuotesUpsertRequest>
    {
        public QuotesController(ICrudService<Quote, QuotesSearchRequest, QuotesUpsertRequest, QuotesUpsertRequest> service) : base(service)
        {
        }
    }
}