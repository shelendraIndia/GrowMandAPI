using System;
using System.Collections.Generic;

namespace GrowMandiApi.Models
{
    public partial class MandiUserRoles
    {
        public int SerialNumber { get; set; }
        public string MobileNumber { get; set; }
        public int RoleId { get; set; }

        public virtual MandiUserInfo MobileNumberNavigation { get; set; }
        public virtual MandiRoles Role { get; set; }
    }
}
