using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AirlinesReservationSystem.Models
{
    public class BookingStatus
    {
        [Key]
        [Required]
        [StringLength(2)]
        [Column(TypeName = "varchar")]
        [Display(Name = "Booking Status Code")]
        public string booking_status_code { get; set; }

        [Required]
        [StringLength(50)]
        [Column(TypeName = "varchar")]
        [Display(Name = "Description")]
        public string booking_status_description { get; set; }

        public virtual ICollection<ItineraryReservation> ItineraryReservations { get; set; }
    }
}