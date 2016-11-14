namespace TrackingTime.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.CustomerId);
            
            CreateTable(
                "dbo.Projects",
                c => new
                    {
                        ProjectId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.ProjectId);
            
            CreateTable(
                "dbo.TimeActivities",
                c => new
                    {
                        TimeActivityId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.TimeActivityId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TimeActivities");
            DropTable("dbo.Projects");
            DropTable("dbo.Customers");
        }
    }
}
