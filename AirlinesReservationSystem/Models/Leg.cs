using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AirlinesReservationSystem.Models
{
    public class Leg
    {
        [Key]
        [Required]
        [Display(Name = "Leg Id")]
        public int leg_id { get; set; }

        [Required]
        [StringLength(4)]
        [Column(TypeName = "varchar")]
        [Display(Name = "Flight Number")]
        public string flight_number { get; set; }

        [Required]
        [StringLength(3)]
        [Column(TypeName = "varchar")]
        [Display(Name = "Origin Airport Code")]
        public string origin_airport_code { get; set; }

        [Required]
        [StringLength(3)]
        [Column(TypeName = "varchar")]
        [Display(Name = "Destination Airport Code")]
        public string destination_airport_code { get; set; }

        [Required]
        [Display(Name = "Actual Departure Time")]
        public DateTime actual_departure_time { get; set; }

        [Required]
        [Display(Name = "Actual Arrival Time")]
        public DateTime actual_arrival_time { get; set; }

        public virtual ICollection<ItineraryLeg> ItineraryLegs { get; set; }
    }
}