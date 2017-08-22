using System;
using System.ComponentModel.DataAnnotations;

namespace KTShop.Model.Abstract
{
    public abstract class Auditable : IAuditable
    {

        public DateTime? CreatedDay { get; set; }
        [MaxLength(256)]
        public string CreatedBy { get; set; }
        public DateTime? UpdatedDay { get; set; }
        [MaxLength(256)]
        public string UpdatedBy { get; set; }
        [MaxLength(256)]
        public string MetaKeyword { get; set; }
        [MaxLength(256)]
        public string MetaDescriptsion { get; set; }
        public bool Status { get; set; }
    }
}