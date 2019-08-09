using AutoMapper;

namespace BookDiary.API.Mappers
{
    public class Mapper: Profile
    {
        public Mapper()
        {
            CreateMap<Infrastructure.Entities.Genre, Model.Models.Genre>();
            CreateMap<Infrastructure.Entities.Quote, Model.Models.Quote>();
            CreateMap<Infrastructure.Entities.Quote, Model.Requests.Quotes.QuotesUpsertRequest>().ReverseMap();
        }
    }
}
