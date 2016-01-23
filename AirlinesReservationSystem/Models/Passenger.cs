using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AirlinesReservationSystem.Models
{
    public class Passenger
    {
        [Key]
        [Required]
        [Display(Name = "Passenger Id")]
        public int passenger_id { get; set; }

        [Required]
        [StringLength(50)]
        [Column(TypeName = "varchar")]
        [Display(Name = "First Name")]
        public string first_name { get; set; }

        [Required]
        [StringLength(50)]
        [Column(TypeName = "varchar")]
        [Display(Name = "Middle Name")]
        public string middle_name { get; set; }

        [Required]
        [StringLength(50)]
        [Column(TypeName = "varchar")]
        [Display(Name = "Last Name")]
        public string last_name { get; set; }

        [Required]
        [StringLength(15)]
        [Column(TypeName = "varchar")]
        [Display(Name = "Phone Number")]
        public string phone_number { get; set; }

        [Required]
        [StringLength(50)]
        [Column(TypeName = "varchar")]
        [Display(Name = "Email Address")]
        public string email_address { get; set; }

        [Required]
        [StringLength(50)]
        [Column(TypeName = "varchar")]
        [Display(Name = "Address")]
        public string address_lines { get; set; }

        [Required]
        [StringLength(50)]
        [Column(TypeName = "varchar")]
        [Display(Name = "City")]
        public string city { get; set; }

        [Required]
        [StringLength(50)]
        [Column(TypeName = "varchar")]
        [Display(Name = "State/Province/County")]
        public string state_province_county { get; set; }

        [Required]
        [StringLength(50)]
        [Column(TypeName = "varchar")]
        [Display(Name = "Country")]
        public string country { get; set; }

        [Required]
        [StringLength(50)]
        [Column(TypeName = "varchar")]
        [Display(Name = "Passenger Details")]
        public string other_passenger_details { get; set; }

        public virtual ICollection<ItineraryReservation> ItinearyReservations { get; set; }
    }
}