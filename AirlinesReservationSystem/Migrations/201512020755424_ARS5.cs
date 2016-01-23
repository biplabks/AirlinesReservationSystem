namespace AirlinesReservationSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ARS5 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ItineraryReservations", "TravelClass_travel_class_code", "dbo.TravelClasses");
            DropIndex("dbo.ItineraryReservations", new[] { "TravelClass_travel_class_code" });
            RenameColumn(table: "dbo.ItineraryReservations", name: "TravelClass_travel_class_code", newName: "travel_class_code");
            AlterColumn("dbo.ItineraryReservations", "travel_class_code", c => c.String(nullable: false, maxLength: 1, unicode: false));
            CreateIndex("dbo.ItineraryReservations", "travel_class_code");
            AddForeignKey("dbo.ItineraryReservations", "travel_class_code", "dbo.TravelClasses", "travel_class_code", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ItineraryReservations", "travel_class_code", "dbo.TravelClasses");
            DropIndex("dbo.ItineraryReservations", new[] { "travel_class_code" });
            AlterColumn("dbo.ItineraryReservations", "travel_class_code", c => c.String(maxLength: 1, unicode: false));
            RenameColumn(table: "dbo.ItineraryReservations", name: "travel_class_code", newName: "TravelClass_travel_class_code");
            CreateIndex("dbo.ItineraryReservations", "TravelClass_travel_class_code");
            AddForeignKey("dbo.ItineraryReservations", "TravelClass_travel_class_code", "dbo.TravelClasses", "travel_class_code");
        }
    }
}
