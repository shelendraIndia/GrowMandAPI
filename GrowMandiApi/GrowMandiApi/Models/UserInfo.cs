using System;
using System.Collections.Generic;

namespace GrowMandiApi.Models
{
    public partial class UserInfo
    {
        public UserInfo()
        {
            OrderDetails = new HashSet<OrderDetails>();
            OrderErrorLogDetails = new HashSet<OrderErrorLogDetails>();
            UserFeedback = new HashSet<UserFeedback>();
            UserWallet = new HashSet<UserWallet>();
            UsersAddress = new HashSet<UsersAddress>();
        }

        public string UserCode { get; set; }
        public string UserPassword { get; set; }
        public string RetailerName { get; set; }
        public string Address { get; set; }
        public string GeoAddress { get; set; }
        public string Town { get; set; }
        public string Cstnnumber { get; set; }
        public string Vatnumber { get; set; }
        public string Pannumber { get; set; }
        public string LicenseNumber { get; set; }
        public string Imeinumber { get; set; }
        public DateTime? EntryDate { get; set; }
        public string Pincode { get; set; }
        public DateTime? SeedLicenseValidity { get; set; }
        public string Gstnumber { get; set; }
        public string Depo { get; set; }
        public string Flag { get; set; }
        public string SapRetailerIdFcmToken { get; set; }
        public string FcmSubscriptionTopic { get; set; }
        public string BankAccountNumber { get; set; }
        public DateTime? BirthDate { get; set; }
        public string RetailerLastName { get; set; }
        public string HouseNumber { get; set; }
        public string StreetLine1 { get; set; }
        public string StreetLine2 { get; set; }
        public string UserCompany { get; set; }
        public string Type { get; set; }
        public string MobileNumber { get; set; }
        public string Name { get; set; }
        public string EmailId { get; set; }
        public string State { get; set; }
        public string District { get; set; }
        public string Taluka { get; set; }
        public string Village { get; set; }
        public string FirmName { get; set; }
        public bool? IsProfileUpdated { get; set; }
        public string RetailerId { get; set; }

        public virtual ICollection<OrderDetails> OrderDetails { get; set; }
        public virtual ICollection<OrderErrorLogDetails> OrderErrorLogDetails { get; set; }
        public virtual ICollection<UserFeedback> UserFeedback { get; set; }
        public virtual ICollection<UserWallet> UserWallet { get; set; }
        public virtual ICollection<UsersAddress> UsersAddress { get; set; }
    }
}
