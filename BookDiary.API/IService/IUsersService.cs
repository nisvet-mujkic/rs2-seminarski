using BookDiary.Infrastructure.Results;
using BookDiary.Model.Requests.Reports;
using BookDiary.Model.Requests.Users;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookDiary.API.IService
{
    public interface IUsersService
    {
        Task<List<Model.Models.User>> Get(UsersSearchRequest search);

        Task<Model.Models.User> GetById(int id);

        Task<Model.Models.User> Insert(UsersUpsertRequest request);

        Task<Model.Models.User> Update(int id, UsersUpsertRequest request);

        Task<Model.Models.User> Authenticate(string username, string password);
    }
}
