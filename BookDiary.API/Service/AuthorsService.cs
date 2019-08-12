using AutoMapper;
using BookDiary.Infrastructure.Data;
using BookDiary.Model.Requests.Authors;

namespace BookDiary.API.Service
{
    public class AuthorsService : CrudService<Model.Models.Author, AuthorsSearchRequest, Infrastructure.Entities.Author, AuthorsUpsertRequest, AuthorsUpsertRequest>
    {
        public AuthorsService(BookDiaryContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
