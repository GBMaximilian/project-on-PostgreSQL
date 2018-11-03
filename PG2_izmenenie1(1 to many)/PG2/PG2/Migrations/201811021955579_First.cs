namespace PG2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class First : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "public.Cars",
                c => new
                    {
                        LicenceNumber = c.String(nullable: false, maxLength: 128),
                        Year = c.Int(),
                        PersonID = c.Int(),
                    })
                .PrimaryKey(t => t.LicenceNumber)
                .ForeignKey("public.People", t => t.PersonID)
                .Index(t => t.PersonID);
            
            CreateTable(
                "public.People",
                c => new
                    {
                        PersonID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.PersonID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("public.Cars", "PersonID", "public.People");
            DropIndex("public.Cars", new[] { "PersonID" });
            DropTable("public.People");
            DropTable("public.Cars");
        }
    }
}
