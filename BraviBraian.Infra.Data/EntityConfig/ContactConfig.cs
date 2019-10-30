using BraviBraian.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace BraviBraian.Infra.Data.EntityConfig
{
    public class ContactConfig : EntityTypeConfiguration<Contact>
    {
        public ContactConfig()
        {
            //Key
            HasKey(c => c.Id);

            //Collums
            Property(c => c.Description)
                .IsRequired()
                .HasMaxLength(100);

            //FK
            HasRequired(c => c.Person)
                .WithMany(p => p.Contacts)
                .HasForeignKey(c => c.IdPerson);
            HasRequired(c => c.ContactType)
                .WithMany(ct => ct.Contacts)
                .HasForeignKey(c => c.IdContactType);
        }
    }
}
