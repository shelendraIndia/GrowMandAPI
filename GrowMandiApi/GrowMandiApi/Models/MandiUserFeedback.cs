using System;
using System.Collections.Generic;

namespace GrowMandiApi.Models
{
    public partial class MandiUserFeedback
    {
        public int FeedbackId { get; set; }
        public string Usercode { get; set; }
        public string VarietyName { get; set; }
        public string Feedback { get; set; }
        public DateTime? TrDate { get; set; }
    }
}
