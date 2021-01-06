using System;
using System.Collections.Generic;

namespace GrowMandiApi.Models
{
    public partial class Category
    {
        public Category()
        {
            CropMaster = new HashSet<CropMaster>();
            MandiProductMaster = new HashSet<MandiProductMaster>();
            UserCategoryMapping = new HashSet<UserCategoryMapping>();
        }

        public long CategoryId { get; set; }
        public string CategoryName { get; set; }
        public int RoleId { get; set; }
        public int? CatId { get; set; }
        public string CategoryImage { get; set; }
        public string TeCategoryName { get; set; }
        public string MrCategoryName { get; set; }
        public string HiCategoryName { get; set; }

        public virtual ICollection<CropMaster> CropMaster { get; set; }
        public virtual ICollection<MandiProductMaster> MandiProductMaster { get; set; }
        public virtual ICollection<UserCategoryMapping> UserCategoryMapping { get; set; }
    }
}
