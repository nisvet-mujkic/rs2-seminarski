using BookDiary.API.IService;
using BookDiary.Infrastructure.Data;
using BookDiary.Infrastructure.Results;
using BookDiary.Model.Requests.Reports;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookDiary.API.Service
{
    public class ReportsService : IReportsService
    {
        private readonly BookDiaryContext _context;

        public ReportsService(BookDiaryContext context)
        {
            _context = context;
        }

        public async Task<List<GenreComparison>> GetGenreComparison()
        {
            return await _context.Query<GenreComparison>().AsNoTracking().FromSql("SP_GetGenreComparison").ToListAsync();
        }

        public async Task<List<MostActiveUsers>> GetMostActiveUsers(MostActiveUsersRequest request)
        {
           return await _context.Query<MostActiveUsers>().AsNoTracking().FromSql("SP_GetMostActiveUsersByDate @p0, @p1", request.From, request.To).ToListAsync();
        }

        public async Task<List<MostPopularBook>> GetMostPopularBooks(MostPopularBookRequest request)
        {
            return await _context.Query<MostPopularBook>().AsNoTracking().FromSql("SP_GetMostPopularBooksByDate @p0, @p1", request.From, request.To).ToListAsync();
        }
    }
}
