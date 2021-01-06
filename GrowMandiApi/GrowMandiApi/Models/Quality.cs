using System;
using System.Collections.Generic;

namespace GrowMandiApi.Models
{
    public partial class Quality
    {
        public int Id { get; set; }
        public int? CategoryId { get; set; }
        public string Title { get; set; }
        public int? ControlType { get; set; }
        public string DefaultValue { get; set; }
        public bool? IsMandatory { get; set; }
        public string OptionList { get; set; }
        public bool? IsActive { get; set; }
    }
}
