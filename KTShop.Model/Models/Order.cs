using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KTShop.Model.Models
{
    [Table("Orders")]
    public class Order
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int ID { get; set; }

        [Required]
        [MaxLength(250)]
        public string CustomerName { get; set; }

        [Required]
        [MaxLength(250)]
        public string CustomerAddress { get; set; }

        [Required]
        [MaxLength(250)]
        public string CustomerEmail { get; set; }

        [Required]
        [MaxLength(250)]
        public string CustomerMobile { get; set; }

        [Required]
        [MaxLength(250)]
        public string CustomerMessage { get; set; }

        
        public DateTime? CreatedDate { set; get; }

        public string CreatedBy { set; get; }
        public string PaymentMethod { get; set; }

        [MaxLength(250)]
        public string PaymentStatus { get; set; }

        public virtual IEnumerable<Order> Orders { get; set; }
    }
}