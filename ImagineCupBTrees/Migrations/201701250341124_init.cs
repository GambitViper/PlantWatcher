namespace ImagineCupBTrees.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Devices",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50),
                        IsOn = c.Boolean(nullable: false),
                        SetState = c.Boolean(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SensorReadings",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        TemperatureF = c.Double(nullable: false),
                        Humidity = c.Double(nullable: false),
                        Lux = c.Double(nullable: false),
                        SoilMoisture = c.Double(nullable: false),
                        FoggerOn = c.Boolean(nullable: false),
                        BoilerOn = c.Boolean(nullable: false),
                        BonsaiOn = c.Boolean(nullable: false),
                        DateAdded = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SensorReadings");
            DropTable("dbo.Devices");
        }
    }
}
