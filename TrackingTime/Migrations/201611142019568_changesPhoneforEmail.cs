namespace TrackingTime.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changesPhoneforEmail : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customer", "Email", c => c.String());
            DropColumn("dbo.Customer", "Phone");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customer", "Phone", c => c.String());
            DropColumn("dbo.Customer", "Email");
        }
    }
}
