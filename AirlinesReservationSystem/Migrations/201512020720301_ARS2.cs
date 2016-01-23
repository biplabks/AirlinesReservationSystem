namespace AirlinesReservationSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ARS2 : DbMigration
    {
        public override void Up()
        {
            //DropForeignKey("dbo.FlightSchedules", "AircraftType_aircraft_type_code", "dbo.AircraftTypes");
            //DropForeignKey("dbo.FlightSchedules", "airline_code", "dbo.Airlines");
            //DropForeignKey("dbo.FlightSchedules", "Airport_airport_code", "dbo.Airports");
            //DropIndex("dbo.FlightSchedules", new[] { "airline_code" });
            //DropIndex("dbo.FlightSchedules", new[] { "AircraftType_aircraft_type_code" });
            //DropIndex("dbo.FlightSchedules", new[] { "Airport_airport_code" });
            //DropTable("dbo.AircraftTypes");
            //DropTable("dbo.FlightSchedules");
            //DropTable("dbo.Airlines");
            //DropTable("dbo.Airports");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Airports",
                c => new
                    {
                        airport_code = c.String(nullable: false, maxLength: 128),
                        airport_name = c.String(),
                        airport_location = c.String(),
                        other_details = c.String(),
                    })
                .PrimaryKey(t => t.airport_code);
            
            CreateTable(
                "dbo.Airlines",
                c => new
                    {
                        airline_code = c.String(nullable: false, maxLength: 128),
                        airline_name = c.String(),
                        airline_country = c.String(),
                    })
                .PrimaryKey(t => t.airline_code);
            
            CreateTable(
                "dbo.FlightSchedules",
                c => new
                    {
                        flight_number = c.String(nullable: false, maxLength: 128),
                        airline_code = c.String(maxLength: 128),
                        usual_aircraft_type_code = c.String(),
                        origin_airport_code = c.String(),
                        destination_airport_code = c.String(),
                        departure_date_time = c.DateTime(nullable: false),
                        arrival_date_time = c.DateTime(nullable: false),
                        AircraftType_aircraft_type_code = c.String(maxLength: 3, unicode: false),
                        Airport_airport_code = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.flight_number);
            
            CreateTable(
                "dbo.AircraftTypes",
                c => new
                    {
                        aircraft_type_code = c.String(nullable: false, maxLength: 3, unicode: false),
                        aircraft_type_name = c.String(nullable: false, maxLength: 50, unicode: false),
                        aircraft_type_capacity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.aircraft_type_code);
            
            CreateIndex("dbo.FlightSchedules", "Airport_airport_code");
            CreateIndex("dbo.FlightSchedules", "AircraftType_aircraft_type_code");
            CreateIndex("dbo.FlightSchedules", "airline_code");
            AddForeignKey("dbo.FlightSchedules", "Airport_airport_code", "dbo.Airports", "airport_code");
            AddForeignKey("dbo.FlightSchedules", "airline_code", "dbo.Airlines", "airline_code");
            AddForeignKey("dbo.FlightSchedules", "AircraftType_aircraft_type_code", "dbo.AircraftTypes", "aircraft_type_code");
        }
    }
}
