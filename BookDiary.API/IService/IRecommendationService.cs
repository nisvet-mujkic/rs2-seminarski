using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookDiary.API.IService
{
    public interface IRecommendationService
    {
        Task<List<Model.Models.Book>> Recommend(int userId);
    }
}
