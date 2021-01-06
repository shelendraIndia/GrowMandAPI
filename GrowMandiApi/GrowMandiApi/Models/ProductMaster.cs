using System;
using System.Collections.Generic;

namespace GrowMandiApi.Models
{
    public partial class ProductMaster
    {
        public int SkuId { get; set; }
        public string SkuName { get; set; }
        public string ItemCode { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
        public string CurrentQuantity { get; set; }
        public DateTime? SkuCreatedDate { get; set; }
        public string Gstpercent { get; set; }
        public string ImageUrl { get; set; }
        public string MinQuantittyToBook { get; set; }
        public string MaxQuantittyToBook { get; set; }
        public string PrdCompanyName { get; set; }
        public int? AllowSaporder { get; set; }
        public string PrdState { get; set; }
        public string Status { get; set; }
    }
}
