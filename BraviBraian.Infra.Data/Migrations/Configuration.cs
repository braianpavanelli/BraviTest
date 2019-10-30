namespace BraviBraian.Infra.Data.Migrations
{
    using BraviBraian.Domain.Entities;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<Context.BraviBraianContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Context.BraviBraianContext context)
        {
            context.ContactTypes.AddOrUpdate(new ContactType { Id = 1, Name = "Phone"}, new ContactType { Id = 2, Name = "Email" }, new ContactType { Id = 3, Name = "WhatsApp" });
        }
    }
}
