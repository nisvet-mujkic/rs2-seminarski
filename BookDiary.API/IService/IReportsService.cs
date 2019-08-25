using BookDiary.Infrastructure.Results;
using BookDiary.Model.Requests.Reports;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookDiary.API.IService
{
    public interface IReportsService
    {
        Task<List<MostActiveUsers>> GetMostActiveUsers(MostActiveUsersRequest request);
        Task<List<GenreComparison>> GetGenreComparison();
        Task<List<MostPopularBook>> GetMostPopularBooks(MostPopularBookRequest request);
    }
}
