using System;

namespace MaiHienShop.Model.Abstract
{
    public interface IAudiTable
    {
        DateTime? CreatedDate { get; set; }
        string CreatedBy { get; set; }

        DateTime? UpdatedDate { get; set; }

        string UpdatedBy { get; set; }

        string MetaKeyword { get; set; }
        string MetaDescription { get; set; }

        bool Status { get; set; }
    }
}