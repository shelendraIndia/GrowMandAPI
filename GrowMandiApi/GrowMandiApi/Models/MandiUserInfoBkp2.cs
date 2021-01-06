using System;
using System.Collections.Generic;

namespace GrowMandiApi.Models
{
    public partial class MandiUserInfoBkp2
    {
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
    }
}
