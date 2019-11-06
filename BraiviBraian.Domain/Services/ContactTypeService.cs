using System.Collections.Generic;
using BraviBraian.Domain.Entities;
using BraviBraian.Domain.Interfaces.Repositories;
using BraviBraian.Domain.Interfaces.Services;

namespace BraviBraian.Domain.Services
{
    public class ContactTypeService : BaseService<ContactType>, IContactTypeService
    {
        private readonly IContactTypeRepository contactTypeRepository;

        public ContactTypeService(IContactTypeRepository _contactTypeRepository)
            : base(_contactTypeRepository)
        {
            contactTypeRepository = _contactTypeRepository;
        }

        public ICollection<ContactType> GetListByName(string name)
        {
            return contactTypeRepository.GetListByName(name);
        }
    }
}
