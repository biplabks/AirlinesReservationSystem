using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AirlinesReservationSystem.Models
{
    public class Airline
    {
        [Key]
        [Required]
        [StringLength(2)]
        [Column(TypeName = "varchar")]
        [Display(Name = "Airline Code")]
        public string airline_code { get; set; }

        [Required]
        [StringLength(50)]
        [Column(TypeName = "varchar")]
        [Display(Name = "Name")]
        public string airline_name { get; set; }

        [Required]
        [StringLength(50)]
        [Column(TypeName = "varchar")]
        [Display(Name = "Country")]
        public string airline_country { get; set; }

        public virtual ICollection<FlightSchedule> FlightSchedules { get; set; }
    }
}