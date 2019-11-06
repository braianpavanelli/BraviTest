using BraviBraian.Domain.Entities;
using BraviBraian.Domain.Interfaces.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace BraviBraian.Infra.Data.Repository
{
    public class ContactRepository : BaseRepository<Contact>, IContactRepository
    {
        public ICollection<Contact> GetListByDescription(string description)
        {
            return Db.Contacts.Where(u => u.Description.ToLower().Contains(description.ToLower())).ToList();
        }

        public ICollection<Contact> GetListByPerson(int idPerson)
        {
            return Db.Contacts.Where(u => u.IdPerson == idPerson).ToList();
        }

        public ICollection<Contact> GetListByType(int idContactType)
        {
            return Db.Contacts.Where(u => u.IdContactType == idContactType).ToList();
        }
    }
}
