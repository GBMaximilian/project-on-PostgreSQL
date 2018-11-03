namespace PG2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Five : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "public.People",
                c => new
                    {
                        PersonID = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                        CarLicenceNumber = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.PersonID)
                .ForeignKey("public.Cars", t => t.CarLicenceNumber)
                .Index(t => t.CarLicenceNumber);
            
        }
        
        public override void Down()
        {
            DropForeignKey("public.People", "CarLicenceNumber", "public.Cars");
            DropIndex("public.People", new[] { "CarLicenceNumber" });
            DropTable("public.People");
        }
    }
}
