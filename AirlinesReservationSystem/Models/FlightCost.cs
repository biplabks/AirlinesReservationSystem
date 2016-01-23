using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AirlinesReservationSystem.Models
{
    public class FlightCost
    {
        [Key]
        [Required]
        [StringLength(4)]
        [Column(TypeName = "varchar", Order = 0)]
        [Display(Name = "Flight Number")]
        public string flight_number { get; set; }

        [Key]
        [Required]
        [StringLength(3)]
        [Column(TypeName = "varchar", Order = 1)]
        [Display(Name = "Aircraft Type Code")]
        public string aircraft_type_code { get; set; }
        [ForeignKey("aircraft_type_code")]
        public AircraftType AirraftType { get; set; }

        [Key]
        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Valid From Date")]
        [Column(Order = 2)]
        public DateTime valid_from_date { get; set; }
        [ForeignKey("valid_from_date")]
        public Calendar Calendar { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Valid To Date")]
        public DateTime valid_to_date { get; set; }
        [ForeignKey("valid_to_date")]
        public Calendar Calendar1 { get; set; }

        [Required]
        [Display(Name = "Flight Cost")]
        public decimal flight_cost { get; set; }
    }
}