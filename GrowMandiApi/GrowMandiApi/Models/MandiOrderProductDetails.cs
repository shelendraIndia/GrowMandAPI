using System;
using System.Collections.Generic;

namespace GrowMandiApi.Models
{
    public partial class MandiOrderProductDetails
    {
        public int TrId { get; set; }
        public int? OrderId { get; set; }
        public int? ProductId { get; set; }
        public string TotalQuantity { get; set; }
        public int? Price { get; set; }
        public DateTime? TrDate { get; set; }
        public string SelectedQuantity { get; set; }
        public string SelectedProductPrice { get; set; }
    }
}
