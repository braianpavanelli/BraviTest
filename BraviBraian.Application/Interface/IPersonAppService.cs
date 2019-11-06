using BraviBraian.Domain.Entities;
using System.Collections.Generic;

namespace BraviBraian.Application.Interface
{
    public interface IPersonAppService : IAppBaseService<Person>
    {
        ICollection<Person> GetListByName(string name);
        void UpdateByApi(Person obj);
        void Delete(int id);
    }
}
