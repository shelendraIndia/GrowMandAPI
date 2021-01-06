using System;
using System.Collections.Generic;

namespace GrowMandiApi.Models
{
    public partial class OrderProductDetails
    {
        public int TrId { get; set; }
        public int? OrderId { get; set; }
        public string ProductId { get; set; }
        public string Qty { get; set; }
        public string Price { get; set; }
        public DateTime? TrDate { get; set; }
        public string SapOrderId { get; set; }

        public virtual OrderDetails Order { get; set; }
    }
}
