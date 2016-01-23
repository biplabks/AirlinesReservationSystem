using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AirlinesReservationSystem.Models
{
    public class FlightSchedule
    {
        [Key]
        [Required]
        [StringLength(4)]
        [Column(TypeName = "varchar")]
        [Display(Name = "Flight Number")]
        public string flight_number { get; set; }

        [Required]
        [StringLength(2)]
        [Column(TypeName = "varchar")]
        [Display(Name = "Airline Code")]
        public string airline_code { get; set; }
        [ForeignKey("airline_code")]
        public Airline Airline { get; set; }

        [Required]
        [StringLength(3)]
        [Column(TypeName = "varchar")]
        [Display(Name = "Aircraft Type Code")]
        public string usual_aircraft_type_code { get; set; }
        [ForeignKey("usual_aircraft_type_code")]
        public AircraftType AircraftType { get; set; }

        [Required]
        [StringLength(3)]
        [Column(TypeName = "varchar")]
        [Display(Name = "Origin Airport Code")]
        public string origin_airport_code { get; set; }
        [ForeignKey("origin_airport_code")]
        public Airport Airport { get; set; }

        [Required]
        [StringLength(3)]
        [Column(TypeName = "varchar")]
        [Display(Name = "Destination Airport Code")]
        public string destination_airport_code { get; set; }
        [ForeignKey("destination_airport_code")]
        public Airport Airport1 { get; set; }

        [Display(Name = "Departure Date Time")]
        public DateTime departure_date_time { get; set; }

        [Display(Name = "Arrival Date Time")]
        public DateTime arrival_date_time { get; set; }

        public virtual ICollection<FlightCost> FlightCosts { get; set; }
        public virtual ICollection<Leg> Legs { get; set; }
    }
}