using System;
using System.Collections.Generic;

namespace GrowMandiApi.Models
{
    public partial class UserWallet
    {
        public long Id { get; set; }
        public string WalletBalance { get; set; }
        public string MobileNumber { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool? Status { get; set; }

        public virtual UserInfo MobileNumberNavigation { get; set; }
    }
}
