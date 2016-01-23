using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AirlinesReservationSystem.Models
{
    public class PaymentStatus
    {
        [Key]
        [Required]
        [StringLength(4)]
        [Column(TypeName = "varchar")]
        [Display(Name = "Payment Status Code")]
        public string payment_status_code { get; set; }

        [Required]
        [StringLength(50)]
        [Column(TypeName = "varchar")]
        [Display(Name = "Description")]
        public string payment_status_description { get; set; }

        public virtual ICollection<ItineraryReservation> ItineraryReservations { get; set; }
    }
}