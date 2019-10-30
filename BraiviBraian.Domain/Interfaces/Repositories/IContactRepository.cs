using BraviBraian.Domain.Entities;
using System.Collections.Generic;

namespace BraviBraian.Domain.Interfaces.Repositories
{
    public interface IContactRepository : IBaseRepository<Contact>
    {
        ICollection<Contact> GetListByDescription(string description);
        ICollection<Contact> GetListByType(int idContactType);
        ICollection<Contact> GetListByPerson(int idPerson);
    }
}
