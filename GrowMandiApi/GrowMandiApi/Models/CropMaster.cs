using System;
using System.Collections.Generic;

namespace GrowMandiApi.Models
{
    public partial class CropMaster
    {
        public CropMaster()
        {
            MandiProductMaster = new HashSet<MandiProductMaster>();
            VarietyMaster = new HashSet<VarietyMaster>();
        }

        public int CropId { get; set; }
        public string CropName { get; set; }
        public string CategoryName { get; set; }
        public long? CategoryId { get; set; }
        public int? CropAvailableDays { get; set; }
        public string CropImage { get; set; }
        public string HiCropName { get; set; }
        public string MrCropName { get; set; }
        public string TeCropName { get; set; }

        public virtual Category Category { get; set; }
        public virtual ICollection<MandiProductMaster> MandiProductMaster { get; set; }
        public virtual ICollection<VarietyMaster> VarietyMaster { get; set; }
    }
}
