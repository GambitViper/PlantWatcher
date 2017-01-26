namespace ImagineCupBTrees.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedDateRecordedtoDevice : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Devices", "DateRecorded", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Devices", "DateRecorded");
        }
    }
}
