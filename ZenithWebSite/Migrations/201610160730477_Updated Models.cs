namespace ZenithWebSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedModels : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Events", "Activity_ActivityId", "dbo.Activities");
            DropIndex("dbo.Events", new[] { "Activity_ActivityId" });
            RenameColumn(table: "dbo.Events", name: "Activity_ActivityId", newName: "ActivityId");
            AlterColumn("dbo.Activities", "ActivityDescription", c => c.String(nullable: false));
            AlterColumn("dbo.Events", "ActivityId", c => c.Int(nullable: false));
            CreateIndex("dbo.Events", "ActivityId");
            AddForeignKey("dbo.Events", "ActivityId", "dbo.Activities", "ActivityId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Events", "ActivityId", "dbo.Activities");
            DropIndex("dbo.Events", new[] { "ActivityId" });
            AlterColumn("dbo.Events", "ActivityId", c => c.Int());
            AlterColumn("dbo.Activities", "ActivityDescription", c => c.String());
            RenameColumn(table: "dbo.Events", name: "ActivityId", newName: "Activity_ActivityId");
            CreateIndex("dbo.Events", "Activity_ActivityId");
            AddForeignKey("dbo.Events", "Activity_ActivityId", "dbo.Activities", "ActivityId");
        }
    }
}
