namespace Traveling_Tiffany.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Reviews : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Reviews", "FirstName", c => c.String());
            AddColumn("dbo.Reviews", "LastName", c => c.String());
            DropColumn("dbo.Reviews", "Name");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Reviews", "Name", c => c.String());
            DropColumn("dbo.Reviews", "LastName");
            DropColumn("dbo.Reviews", "FirstName");
        }
    }
}
