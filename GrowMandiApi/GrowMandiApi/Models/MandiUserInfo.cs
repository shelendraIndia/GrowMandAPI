using System;
using System.Collections.Generic;

namespace GrowMandiApi.Models
{
    public partial class MandiUserInfo
    {
        public MandiUserInfo()
        {
            MandiInterestedProductForUser = new HashSet<MandiInterestedProductForUser>();
            MandiUserRoles = new HashSet<MandiUserRoles>();
            UserCategoryMapping = new HashSet<UserCategoryMapping>();
            UsersAddress = new HashSet<UsersAddress>();
            UsersBankAccountDetails = new HashSet<UsersBankAccountDetails>();
        }

        public string FullName { get; set; }
        public string Village { get; set; }
        public string State { get; set; }
        public string District { get; set; }
        public string Taluka { get; set; }
        public string Pincode { get; set; }
        public string UserType { get; set; }
        public string AdharId { get; set; }
        public string MobileNumber { get; set; }
        public string ProfilePictureUrl { get; set; }
        public bool? IsProfileUpdated { get; set; }
        public string DeviceToken { get; set; }
        public DateTime? CreatedDate { get; set; }

        public virtual ICollection<MandiInterestedProductForUser> MandiInterestedProductForUser { get; set; }
        public virtual ICollection<MandiUserRoles> MandiUserRoles { get; set; }
        public virtual ICollection<UserCategoryMapping> UserCategoryMapping { get; set; }
        public virtual ICollection<UsersAddress> UsersAddress { get; set; }
        public virtual ICollection<UsersBankAccountDetails> UsersBankAccountDetails { get; set; }
    }
}
