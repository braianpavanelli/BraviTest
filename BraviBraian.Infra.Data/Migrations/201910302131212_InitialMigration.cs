namespace BraviBraian.Infra.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Contact",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(nullable: false, maxLength: 100),
                        IdContactType = c.Int(nullable: false),
                        IdPerson = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ContactType", t => t.IdContactType, cascadeDelete: true)
                .ForeignKey("dbo.Person", t => t.IdPerson, cascadeDelete: true)
                .Index(t => t.IdContactType)
                .Index(t => t.IdPerson);
            
            CreateTable(
                "dbo.ContactType",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Person",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 150),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Contact", "IdPerson", "dbo.Person");
            DropForeignKey("dbo.Contact", "IdContactType", "dbo.ContactType");
            DropIndex("dbo.Contact", new[] { "IdPerson" });
            DropIndex("dbo.Contact", new[] { "IdContactType" });
            DropTable("dbo.Person");
            DropTable("dbo.ContactType");
            DropTable("dbo.Contact");
        }
    }
}
