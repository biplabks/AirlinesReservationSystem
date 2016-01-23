using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AirlinesReservationSystem.Models
{
    public class AircraftType
    {
        [Key]
        [Required]
        [StringLength(3)]
        [Column(TypeName = "varchar")]
        [Display(Name = "Aircraft Type Code")]
        public string aircraft_type_code { get; set; }

        [Required]
        [StringLength(50)]
        [Column(TypeName = "varchar")]
        [Display(Name = "Name")]
        public string aircraft_type_name { get; set; }

        [Required]
        [Display(Name = "Capacity")]
        public int aircraft_type_capacity { get; set; }

        //public virtual ApplicationUser User { get; set; }
        //public string ApplicationUserId { get; set; }

        public virtual ICollection<FlightSchedule> FlightSchedules { get; set; }
    }
}