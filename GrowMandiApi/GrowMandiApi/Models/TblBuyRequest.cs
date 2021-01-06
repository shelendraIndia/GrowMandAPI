using System;
using System.Collections.Generic;

namespace GrowMandiApi.Models
{
    public partial class TblBuyRequest
    {
        public int ReqId { get; set; }
        public string ApplicationType { get; set; }
        public int? ProductId { get; set; }
        public decimal? ReqPrice { get; set; }
        public decimal? ReqQty { get; set; }
        public string Unit { get; set; }
        public string TnC { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public DateTime? ValidTillDate { get; set; }
        public string BuyerId { get; set; }
        public bool? Active { get; set; }
        public string Status { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public string ApprovedByEmail { get; set; }
        public string RejectionReason { get; set; }
    }
}
