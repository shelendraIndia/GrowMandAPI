using System;
using System.Collections.Generic;

namespace GrowMandiApi.Models
{
    public partial class OrderErrorLogDetails
    {
        public int TrId { get; set; }
        public string RetailerId { get; set; }
        public string RetailerMobile { get; set; }
        public string PaymentMode { get; set; }
        public string TotalPrice { get; set; }
        public string Qty { get; set; }
        public string CsvFile { get; set; }
        public string ErrorMsg { get; set; }
        public DateTime? TrDate { get; set; }

        public virtual UserInfo RetailerMobileNavigation { get; set; }
    }
}
