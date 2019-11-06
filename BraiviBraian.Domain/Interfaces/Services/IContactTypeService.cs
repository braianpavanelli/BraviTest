using BraviBraian.Domain.Entities;
using System.Collections.Generic;

namespace BraviBraian.Domain.Interfaces.Services
{
    public interface IContactTypeService : IBaseService<ContactType>
    {
        ICollection<ContactType> GetListByName(string name);
    }
}
