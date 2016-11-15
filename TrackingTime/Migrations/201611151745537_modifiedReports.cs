namespace TrackingTime.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modifiedReports : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Report",
                c => new
                    {
                        ReportId = c.Int(nullable: false, identity: true),
                        StarDateTime = c.DateTime(nullable: false),
                        EndDateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ReportId);
            
            AddColumn("dbo.TimeActivity", "Report_ReportId", c => c.Int());
            AlterColumn("dbo.Project", "Status", c => c.Int(nullable: false));
            CreateIndex("dbo.TimeActivity", "Report_ReportId");
            AddForeignKey("dbo.TimeActivity", "Report_ReportId", "dbo.Report", "ReportId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TimeActivity", "Report_ReportId", "dbo.Report");
            DropIndex("dbo.TimeActivity", new[] { "Report_ReportId" });
            AlterColumn("dbo.Project", "Status", c => c.String());
            DropColumn("dbo.TimeActivity", "Report_ReportId");
            DropTable("dbo.Report");
        }
    }
}
