using System;
using System.Collections.Generic;

namespace GrowMandiApi.Models
{
    public partial class MandiRoles
    {
        public MandiRoles()
        {
            MandiUserRoles = new HashSet<MandiUserRoles>();
        }

        public int RoleId { get; set; }
        public string RoleName { get; set; }

        public virtual ICollection<MandiUserRoles> MandiUserRoles { get; set; }
    }
}
