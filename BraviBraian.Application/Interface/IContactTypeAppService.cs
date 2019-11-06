using BraviBraian.Domain.Entities;
using System.Collections.Generic;


namespace BraviBraian.Application.Interface
{
    public interface IContactTypeAppService : IAppBaseService<ContactType>
    {
        ICollection<ContactType> GetListByName(string name);
        void Delete(int id);
    }
}
