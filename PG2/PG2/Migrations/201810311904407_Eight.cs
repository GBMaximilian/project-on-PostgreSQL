namespace PG2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Eight : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "public.PersonCars",
                c => new
                    {
                        Person_PersonID = c.String(nullable: false, maxLength: 128),
                        Car_LicenceNumber = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.Person_PersonID, t.Car_LicenceNumber })
                .ForeignKey("public.People", t => t.Person_PersonID, cascadeDelete: true)
                .ForeignKey("public.Cars", t => t.Car_LicenceNumber, cascadeDelete: true)
                .Index(t => t.Person_PersonID)
                .Index(t => t.Car_LicenceNumber);
            
        }
        
        public override void Down()
        {
            DropForeignKey("public.PersonCars", "Car_LicenceNumber", "public.Cars");
            DropForeignKey("public.PersonCars", "Person_PersonID", "public.People");
            DropIndex("public.PersonCars", new[] { "Car_LicenceNumber" });
            DropIndex("public.PersonCars", new[] { "Person_PersonID" });
            DropTable("public.PersonCars");
        }
    }
}
