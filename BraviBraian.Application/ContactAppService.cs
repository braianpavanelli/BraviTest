using System.Collections.Generic;
using BraviBraian.Application.Interface;
using BraviBraian.Domain.Entities;
using BraviBraian.Domain.Interfaces.Services;

namespace BraviBraian.Application
{
    public class ContactAppService : AppBaseService<Contact>, IContactAppService
    {
        private readonly IContactService contactService;

        public ContactAppService(IContactService _contactService) : base(_contactService)
        {
            contactService = _contactService;
        }

        public void Delete(int id)
        {
            contactService.Remove(contactService.GetById(id));
        }

        public ICollection<Contact> GetListByDescription(string description)
        {
            return contactService.GetListByDescription(description);
        }

        public ICollection<Contact> GetListByPerson(int idPerson)
        {
            return contactService.GetListByPerson(idPerson);
        }

        public ICollection<Contact> GetListByType(int idContactType)
        {
            return contactService.GetListByType(idContactType);
        }

        public void UpdateByApi(Contact obj)
        {
            var contact = contactService.GetById(obj.Id);
            contact.IdContactType = obj.IdContactType;
            contact.Description = obj.Description;
            contactService.Update(contact);
        }

        public void UpdateCollection(Contact[] contacts)
        {
            foreach (var item in contacts)
            {
                var contact = contactService.GetById(item.Id);
                contact.IdContactType = item.IdContactType;
                contact.Description = item.Description;
                contactService.Update(contact);
            }
        }
    }
}
