using System;
using System.Collections.Generic;

namespace BraviBraian.Domain.Entities
{
    public class Person
    {
        public int Id { get; set; }

        public virtual string Name { get; set; }

        public virtual ICollection<Contact> Contacts { get; set; }
    }
}
