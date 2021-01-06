using System;
using System.Collections.Generic;

namespace GrowMandiApi.Models
{
    public partial class MandiBanner
    {
        public long Id { get; set; }
        public string BannerTitle { get; set; }
        public string Description { get; set; }
        public string BannerImage { get; set; }
        public bool? IsDefault { get; set; }
        public bool? IsActive { get; set; }
        public string ImageType { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
