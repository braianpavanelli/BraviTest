using BraviBraian.Domain.Entities;
using System.Collections.Generic;


namespace BraviBraian.Domain.Interfaces.Repositories
{
    public interface IPersonRepository : IBaseRepository<Person>
    {
        ICollection<Person> GetListByName(string name);
    }
}
