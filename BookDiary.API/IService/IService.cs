using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookDiary.API.IService
{
    public interface IService<T, TSearch>
    {
        Task<IEnumerable<T>> Get(TSearch search);

        Task<T> GetById(int id);
    }
}
