using BraviBraian.Domain.Entities;
using System.Collections.Generic;

namespace BraviBraian.Domain.Interfaces.Services
{
    public interface IContactService : IBaseService<Contact>
    {
        ICollection<Contact> GetListByDescription(string description);
        ICollection<Contact> GetListByType(int idContactType);
        ICollection<Contact> GetListByPerson(int idPerson);
    }
}
