using System;
using System.Collections.Generic;

namespace GrowMandiApi.Models
{
    public partial class UserFeedback
    {
        public int TrId { get; set; }
        public string Usercode { get; set; }
        public string Product { get; set; }
        public string Feedback { get; set; }
        public DateTime? TrDate { get; set; }

        public virtual UserInfo UsercodeNavigation { get; set; }
    }
}
