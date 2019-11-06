using System.Collections.Generic;
using BraviBraian.Application.Interface;
using BraviBraian.Domain.Entities;
using BraviBraian.Domain.Interfaces.Services;

namespace BraviBraian.Application
{
    public class ContactTypeAppService : AppBaseService<ContactType>, IContactTypeAppService
    {
        private readonly IContactTypeService contactTypeService;

        public ContactTypeAppService(IContactTypeService _contactTypeService) : base(_contactTypeService)
        {
            contactTypeService = _contactTypeService;
        }

        public void Delete(int id)
        {
            contactTypeService.Remove(contactTypeService.GetById(id));
        }

        public ICollection<ContactType> GetListByName(string name)
        {
            return contactTypeService.GetListByName(name);
        }
    }
}
