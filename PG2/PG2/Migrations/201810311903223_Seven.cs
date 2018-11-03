namespace PG2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Seven : DbMigration
    {
        public override void Up()
        {
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
                    })
                .PrimaryKey(t => t.LicenceNumber);
            
            CreateTable(
                "public.People",
                c => new
                    {
                        PersonID = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.PersonID);
            
        }
        
        public override void Down()
        {
            DropTable("public.People");
            DropTable("public.Cars");
        }
    }
}
