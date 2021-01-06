using System;
using System.Collections.Generic;

namespace GrowMandiApi.Models
{
    public partial class UsersAddress
    {
        public int TrId { get; set; }
        public string RetailerId { get; set; }
        public string MobileNumberForOnline { get; set; }
        public string ReciverName { get; set; }
        public string ShipAddress { get; set; }
        public string City { get; set; }
        public string Pincode { get; set; }
        public string ShipMobile { get; set; }
        public string EmailId { get; set; }
        public string PanNumber { get; set; }
        public DateTime? TrDate { get; set; }
        public bool? IsPermanentAddress { get; set; }
        public bool? IsMandiUser { get; set; }
        public bool? IsActive { get; set; }
        public string MobileNumberForMandi { get; set; }

        public virtual MandiUserInfo MobileNumberForMandiNavigation { get; set; }
        public virtual UserInfo MobileNumberForOnlineNavigation { get; set; }
    }
}
