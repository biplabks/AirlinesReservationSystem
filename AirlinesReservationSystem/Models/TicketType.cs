using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AirlinesReservationSystem.Models
{
    public class TicketType
    {
        [Key]
        [Required]
        [StringLength(3)]
        [Column(TypeName = "varchar")]
        [Display(Name = "Ticket Type Code")]
        public string ticket_type_code { get; set; }

        [Required]
        [StringLength(50)]
        [Column(TypeName = "varchar")]
        [Display(Name = "Description")]
        public string ticket_type_description { get; set; }

        public virtual ICollection<ItineraryReservation> ItineraryReservations { get; set; }
    }
}