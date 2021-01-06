using System;
using System.Collections.Generic;

namespace GrowMandiApi.Models
{
    public partial class UserOtpinfo
    {
        public int SerialNumber { get; set; }
        public string MobileNumber { get; set; }
        public string Otp { get; set; }
        public DateTime? GenratedDate { get; set; }
    }
}
