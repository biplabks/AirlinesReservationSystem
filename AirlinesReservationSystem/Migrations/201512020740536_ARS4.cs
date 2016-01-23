namespace AirlinesReservationSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ARS4 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.FlightSchedules", "AircraftType_aircraft_type_code", "dbo.AircraftTypes");
            DropIndex("dbo.FlightSchedules", new[] { "AircraftType_aircraft_type_code" });
            DropColumn("dbo.FlightSchedules", "usual_aircraft_type_code");
            RenameColumn(table: "dbo.FlightSchedules", name: "AircraftType_aircraft_type_code", newName: "usual_aircraft_type_code");
            AlterColumn("dbo.FlightSchedules", "usual_aircraft_type_code", c => c.String(nullable: false, maxLength: 3, unicode: false));
            CreateIndex("dbo.FlightSchedules", "usual_aircraft_type_code");
            CreateIndex("dbo.FlightSchedules", "origin_airport_code");
            CreateIndex("dbo.FlightSchedules", "destination_airport_code");
            AddForeignKey("dbo.FlightSchedules", "origin_airport_code", "dbo.Airports", "airport_code", cascadeDelete: true);
            AddForeignKey("dbo.FlightSchedules", "destination_airport_code", "dbo.Airports", "airport_code", cascadeDelete: false);
            AddForeignKey("dbo.FlightSchedules", "usual_aircraft_type_code", "dbo.AircraftTypes", "aircraft_type_code", cascadeDelete: false);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.FlightSchedules", "usual_aircraft_type_code", "dbo.AircraftTypes");
            DropForeignKey("dbo.FlightSchedules", "destination_airport_code", "dbo.Airports");
            DropForeignKey("dbo.FlightSchedules", "origin_airport_code", "dbo.Airports");
            DropIndex("dbo.FlightSchedules", new[] { "destination_airport_code" });
            DropIndex("dbo.FlightSchedules", new[] { "origin_airport_code" });
            DropIndex("dbo.FlightSchedules", new[] { "usual_aircraft_type_code" });
            AlterColumn("dbo.FlightSchedules", "usual_aircraft_type_code", c => c.String(maxLength: 3, unicode: false));
            RenameColumn(table: "dbo.FlightSchedules", name: "usual_aircraft_type_code", newName: "AircraftType_aircraft_type_code");
            AddColumn("dbo.FlightSchedules", "usual_aircraft_type_code", c => c.String(nullable: false, maxLength: 3, unicode: false));
            CreateIndex("dbo.FlightSchedules", "AircraftType_aircraft_type_code");
            AddForeignKey("dbo.FlightSchedules", "AircraftType_aircraft_type_code", "dbo.AircraftTypes", "aircraft_type_code");
        }
    }
}
