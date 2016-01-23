using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AirlinesReservationSystem.Models
{
    public class ItineraryLeg
    {
        [Key]
        [Required]
        [StringLength(5)]
        [Column(TypeName = "varchar", Order = 0)]
        [Display(Name = "Reservation Id")]
        public string reservation_id { get; set; }

        [Key]
        [Required]
        [Display(Name = "Leg Id")]
        [Column(Order = 1)]
        public int leg_id { get; set; }
    }
}