using BraviBraian.Domain.Entities;
using System.Collections.Generic;

namespace BraviBraian.Domain.Interfaces.Services
{
    public interface IPersonService : IBaseService<Person>
    {
        ICollection<Person> GetListByName(string name);
    }
}
