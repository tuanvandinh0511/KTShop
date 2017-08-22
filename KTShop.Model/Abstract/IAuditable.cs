using System;


namespace KTShop.Model.Abstract
{
    public interface IAuditable
    {
        DateTime? CreatedDay { get; set; }
        string CreatedBy { get; set; }
        DateTime? UpdatedDay { get; set; }
        string UpdatedBy { get; set; }
        string MetaKeyword { get; set; }
        string MetaDescriptsion { get; set; }
        bool Status { get; set; }
    }
}
