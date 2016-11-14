namespace TrackingTime.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createTablesInitial : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Customers", newName: "Customer");
            RenameTable(name: "dbo.Projects", newName: "Project");
            RenameTable(name: "dbo.TimeActivities", newName: "TimeActivity");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.TimeActivity", newName: "TimeActivities");
            RenameTable(name: "dbo.Project", newName: "Projects");
            RenameTable(name: "dbo.Customer", newName: "Customers");
        }
    }
}
