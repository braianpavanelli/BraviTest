using System.Collections.Generic;
using BraviBraian.Domain.Entities;
using BraviBraian.Domain.Interfaces.Repositories;
using BraviBraian.Domain.Interfaces.Services;

namespace BraviBraian.Domain.Services
{
    public class ContactService : BaseService<Contact>, IContactService
    {
        private readonly IContactRepository contactRepository;

        public ContactService(IContactRepository _contactRepository)
            : base(_contactRepository)
        {
            contactRepository = _contactRepository;
        }

        public ICollection<Contact> GetListByDescription(string description)
        {
            return contactRepository.GetListByDescription(description);
        }

        public ICollection<Contact> GetListByPerson(int idPerson)
        {
            return contactRepository.GetListByPerson(idPerson);
        }

        public ICollection<Contact> GetListByType(int idContactType)
        {
            return contactRepository.GetListByType(idContactType);
        }
    }
}
