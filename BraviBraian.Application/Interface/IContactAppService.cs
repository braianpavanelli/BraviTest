using BraviBraian.Domain.Entities;
using System.Collections.Generic;

namespace BraviBraian.Application.Interface
{
    public interface IContactAppService : IAppBaseService<Contact>
    {
        ICollection<Contact> GetListByDescription(string description);
        ICollection<Contact> GetListByType(int idContactType);
        ICollection<Contact> GetListByPerson(int idPerson);
        void UpdateByApi(Contact obj);
        void UpdateCollection(Contact[] contacts);
        void Delete(int id);
    }
}
