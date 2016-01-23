using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AirlinesReservationSystem.Models
{
    public class ItineraryReservation
    {
        [Key]
        [Required]
        [StringLength(5)]
        [Column(TypeName = "varchar")]
        [Display(Name = "Reservation Id")]
        public string reservation_id { get; set; }

        [Required]
        [StringLength(5)]
        [Column(TypeName = "varchar")]
        [Display(Name = "Agent Id")]
        public string agent_id { get; set; }
        [ForeignKey("agent_id")]
        public BookingAgent BookingAgent { get; set; }

        [Required]
        [Display(Name = "Passenger Id")]
        public int passenger_id { get; set; }
        [ForeignKey("passenger_id")]
        public Passenger Passenger { get; set; }

        [StringLength(2)]
        [Column(TypeName = "varchar")]
        [Display(Name = "Reservation Status Code")]
        public string reservation_status_code { get; set; }
        [ForeignKey("reservation_status_code")]
        public ReservationStatus ReservationStatus { get; set; }

        [StringLength(2)]
        [Column(TypeName = "varchar")]
        [Display(Name = "Booking Status Code")]
        public string booking_status_code { get; set; }
        [ForeignKey("booking_status_code")]
        public BookingStatus BookingStatus { get; set; }

        [StringLength(4)]
        [Column(TypeName = "varchar")]
        [Display(Name = "Payment Status Code")]
        public string payment_status_code { get; set; }
        [ForeignKey("payment_status_code")]
        public PaymentStatus PaymentStatus { get; set; }

        [StringLength(3)]
        [Column(TypeName = "varchar")]
        [Display(Name = "Ticket Type Code")]
        public string ticket_type_code { get; set; }
        [ForeignKey("ticket_type_code")]
        public TicketType TicketType { get; set; }

        [Required]
        [Display(Name = "Travel Class Code")]
        public string travel_class_code { get; set; }
        [ForeignKey("travel_class_code")]
        public TravelClass TravelClass { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Date Reservation Made")]
        public DateTime date_reservation_made { get; set; }

        public virtual ICollection<ItineraryLeg> ItineraryLegs { get; set; }
        public virtual ICollection<ReservationPayment> ReservationPayments { get; set; }
    }
}