using System.Collections.Generic;
using BraviBraian.Domain.Entities;
using BraviBraian.Domain.Interfaces.Repositories;
using BraviBraian.Domain.Interfaces.Services;

namespace BraviBraian.Domain.Services
{
    public class PersonService : BaseService<Person>, IPersonService
    {
        private readonly IPersonRepository personRepository;

        public PersonService(IPersonRepository _personRepository)
            :base(_personRepository)
        {
            personRepository = _personRepository;
        }

        public ICollection<Person> GetListByName(string name)
        {
            return personRepository.GetListByName(name.ToLower());
        }
    }
}
