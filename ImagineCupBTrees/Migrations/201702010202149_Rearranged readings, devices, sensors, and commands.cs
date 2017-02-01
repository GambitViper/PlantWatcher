namespace ImagineCupBTrees.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Rearrangedreadingsdevicessensorsandcommands : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DeviceReadings",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        DeviceId = c.Int(nullable: false),
                        ReadingId = c.Long(nullable: false),
                        Value = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Devices", t => t.DeviceId, cascadeDelete: true)
                .ForeignKey("dbo.Readings", t => t.ReadingId, cascadeDelete: true)
                .Index(t => t.DeviceId)
                .Index(t => t.ReadingId);
            
            CreateTable(
                "dbo.Readings",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        DateRecorded = c.DateTime(nullable: false),
                        UserName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Sensors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 500),
                        Description = c.String(maxLength: 1000),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Devices", "Description", c => c.String(maxLength: 1000));
            AddColumn("dbo.SensorReadings", "SensorId", c => c.Int(nullable: false));
            AddColumn("dbo.SensorReadings", "ReadingId", c => c.Long(nullable: false));
            AddColumn("dbo.SensorReadings", "Value", c => c.Double(nullable: false));
            AlterColumn("dbo.Devices", "Name", c => c.String(maxLength: 500));
            CreateIndex("dbo.SensorReadings", "SensorId");
            CreateIndex("dbo.SensorReadings", "ReadingId");
            AddForeignKey("dbo.SensorReadings", "ReadingId", "dbo.Readings", "Id", cascadeDelete: true);
            AddForeignKey("dbo.SensorReadings", "SensorId", "dbo.Sensors", "Id", cascadeDelete: true);
            DropColumn("dbo.Devices", "IsOn");
            DropColumn("dbo.Devices", "SetState");
            DropColumn("dbo.Devices", "DateRecorded");
            DropColumn("dbo.SensorReadings", "TemperatureF");
            DropColumn("dbo.SensorReadings", "Humidity");
            DropColumn("dbo.SensorReadings", "Lux");
            DropColumn("dbo.SensorReadings", "SoilMoisture");
            DropColumn("dbo.SensorReadings", "FoggerOn");
            DropColumn("dbo.SensorReadings", "BoilerOn");
            DropColumn("dbo.SensorReadings", "BonsaiOn");
            DropColumn("dbo.SensorReadings", "DateAdded");
        }
        
        public override void Down()
        {
            AddColumn("dbo.SensorReadings", "DateAdded", c => c.DateTime(nullable: false));
            AddColumn("dbo.SensorReadings", "BonsaiOn", c => c.Boolean(nullable: false));
            AddColumn("dbo.SensorReadings", "BoilerOn", c => c.Boolean(nullable: false));
            AddColumn("dbo.SensorReadings", "FoggerOn", c => c.Boolean(nullable: false));
            AddColumn("dbo.SensorReadings", "SoilMoisture", c => c.Double(nullable: false));
            AddColumn("dbo.SensorReadings", "Lux", c => c.Double(nullable: false));
            AddColumn("dbo.SensorReadings", "Humidity", c => c.Double(nullable: false));
            AddColumn("dbo.SensorReadings", "TemperatureF", c => c.Double(nullable: false));
            AddColumn("dbo.Devices", "DateRecorded", c => c.DateTime(nullable: false));
            AddColumn("dbo.Devices", "SetState", c => c.Boolean());
            AddColumn("dbo.Devices", "IsOn", c => c.Boolean(nullable: false));
            DropForeignKey("dbo.SensorReadings", "SensorId", "dbo.Sensors");
            DropForeignKey("dbo.SensorReadings", "ReadingId", "dbo.Readings");
            DropForeignKey("dbo.DeviceReadings", "ReadingId", "dbo.Readings");
            DropForeignKey("dbo.DeviceReadings", "DeviceId", "dbo.Devices");
            DropIndex("dbo.SensorReadings", new[] { "ReadingId" });
            DropIndex("dbo.SensorReadings", new[] { "SensorId" });
            DropIndex("dbo.DeviceReadings", new[] { "ReadingId" });
            DropIndex("dbo.DeviceReadings", new[] { "DeviceId" });
            AlterColumn("dbo.Devices", "Name", c => c.String(maxLength: 50));
            DropColumn("dbo.SensorReadings", "Value");
            DropColumn("dbo.SensorReadings", "ReadingId");
            DropColumn("dbo.SensorReadings", "SensorId");
            DropColumn("dbo.Devices", "Description");
            DropTable("dbo.Sensors");
            DropTable("dbo.Readings");
            DropTable("dbo.DeviceReadings");
        }
    }
}
