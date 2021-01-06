using System;
using System.Collections.Generic;

namespace GrowMandiApi.Models
{
    public partial class ErrorLogs
    {
        public int Id { get; set; }
        public string ErrorMessage { get; set; }
        public string ErrorFrom { get; set; }
        public string InnerException { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
