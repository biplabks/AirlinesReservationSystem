using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AirlinesReservationSystem.Models
{
    public class Airport
    {
        [Key]
        [Required]
        [StringLength(3)]
        [Column(TypeName = "varchar")]
        [Display(Name = "Airport Code")]
        public string airport_code { get; set; }

        [Required]
        [StringLength(50)]
        [Column(TypeName = "varchar")]
        [Display(Name = "Name")]
        public string airport_name { get; set; }

        [Required]
        [StringLength(50)]
        [Column(TypeName = "varchar")]
        [Display(Name = "Location")]
        public string airport_location { get; set; }

        [StringLength(50)]
        [Column(TypeName = "varchar")]
        [Display(Name = "Details")]
        public string other_details { get; set; }
        
        //public virtual ICollection<FlightSchedule> FlightSchedules { get; set; }
        //public virtual ICollection<Leg> Legs { get; set; }
    }
}