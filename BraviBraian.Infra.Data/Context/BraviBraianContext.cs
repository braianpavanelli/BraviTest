using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using BraviBraian.Domain.Entities;
using BraviBraian.Infra.Data.EntityConfig;

namespace BraviBraian.Infra.Data.Context
{
    public class BraviBraianContext : DbContext
    {
        public BraviBraianContext() : base("DefaultConnection")
        {

        }

        public DbSet<Person> People { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<ContactType> ContactTypes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            //modelBuilder.Conventions.Add<OneToManyCascadeDeleteConvention>();

            modelBuilder.Configurations.Add(new PersonConfig());
            modelBuilder.Configurations.Add(new ContactConfig());
            modelBuilder.Configurations.Add(new ContactTypeConfig());

            base.OnModelCreating(modelBuilder);
        }
    }
}
