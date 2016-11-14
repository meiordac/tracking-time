namespace TrackingTime.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changestoModelsAddRelations : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.TimeActivity", "WorkType", c => c.Int(nullable: false));
            CreateIndex("dbo.Project", "CustomerId");
            CreateIndex("dbo.TimeActivity", "ProjectId");
            AddForeignKey("dbo.Project", "CustomerId", "dbo.Customer", "CustomerId", cascadeDelete: true);
            AddForeignKey("dbo.TimeActivity", "ProjectId", "dbo.Project", "ProjectId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TimeActivity", "ProjectId", "dbo.Project");
            DropForeignKey("dbo.Project", "CustomerId", "dbo.Customer");
            DropIndex("dbo.TimeActivity", new[] { "ProjectId" });
            DropIndex("dbo.Project", new[] { "CustomerId" });
            AlterColumn("dbo.TimeActivity", "WorkType", c => c.String());
        }
    }
}
