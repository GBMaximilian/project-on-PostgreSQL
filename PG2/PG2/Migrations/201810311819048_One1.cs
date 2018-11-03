namespace PG2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class One1 : DbMigration
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
                        Year = c.Int(),
                    })
                .PrimaryKey(t => t.LicenceNumber);
            
        }
        
        public override void Down()
        {
            DropTable("public.Cars");
        }
    }
}
