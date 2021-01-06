using System;
using System.Collections.Generic;

namespace GrowMandiApi.Models
{
    public partial class BsCallCentre
    {
        public double? MobileNumber { get; set; }
        public string FarmerName { get; set; }
        public string Village { get; set; }
        public string Taluka { get; set; }
        public string District { get; set; }
        public string State { get; set; }
        public string Role { get; set; }
    }
}
