using System;
using System.Collections.Generic;

namespace GrowMandiApi.Models
{
    public partial class SubCategory
    {
        public int SubCategoryId { get; set; }
        public string SubCategoryName { get; set; }
        public string ImageUrl { get; set; }
        public long CategoryId { get; set; }

        public virtual Category Category { get; set; }
    }
}
