using System.Threading.Tasks;

namespace BookDiary.API.IService
{
    public interface ICrudService<T, TSearch, TInsert, TUpdate> : IService<T, TSearch>
    {
        Task<T> Insert(TInsert request);

        Task<T> Update(int id, TUpdate request);
    }
}
