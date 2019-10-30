using BraviBraian.Domain.Entities;
using System.Collections.Generic;

namespace BraviBraian.Domain.Interfaces.Repositories
{
    public interface IContactTypeRepository : IBaseRepository<ContactType>
    {
        ICollection<ContactType> GetListByName(string name);
    }
}
