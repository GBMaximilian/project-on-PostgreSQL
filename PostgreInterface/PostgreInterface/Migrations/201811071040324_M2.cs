namespace PostgreInterface.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class M2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("public.Cars", "UserID", "public.Users");
            DropIndex("public.Cars", new[] { "UserID" });
            AddColumn("public.Users", "UserID", c => c.Int(nullable: false, identity: true));
            DropPrimaryKey("public.Users");
            AddPrimaryKey("public.Users", "UserID");
            CreateIndex("public.Cars", "UserID");
            AddForeignKey("public.Cars", "UserID", "public.Users", "UserID");
            DropColumn("public.Users", "PersonID");
        }
        
        public override void Down()
        {
            AddColumn("public.Users", "PersonID", c => c.Int(nullable: false, identity: true));
            DropForeignKey("public.Cars", "UserID", "public.Users");
            DropIndex("public.Cars", new[] { "UserID" });
            DropPrimaryKey("public.Users");
            AddPrimaryKey("public.Users", "PersonID");
            DropColumn("public.Users", "UserID");
            CreateIndex("public.Cars", "UserID");
            AddForeignKey("public.Cars", "UserID", "public.Users", "PersonID");
        }
    }
}
