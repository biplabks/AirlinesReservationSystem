using AirlinesReservationSystem.Migrations;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AirlinesReservationSystem.Models
{
    public interface IApplicationDbContext
    {
        IDbSet<CheckingAccount> CheckingAccounts { get; set; }
        IDbSet<Transaction> Transactions { get; set; }

        IDbSet<AircraftType> AircraftTypes { get; set; }
        IDbSet<Airline> Airlines { get; set; }
        IDbSet<Airport> Airports { get; set; }
        IDbSet<Calendar> Calendars { get; set; }
        IDbSet<PaymentStatus> PaymentStatuses { get; set; }
        IDbSet<BookingAgent> BookingAgents { get; set; }
        IDbSet<BookingStatus> BookingStatus { get; set; }
        IDbSet<Passenger> Passengers { get; set; }
        IDbSet<Payment> Payments { get; set; }
        IDbSet<ReservationStatus> ReservationStatuses { get; set; }
        IDbSet<TicketType> TicketTypes { get; set; }
        IDbSet<TravelClass> TravelClasses { get; set; }

        IDbSet<FlightSchedule> FlightSchedules { get; set; }
        IDbSet<FlightCost> FlightCosts { get; set; }
        IDbSet<ItineraryReservation> ItineraryReservations { get; set; }
        IDbSet<ReservationPayment> ReservationPayments { get; set; }
        IDbSet<Leg> Legs { get; set; }
        IDbSet<ItineraryLeg> ItineraryLegs { get; set; }

        int SaveChanges();
    }
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>, IApplicationDbContext
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ApplicationDbContext, Configuration>());
            base.OnModelCreating(modelBuilder);
        }

        public IDbSet<CheckingAccount> CheckingAccounts { get; set; }

        public IDbSet<Transaction> Transactions { get; set; }

        public IDbSet<AircraftType> AircraftTypes { get; set; }
        public IDbSet<Airline> Airlines { get; set; }
        public IDbSet<Airport> Airports { get; set; }
        public IDbSet<Calendar> Calendars { get; set; }
        public IDbSet<PaymentStatus> PaymentStatuses { get; set; }
        public IDbSet<BookingAgent> BookingAgents { get; set; }
        public IDbSet<BookingStatus> BookingStatus { get; set; }
        public IDbSet<Passenger> Passengers { get; set; }
        public IDbSet<Payment> Payments { get; set; }
        public IDbSet<ReservationStatus> ReservationStatuses { get; set; }
        public IDbSet<TicketType> TicketTypes { get; set; }
        public IDbSet<TravelClass> TravelClasses { get; set; }

        public IDbSet<FlightSchedule> FlightSchedules { get; set; }
        public IDbSet<FlightCost> FlightCosts { get; set; }
        public IDbSet<ItineraryReservation> ItineraryReservations { get; set; }
        public IDbSet<ReservationPayment> ReservationPayments { get; set; }
        public IDbSet<Leg> Legs { get; set; }
        public IDbSet<ItineraryLeg> ItineraryLegs { get; set; }
    }

    public class FakeApplicationDbContext : IApplicationDbContext
    {
        public IDbSet<CheckingAccount> CheckingAccounts { get; set; }

        public IDbSet<Transaction> Transactions { get; set; }

        public IDbSet<AircraftType> AircraftTypes { get; set; }
        public IDbSet<Airline> Airlines { get; set; }
        public IDbSet<Airport> Airports { get; set; }
        public IDbSet<Calendar> Calendars { get; set; }
        public IDbSet<PaymentStatus> PaymentStatuses { get; set; }
        public IDbSet<BookingAgent> BookingAgents { get; set; }
        public IDbSet<BookingStatus> BookingStatus { get; set; }
        public IDbSet<Passenger> Passengers { get; set; }
        public IDbSet<Payment> Payments { get; set; }
        public IDbSet<ReservationStatus> ReservationStatuses { get; set; }
        public IDbSet<TicketType> TicketTypes { get; set; }
        public IDbSet<TravelClass> TravelClasses { get; set; }

        public IDbSet<FlightSchedule> FlightSchedules { get; set; }
        public IDbSet<FlightCost> FlightCosts { get; set; }
        public IDbSet<ItineraryReservation> ItineraryReservations { get; set; }
        public IDbSet<ReservationPayment> ReservationPayments { get; set; }
        public IDbSet<Leg> Legs { get; set; }
        public IDbSet<ItineraryLeg> ItineraryLegs { get; set; }

        public int SaveChanges()
        {
            return 0;
        }
    }
}