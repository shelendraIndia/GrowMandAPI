using System;
using System.Collections.Generic;

namespace GrowMandiApi.Models
{
    public partial class UsersBankAccountDetails
    {
        public int Id { get; set; }
        public string AccountNumber { get; set; }
        public string AccountHolderName { get; set; }
        public string BankName { get; set; }
        public string Branch { get; set; }
        public string AccountType { get; set; }
        public string UserName { get; set; }
        public string IfscCode { get; set; }
        public string MobileNumber { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool? Status { get; set; }

        public virtual MandiUserInfo MobileNumberNavigation { get; set; }
    }
}
