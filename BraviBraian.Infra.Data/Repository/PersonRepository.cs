using BraviBraian.Domain.Entities;
using BraviBraian.Domain.Interfaces.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace BraviBraian.Infra.Data.Repository
{
    public class PersonRepository : BaseRepository<Person>, IPersonRepository
    {
        public ICollection<Person> GetListByName(string name)
        {
            return Db.People.Where(u => u.Name.ToLower().Contains(name.ToLower())).ToList();
        }
    }
}
