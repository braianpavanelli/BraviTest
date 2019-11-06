using BraviBraian.Domain.Entities;
using BraviBraian.Domain.Interfaces.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace BraviBraian.Infra.Data.Repository
{
    public class ContactTypeRepository : BaseRepository<ContactType>, IContactTypeRepository
    {
        public ICollection<ContactType> GetListByName(string name)
        {
            return Db.ContactTypes.Where(u => name.ToLower().Contains(u.Name.ToLower())).ToList();
        }
    }
}
