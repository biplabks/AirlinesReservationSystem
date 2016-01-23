using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AirlinesReservationSystem.Models
{
    public class BookingAgent
    {
        [Key]
        [Required]
        [StringLength(5)]
        [Column(TypeName = "varchar")]
        [Display(Name = "Agent Id")]
        public string agent_id { get; set; }

        [Required]
        [StringLength(50)]
        [Column(TypeName = "varchar")]
        [Display(Name = "Name")]
        public string agent_name { get; set; }

        [StringLength(50)]
        [Column(TypeName = "varchar")]
        [Display(Name = "Details")]
        public string agent_details { get; set; }

        public virtual ICollection<ItineraryReservation> ItineraryReservations { get; set; }
    }
}