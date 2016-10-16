namespace ZenithWebSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedModels : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Activities", "ActivityDescription", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Activities", "ActivityDescription", c => c.String());
        }
    }
}
