using System;
using System.Collections.Generic;

namespace GrowMandiApi.Models
{
    public partial class ViewVarietyMaster
    {
        public int VarietyId { get; set; }
        public string VarietyName { get; set; }
        public int CropId { get; set; }
        public string CropName { get; set; }
        public long? CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string VarietyOrigin { get; set; }
        public bool? Status { get; set; }
    }
}
