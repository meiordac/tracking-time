namespace TrackingTime.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removesInitilizeMethods : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customer", "Name", c => c.String());
            AddColumn("dbo.Customer", "Contact", c => c.String());
            AddColumn("dbo.Customer", "Phone", c => c.String());
            AddColumn("dbo.Customer", "Status", c => c.String());
            AddColumn("dbo.Project", "CustomerId", c => c.Int(nullable: false));
            AddColumn("dbo.Project", "Title", c => c.String());
            AddColumn("dbo.Project", "Deadline", c => c.DateTime(nullable: false));
            AddColumn("dbo.Project", "Status", c => c.String());
            AddColumn("dbo.TimeActivity", "ProjectId", c => c.Int(nullable: false));
            AddColumn("dbo.TimeActivity", "Username", c => c.String());
            AddColumn("dbo.TimeActivity", "WorkType", c => c.String());
            AddColumn("dbo.TimeActivity", "Description", c => c.String());
            AddColumn("dbo.TimeActivity", "StartDateTime", c => c.DateTime(nullable: false));
            AddColumn("dbo.TimeActivity", "FinishDateTime", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.TimeActivity", "FinishDateTime");
            DropColumn("dbo.TimeActivity", "StartDateTime");
            DropColumn("dbo.TimeActivity", "Description");
            DropColumn("dbo.TimeActivity", "WorkType");
            DropColumn("dbo.TimeActivity", "Username");
            DropColumn("dbo.TimeActivity", "ProjectId");
            DropColumn("dbo.Project", "Status");
            DropColumn("dbo.Project", "Deadline");
            DropColumn("dbo.Project", "Title");
            DropColumn("dbo.Project", "CustomerId");
            DropColumn("dbo.Customer", "Status");
            DropColumn("dbo.Customer", "Phone");
            DropColumn("dbo.Customer", "Contact");
            DropColumn("dbo.Customer", "Name");
        }
    }
}
