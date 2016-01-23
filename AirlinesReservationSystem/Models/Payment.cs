using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AirlinesReservationSystem.Models
{
    public class Payment
    {
        [Key]
        [Required]
        [Display(Name = "Payment Id")]
        public int payment_id { get; set; }

        [Required]
        [StringLength(4)]
        [Column(TypeName = "varchar")]
        [Display(Name = "Payment Status Code")]
        public string payment_status_code { get; set; }

        [Required]
        [Display(Name = "Payment Date")]
        public DateTime payment_date { get; set; }

        [Required]
        [Display(Name = "Payment Amount")]
        public decimal payment_amount { get; set; }

        public virtual ICollection<ReservationPayment> ReservationPayments { get; set; }
    }
}