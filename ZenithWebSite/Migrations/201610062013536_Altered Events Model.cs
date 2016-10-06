namespace ZenithWebSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlteredEventsModel : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Events", "ActivityId", "dbo.Activities");
            DropIndex("dbo.Events", new[] { "ActivityId" });
            RenameColumn(table: "dbo.Events", name: "ActivityId", newName: "Activity_ActivityId");
            AddColumn("dbo.Events", "CreationDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Events", "Activity_ActivityId", c => c.Int());
            CreateIndex("dbo.Events", "Activity_ActivityId");
            AddForeignKey("dbo.Events", "Activity_ActivityId", "dbo.Activities", "ActivityId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Events", "Activity_ActivityId", "dbo.Activities");
            DropIndex("dbo.Events", new[] { "Activity_ActivityId" });
            AlterColumn("dbo.Events", "Activity_ActivityId", c => c.Int(nullable: false));
            DropColumn("dbo.Events", "CreationDate");
            RenameColumn(table: "dbo.Events", name: "Activity_ActivityId", newName: "ActivityId");
            CreateIndex("dbo.Events", "ActivityId");
            AddForeignKey("dbo.Events", "ActivityId", "dbo.Activities", "ActivityId", cascadeDelete: true);
        }
    }
}
