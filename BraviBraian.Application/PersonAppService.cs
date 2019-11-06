using System.Collections.Generic;
using BraviBraian.Application.Interface;
using BraviBraian.Domain.Entities;
using BraviBraian.Domain.Interfaces.Services;

namespace BraviBraian.Application
{
    public class PersonAppService : AppBaseService<Person>, IPersonAppService
    {
        private readonly IPersonService personService;

        public PersonAppService(IPersonService _personService) : base(_personService)
        {
            personService = _personService;
        }

        public void Delete(int id)
        {
            personService.Remove(personService.GetById(id));
        }

        public ICollection<Person> GetListByName(string name)
        {
            return personService.GetListByName(name.ToLower());
        }

        public void UpdateByApi(Person obj)
        {
            var person = personService.GetById(obj.Id);
            person.Name = obj.Name;
            personService.Update(person);

        }
    }
}
