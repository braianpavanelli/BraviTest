using System.Collections.Generic;

namespace BraviBraian.Domain.Entities
{
    public class ContactType
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Contact> Contacts { get; set; }
    }
}