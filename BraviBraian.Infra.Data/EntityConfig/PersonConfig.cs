using BraviBraian.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace BraviBraian.Infra.Data.EntityConfig
{
    public class PersonConfig : EntityTypeConfiguration<Person>
    {
        public PersonConfig()
        {
            //Key
            HasKey(i => i.Id);

            //Collums
            Property(i => i.Name)
                .IsRequired()
                .HasMaxLength(150);
        }
    }
}
