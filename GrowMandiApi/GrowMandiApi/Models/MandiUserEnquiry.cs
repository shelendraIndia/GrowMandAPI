using System;
using System.Collections.Generic;

namespace GrowMandiApi.Models
{
    public partial class MandiUserEnquiry
    {
        public MandiUserEnquiry()
        {
            MandiCartInfo = new HashSet<MandiCartInfo>();
        }

        public int TrId { get; set; }
        public int? ProductId { get; set; }
        public string Enquiry { get; set; }
        public string EmailId { get; set; }
        public string MobileNumber { get; set; }
        public DateTime? TrDate { get; set; }

        public virtual ICollection<MandiCartInfo> MandiCartInfo { get; set; }
    }
}
