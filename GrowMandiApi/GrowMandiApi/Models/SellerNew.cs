using System;
using System.Collections.Generic;

namespace GrowMandiApi.Models
{
    public partial class SellerNew
    {
        public double? Sr { get; set; }
        public DateTime? Date { get; set; }
        public double? MobNo { get; set; }
        public string FarmerName { get; set; }
        public string Village { get; set; }
        public string Taluka { get; set; }
        public string District { get; set; }
        public string State { get; set; }
        public string CallStatus { get; set; }
        public string Crop1 { get; set; }
        public double? Quantity1 { get; set; }
        public string Crop2 { get; set; }
        public double? Quantity2 { get; set; }
        public string Crop3 { get; set; }
        public string Quantity3 { get; set; }
        public string Crop4 { get; set; }
        public string Quantity4 { get; set; }
        public string HarvestTime { get; set; }
        public string WhereTheySell { get; set; }
        public string PaymentIn1015DayOkay { get; set; }
        public string InterestedForApp { get; set; }
        public string AndriodPhone { get; set; }
        public double? WhatsappNumber { get; set; }
        public string OtherQueries { get; set; }
        public string Comments { get; set; }
        public string CalledBy { get; set; }
    }
}
