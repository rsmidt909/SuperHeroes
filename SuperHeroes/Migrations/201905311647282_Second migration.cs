namespace SuperHeroes.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Secondmigration : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Heroes", "MyProperty");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Heroes", "MyProperty", c => c.String());
        }
    }
}
