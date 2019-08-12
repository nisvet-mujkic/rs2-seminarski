using AutoMapper;
using BookDiary.Model.Requests.Quotes;
using BookDiary.Model.Requests.Reviews;

namespace BookDiary.API.Mappers
{
    public class Mapper: Profile
    {
        public Mapper()
        {
            CreateMap<Infrastructure.Entities.Genre, Model.Models.Genre>();
            CreateMap<Infrastructure.Entities.Quote, Model.Models.Quote>();
            CreateMap<Infrastructure.Entities.Quote, QuotesUpsertRequest>().ReverseMap();
            CreateMap<Infrastructure.Entities.Book, Model.Models.Book>();
            CreateMap<Infrastructure.Entities.User, Model.Models.User>();
            CreateMap<Infrastructure.Entities.Review, Model.Models.Review>();
            CreateMap<Infrastructure.Entities.Review, ReviewsUpsertRequest>().ReverseMap();
        }
    }
}
