using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AirlinesReservationSystem.Models
{
    public class TravelClass
    {
        [Key]
        [Required]
        [Display(Name = "Travel Class Code")]
        [StringLength(1)]
        [Column(TypeName = "varchar")]
        public string travel_class_code { get; set; }

        [Required]
        [StringLength(90)]
        [Column(TypeName = "varchar")]
        [Display(Name = "Description")]
        public string travel_class_description { get; set; }

        public virtual ICollection<ItineraryReservation> ItineraryReservations { get; set; }
    }
}