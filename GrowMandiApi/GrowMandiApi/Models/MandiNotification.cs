using System;
using System.Collections.Generic;

namespace GrowMandiApi.Models
{
    public partial class MandiNotification
    {
        public int SerialNumber { get; set; }
        public string MobileNumber { get; set; }
        public string Message { get; set; }
        public DateTime? TrDate { get; set; }
    }
}
