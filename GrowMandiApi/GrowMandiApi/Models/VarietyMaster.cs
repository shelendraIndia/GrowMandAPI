using System;
using System.Collections.Generic;

namespace GrowMandiApi.Models
{
    public partial class VarietyMaster
    {
        public VarietyMaster()
        {
            MandiProductMaster = new HashSet<MandiProductMaster>();
        }

        public int VarietyId { get; set; }
        public string VarietyName { get; set; }
        public int CropId { get; set; }
        public bool? Status { get; set; }
        public string VarietyOrigin { get; set; }

        public virtual CropMaster Crop { get; set; }
        public virtual ICollection<MandiProductMaster> MandiProductMaster { get; set; }
    }
}
