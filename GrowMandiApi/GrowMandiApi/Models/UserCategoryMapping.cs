using System;
using System.Collections.Generic;

namespace GrowMandiApi.Models
{
    public partial class UserCategoryMapping
    {
        public long Id { get; set; }
        public string FkMobileNumber { get; set; }
        public long? CategoryId { get; set; }
        public string CategoryName { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual Category Category { get; set; }
        public virtual MandiUserInfo FkMobileNumberNavigation { get; set; }
    }
}
