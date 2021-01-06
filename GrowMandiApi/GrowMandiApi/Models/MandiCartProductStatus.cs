using System;
using System.Collections.Generic;

namespace GrowMandiApi.Models
{
    public partial class MandiCartProductStatus
    {
        public MandiCartProductStatus()
        {
            MandiCartInfo = new HashSet<MandiCartInfo>();
        }

        public long Id { get; set; }
        public string ProductStatus { get; set; }

        public virtual ICollection<MandiCartInfo> MandiCartInfo { get; set; }
    }
}
