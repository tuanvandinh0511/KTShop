using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KTShop.Model.Models
{
    [Table("SupportOnlines")]
    public class SupportOnline
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [MaxLength(256)]
        public string Name { get; set; }

        [MaxLength(256) ]
        public string Department { get; set; }

        [MaxLength(256)]
        public string Skype { get; set; }

        [MaxLength(256)]
        public string Mobile { get; set; }

        [MaxLength(256)]
        public string Email { get; set; }

        [MaxLength(256)]
        public string Yahoo { get; set; }

        [MaxLength(256)]
        public string Facebook { get; set; }

       
        public bool Status { get; set; }

        public int? DisplayOrder { set; get; }
    }
}