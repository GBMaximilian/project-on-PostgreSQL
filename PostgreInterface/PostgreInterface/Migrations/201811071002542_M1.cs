namespace PostgreInterface.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class M1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "public.Cars",
                c => new
                    {
                        LicenceNumber = c.String(nullable: false, maxLength: 128),
                        Year = c.Int(),
                        UserID = c.Int(),
                    })
                .PrimaryKey(t => t.LicenceNumber)
                .ForeignKey("public.Users", t => t.UserID)
                .Index(t => t.UserID);
            
            CreateTable(
                "public.Users",
                c => new
                    {
                        PersonID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.PersonID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("public.Cars", "UserID", "public.Users");
            DropIndex("public.Cars", new[] { "UserID" });
            DropTable("public.Users");
            DropTable("public.Cars");
        }
    }
}
