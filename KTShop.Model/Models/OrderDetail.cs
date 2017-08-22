using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KTShop.Model.Models
{
    [Table("OrderDetail")]
    public class OrderDetail
    {
        [Key]        
        [Column(Order =1)]
        public int OrderID { get; set; }

        [ForeignKey("OrderID")]
        public virtual Order Order { get; set; }

        [Key]        
        [Column(Order = 2)]
        public int ProductID { get; set; }

        [ForeignKey("ProductID")]
        public virtual Product Product { get; set; }

        [Required]
        public int Quantity { get; set; }
    }
}