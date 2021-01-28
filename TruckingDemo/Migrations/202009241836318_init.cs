namespace TruckingDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cargoes",
                c => new
                    {
                        CargoID = c.Int(nullable: false, identity: true),
                        Latitude = c.Single(nullable: false),
                        Longitude = c.Single(nullable: false),
                        CargoTrackingNumber = c.Int(nullable: false),
                        DriverID = c.Int(nullable: false),
                        LocationID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CargoID)
                .ForeignKey("dbo.Drivers", t => t.DriverID, cascadeDelete: true)
                .Index(t => t.DriverID);
            
            CreateTable(
                "dbo.Parcels",
                c => new
                    {
                        ParcelID = c.Int(nullable: false, identity: true),
                        TrackingNumber = c.Int(nullable: false),
                        CargoID = c.Int(nullable: false),
                        DestinationLat = c.Single(nullable: false),
                        DestinationLong = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.ParcelID)
                .ForeignKey("dbo.Cargoes", t => t.CargoID, cascadeDelete: true)
                .Index(t => t.CargoID);
            
            CreateTable(
                "dbo.Drivers",
                c => new
                    {
                        DriverID = c.Int(nullable: false, identity: true),
                        DriverName = c.String(),
                        Latitude = c.Single(nullable: false),
                        Longitude = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.DriverID);
            
            CreateTable(
                "dbo.Locations",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ScheduledTime = c.DateTime(nullable: false),
                        isPickUp = c.Boolean(nullable: false),
                        Latitude = c.Double(nullable: false),
                        Longitude = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.PickupLocations",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ScheduledTime = c.DateTime(nullable: false),
                        isPickUp = c.Boolean(nullable: false),
                        Latitude = c.Double(nullable: false),
                        Longitude = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cargoes", "DriverID", "dbo.Drivers");
            DropForeignKey("dbo.Parcels", "CargoID", "dbo.Cargoes");
            DropIndex("dbo.Parcels", new[] { "CargoID" });
            DropIndex("dbo.Cargoes", new[] { "DriverID" });
            DropTable("dbo.PickupLocations");
            DropTable("dbo.Locations");
            DropTable("dbo.Drivers");
            DropTable("dbo.Parcels");
            DropTable("dbo.Cargoes");
        }
    }
}
