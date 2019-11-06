using System.Collections.Generic;
using System.Threading.Tasks;

namespace BraviBraian.Application.Interface
{
    public interface IAppBaseService<TEntity> where TEntity : class
    {
        void Add(TEntity obj);
        Task<bool> AddAsync(TEntity obj);
        void Update(TEntity obj);
        void Remove(TEntity obj);
        void Dispose();
        TEntity GetById(string id);
        TEntity GetById(int id);
        IEnumerable<TEntity> GetAll();
    }
}
