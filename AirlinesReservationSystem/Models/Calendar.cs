using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AirlinesReservationSystem.Models
{
    public class Calendar
    {
        [Key]
        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Day Date")]
        public DateTime day_date { get; set; }

        [Required]
        [Display(Name = "Day Number")]
        public int day_number { get; set; }

        [Required]
        [StringLength(1)]
        [Display(Name = "Business Day(Y/N)")]
        public string business_day_yn { get; set; }

        //public virtual ICollection<FlightCost> FlightCosts { get; set; }
    }
}