namespace PG2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Six : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("public.Cars", "Person_PersonID", "public.People");
            DropIndex("public.Cars", new[] { "Person_PersonID" });
            DropTable("public.Cars");
            DropTable("public.People");
        }
        
        public override void Down()
        {
            CreateTable(
                "public.People",
                c => new
                    {
                        PersonID = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.PersonID);
            
            CreateTable(
                "public.Cars",
                c => new
                    {
                        LicenceNumber = c.String(nullable: false, maxLength: 128),
                        Insurance = c.String(),
                        Hu = c.String(),
                        Nya = c.String(),
                        GBT = c.String(),
                        LGBT = c.Int(nullable: false),
                        Year = c.Int(),
                        Person_PersonID = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.LicenceNumber);
            
            CreateIndex("public.Cars", "Person_PersonID");
            AddForeignKey("public.Cars", "Person_PersonID", "public.People", "PersonID");
        }
    }
}
