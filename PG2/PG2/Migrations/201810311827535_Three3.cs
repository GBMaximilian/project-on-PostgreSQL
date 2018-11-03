namespace PG2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Three3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("public.Cars", "LGBT", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("public.Cars", "LGBT");
        }
    }
}
