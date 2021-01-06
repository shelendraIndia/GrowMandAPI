using System;
using System.Collections.Generic;

namespace GrowMandiApi.Models
{
    public partial class MandiProductMaster
    {
        public int TrId { get; set; }
        public int? CropId { get; set; }
        public long? CategoryId { get; set; }
        public int? VarietyId { get; set; }
        public DateTime? CropEndDate { get; set; }
        public string ProductStatus { get; set; }
        public string ProductAddress { get; set; }
        public string GeoAddress { get; set; }
        public string MobileNumber { get; set; }
        public string NetBankingId { get; set; }
        public string Quantity { get; set; }
        public string QuantityUnit { get; set; }
        public int? Price { get; set; }
        public decimal? ServiceTax { get; set; }
        public int? TotalAmount { get; set; }
        public DateTime? AvailabilityDate { get; set; }
        public string PaymentMethod { get; set; }
        public bool? IsQualityTestNeeded { get; set; }
        public bool? IsLogisticNeeded { get; set; }
        public string ProductImageUrl { get; set; }
        public DateTime? TrDate { get; set; }
        public string State { get; set; }
        public string District { get; set; }
        public string Taluka { get; set; }
        public string Village { get; set; }
        public bool? IsActive { get; set; }
        public string ProductPriority { get; set; }
        public string SecondaryProductImage { get; set; }
        public string ProductDescription { get; set; }
        public bool? IsApproved { get; set; }
        public int? MaximumPrice { get; set; }
        public int? MinimumPrice { get; set; }
        public string TermsAndCondition { get; set; }
        public string HiProductDescription { get; set; }
        public string MrProductDescription { get; set; }
        public string TeProductDescription { get; set; }
        public int? QuantitySolde { get; set; }
        public bool? SoldeStatus { get; set; }
        public string QualityDetail { get; set; }
        public string QualityCertificate { get; set; }

        public virtual Category Category { get; set; }
        public virtual CropMaster Crop { get; set; }
        public virtual VarietyMaster Variety { get; set; }
    }
}
