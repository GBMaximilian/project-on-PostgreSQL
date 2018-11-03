namespace PG2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Two2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("public.Cars", "GBT", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("public.Cars", "GBT");
        }
    }
}
