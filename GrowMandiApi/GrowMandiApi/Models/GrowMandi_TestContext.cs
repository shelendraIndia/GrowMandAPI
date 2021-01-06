using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace GrowMandiApi.Models
{
    public partial class GrowMandi_TestContext : DbContext
    {
        public GrowMandi_TestContext()
        {
        }

        public GrowMandi_TestContext(DbContextOptions<GrowMandi_TestContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BsCallCentre> BsCallCentre { get; set; }
        public virtual DbSet<Buyer1> Buyer1 { get; set; }
        public virtual DbSet<BuyerGm> BuyerGm { get; set; }
        public virtual DbSet<BuyerGmCallCentre> BuyerGmCallCentre { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<CropMaster> CropMaster { get; set; }
        public virtual DbSet<DistrictMaster> DistrictMaster { get; set; }
        public virtual DbSet<ErrorLogs> ErrorLogs { get; set; }
        public virtual DbSet<MandiBanner> MandiBanner { get; set; }
        public virtual DbSet<MandiCartInfo> MandiCartInfo { get; set; }
        public virtual DbSet<MandiCartProductStatus> MandiCartProductStatus { get; set; }
        public virtual DbSet<MandiInterestedProductForUser> MandiInterestedProductForUser { get; set; }
        public virtual DbSet<MandiNotification> MandiNotification { get; set; }
        public virtual DbSet<MandiOrderDetails> MandiOrderDetails { get; set; }
        public virtual DbSet<MandiOrderProductDetails> MandiOrderProductDetails { get; set; }
        public virtual DbSet<MandiProductMaster> MandiProductMaster { get; set; }
        public virtual DbSet<MandiRequirement> MandiRequirement { get; set; }
        public virtual DbSet<MandiRoles> MandiRoles { get; set; }
        public virtual DbSet<MandiUserEnquiry> MandiUserEnquiry { get; set; }
        public virtual DbSet<MandiUserFeedback> MandiUserFeedback { get; set; }
        public virtual DbSet<MandiUserInfo> MandiUserInfo { get; set; }
        public virtual DbSet<MandiUserInfoBkp> MandiUserInfoBkp { get; set; }
        public virtual DbSet<MandiUserInfoBkp2> MandiUserInfoBkp2 { get; set; }
        public virtual DbSet<MandiUserRoles> MandiUserRoles { get; set; }
        public virtual DbSet<OrderDetails> OrderDetails { get; set; }
        public virtual DbSet<OrderErrorLogDetails> OrderErrorLogDetails { get; set; }
        public virtual DbSet<OrderProductDetails> OrderProductDetails { get; set; }
        public virtual DbSet<ProductMaster> ProductMaster { get; set; }
        public virtual DbSet<Quality> Quality { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<Seller1> Seller1 { get; set; }
        public virtual DbSet<SellerGmCallCentre> SellerGmCallCentre { get; set; }
        public virtual DbSet<SellerGmNew2> SellerGmNew2 { get; set; }
        public virtual DbSet<SellerNew> SellerNew { get; set; }
        public virtual DbSet<StateMaster> StateMaster { get; set; }
        public virtual DbSet<SubCategory> SubCategory { get; set; }
        public virtual DbSet<TalukaMaster> TalukaMaster { get; set; }
        public virtual DbSet<TblBuyRequest> TblBuyRequest { get; set; }
        public virtual DbSet<Testbulk> Testbulk { get; set; }
        public virtual DbSet<UserCategoryMapping> UserCategoryMapping { get; set; }
        public virtual DbSet<UserFeedback> UserFeedback { get; set; }
        public virtual DbSet<UserInfo> UserInfo { get; set; }
        public virtual DbSet<UserOtpinfo> UserOtpinfo { get; set; }
        public virtual DbSet<UserWallet> UserWallet { get; set; }
        public virtual DbSet<UsersAddress> UsersAddress { get; set; }
        public virtual DbSet<UsersBankAccountDetails> UsersBankAccountDetails { get; set; }
        public virtual DbSet<VarietyMaster> VarietyMaster { get; set; }
        public virtual DbSet<ViewVarietyMaster> ViewVarietyMaster { get; set; }
        public virtual DbSet<WebMandiUsermaster> WebMandiUsermaster { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=192.168.32.241;Database=GrowMandi_Test;User ID=sa;Password=Mahdb@2015;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BsCallCentre>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BS_call_centre");

                entity.Property(e => e.District).HasMaxLength(255);

                entity.Property(e => e.FarmerName)
                    .HasColumnName("Farmer_Name")
                    .HasMaxLength(255);

                entity.Property(e => e.Role)
                    .HasColumnName("ROLE")
                    .HasMaxLength(255);

                entity.Property(e => e.State).HasMaxLength(255);

                entity.Property(e => e.Taluka).HasMaxLength(255);

                entity.Property(e => e.Village).HasMaxLength(255);
            });

            modelBuilder.Entity<Buyer1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Buyer_1");

                entity.Property(e => e.AndroidPhone)
                    .HasColumnName("Android_Phone")
                    .HasMaxLength(255);

                entity.Property(e => e.CallStatus)
                    .HasColumnName("Call_Status")
                    .HasMaxLength(255);

                entity.Property(e => e.CalledBy)
                    .HasColumnName("Called _by")
                    .HasMaxLength(255);

                entity.Property(e => e.Challenges).HasMaxLength(255);

                entity.Property(e => e.Crop1).HasMaxLength(255);

                entity.Property(e => e.Crop11)
                    .HasColumnName("Crop_1")
                    .HasMaxLength(255);

                entity.Property(e => e.Crop2).HasMaxLength(255);

                entity.Property(e => e.Crop21)
                    .HasColumnName("Crop_2")
                    .HasMaxLength(255);

                entity.Property(e => e.Crop3).HasMaxLength(255);

                entity.Property(e => e.Crop31)
                    .HasColumnName("Crop_3")
                    .HasMaxLength(255);

                entity.Property(e => e.CropDetails)
                    .HasColumnName("Crop_Details")
                    .HasMaxLength(255);

                entity.Property(e => e.DateOfCall)
                    .HasColumnName("Date_of_call")
                    .HasColumnType("datetime");

                entity.Property(e => e.District).HasMaxLength(255);

                entity.Property(e => e.MobileNo).HasColumnName("Mobile_no#");

                entity.Property(e => e.OtherQueries)
                    .HasColumnName("other_queries")
                    .HasMaxLength(255);

                entity.Property(e => e.Price1).HasMaxLength(255);

                entity.Property(e => e.Price11)
                    .HasColumnName("Price_1")
                    .HasMaxLength(255);

                entity.Property(e => e.Price2).HasMaxLength(255);

                entity.Property(e => e.Price21)
                    .HasColumnName("Price_2")
                    .HasMaxLength(255);

                entity.Property(e => e.Price3).HasMaxLength(255);

                entity.Property(e => e.Price31)
                    .HasColumnName("Price_3")
                    .HasMaxLength(255);

                entity.Property(e => e.Quality1).HasMaxLength(255);

                entity.Property(e => e.Quality11)
                    .HasColumnName("Quality_1")
                    .HasMaxLength(255);

                entity.Property(e => e.Quality2).HasMaxLength(255);

                entity.Property(e => e.Quality21)
                    .HasColumnName("Quality_2")
                    .HasMaxLength(255);

                entity.Property(e => e.Quality3).HasMaxLength(255);

                entity.Property(e => e.Quality31)
                    .HasColumnName("Quality_3")
                    .HasMaxLength(255);

                entity.Property(e => e.Quantity1).HasMaxLength(255);

                entity.Property(e => e.Quantity11)
                    .HasColumnName("Quantity_1")
                    .HasMaxLength(255);

                entity.Property(e => e.Quantity2).HasMaxLength(255);

                entity.Property(e => e.Quantity21)
                    .HasColumnName("Quantity_2")
                    .HasMaxLength(255);

                entity.Property(e => e.Quantity3).HasMaxLength(255);

                entity.Property(e => e.Quantity31)
                    .HasColumnName("Quantity_3")
                    .HasMaxLength(255);

                entity.Property(e => e.State).HasMaxLength(255);

                entity.Property(e => e.Taluka).HasMaxLength(255);

                entity.Property(e => e.TradingCrops)
                    .HasColumnName("Trading_crops")
                    .HasMaxLength(255);

                entity.Property(e => e.VendorName)
                    .HasColumnName("Vendor_name")
                    .HasMaxLength(255);

                entity.Property(e => e.WhatsAppNo)
                    .HasColumnName("WhatsApp_no#")
                    .HasMaxLength(255);

                entity.Property(e => e.WillingnessToUseAnApp)
                    .HasColumnName("willingness_to_use_an_App")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<BuyerGm>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Buyer_GM");

                entity.Property(e => e.AndroidPhone)
                    .HasColumnName("Android Phone")
                    .HasMaxLength(255);

                entity.Property(e => e.CallStatus)
                    .HasColumnName("Call Status")
                    .HasMaxLength(255);

                entity.Property(e => e.CalledBy)
                    .HasColumnName("Called  by")
                    .HasMaxLength(255);

                entity.Property(e => e.Challenges).HasMaxLength(255);

                entity.Property(e => e.Crop1).HasMaxLength(255);

                entity.Property(e => e.Crop11)
                    .HasColumnName("Crop_1")
                    .HasMaxLength(255);

                entity.Property(e => e.Crop2).HasMaxLength(255);

                entity.Property(e => e.Crop21)
                    .HasColumnName("Crop_2")
                    .HasMaxLength(255);

                entity.Property(e => e.Crop3).HasMaxLength(255);

                entity.Property(e => e.Crop31)
                    .HasColumnName("Crop_3")
                    .HasMaxLength(255);

                entity.Property(e => e.CropDetails)
                    .HasColumnName("Crop Details")
                    .HasMaxLength(255);

                entity.Property(e => e.DateOfCall)
                    .HasColumnName("Date of call")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dist)
                    .HasColumnName("Dist#")
                    .HasMaxLength(255);

                entity.Property(e => e.MobileNo).HasColumnName("Mobile no#");

                entity.Property(e => e.OtherQueries)
                    .HasColumnName("other queries")
                    .HasMaxLength(255);

                entity.Property(e => e.Price1).HasMaxLength(255);

                entity.Property(e => e.Price11)
                    .HasColumnName("Price_1")
                    .HasMaxLength(255);

                entity.Property(e => e.Price2).HasMaxLength(255);

                entity.Property(e => e.Price21)
                    .HasColumnName("Price_2")
                    .HasMaxLength(255);

                entity.Property(e => e.Price3).HasMaxLength(255);

                entity.Property(e => e.Price31)
                    .HasColumnName("Price_3")
                    .HasMaxLength(255);

                entity.Property(e => e.Quality1).HasMaxLength(255);

                entity.Property(e => e.Quality11)
                    .HasColumnName("Quality_1")
                    .HasMaxLength(255);

                entity.Property(e => e.Quality2).HasMaxLength(255);

                entity.Property(e => e.Quality21)
                    .HasColumnName("Quality_2")
                    .HasMaxLength(255);

                entity.Property(e => e.Quality3).HasMaxLength(255);

                entity.Property(e => e.Quality31)
                    .HasColumnName("Quality_3")
                    .HasMaxLength(255);

                entity.Property(e => e.Quantity1).HasMaxLength(255);

                entity.Property(e => e.Quantity11)
                    .HasColumnName("Quantity_1")
                    .HasMaxLength(255);

                entity.Property(e => e.Quantity2).HasMaxLength(255);

                entity.Property(e => e.Quantity21)
                    .HasColumnName("Quantity_2")
                    .HasMaxLength(255);

                entity.Property(e => e.Quantity3).HasMaxLength(255);

                entity.Property(e => e.Quantity31)
                    .HasColumnName("Quantity_3")
                    .HasMaxLength(255);

                entity.Property(e => e.State).HasMaxLength(255);

                entity.Property(e => e.Taluka).HasMaxLength(255);

                entity.Property(e => e.TradingCrops)
                    .HasColumnName("Trading crops")
                    .HasMaxLength(255);

                entity.Property(e => e.VendorName)
                    .HasColumnName("Vendor name")
                    .HasMaxLength(255);

                entity.Property(e => e.WhatsAppNo).HasColumnName("WhatsApp no#");

                entity.Property(e => e.WillingnessToUseAnApp)
                    .HasColumnName("willingness to use an App")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<BuyerGmCallCentre>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Buyer_GM_CallCentre");

                entity.Property(e => e.AndroidPhone)
                    .HasColumnName("Android_Phone")
                    .HasMaxLength(255);

                entity.Property(e => e.CallStatus)
                    .HasColumnName("Call_Status")
                    .HasMaxLength(255);

                entity.Property(e => e.CalledBy)
                    .HasColumnName("Called _by")
                    .HasMaxLength(255);

                entity.Property(e => e.Challenges).HasMaxLength(255);

                entity.Property(e => e.Crop1).HasMaxLength(255);

                entity.Property(e => e.Crop11)
                    .HasColumnName("Crop_1")
                    .HasMaxLength(255);

                entity.Property(e => e.Crop2).HasMaxLength(255);

                entity.Property(e => e.Crop21)
                    .HasColumnName("Crop_2")
                    .HasMaxLength(255);

                entity.Property(e => e.Crop3).HasMaxLength(255);

                entity.Property(e => e.Crop31)
                    .HasColumnName("Crop_3")
                    .HasMaxLength(255);

                entity.Property(e => e.CropDetails)
                    .HasColumnName("Crop_Details")
                    .HasMaxLength(255);

                entity.Property(e => e.DateOfCall)
                    .HasColumnName("Date_of_call")
                    .HasColumnType("datetime");

                entity.Property(e => e.District).HasMaxLength(255);

                entity.Property(e => e.MobileNo).HasColumnName("Mobile_no#");

                entity.Property(e => e.OtherQueries)
                    .HasColumnName("other_queries")
                    .HasMaxLength(255);

                entity.Property(e => e.Price1).HasMaxLength(255);

                entity.Property(e => e.Price11)
                    .HasColumnName("Price_1")
                    .HasMaxLength(255);

                entity.Property(e => e.Price2).HasMaxLength(255);

                entity.Property(e => e.Price21)
                    .HasColumnName("Price_2")
                    .HasMaxLength(255);

                entity.Property(e => e.Price3).HasMaxLength(255);

                entity.Property(e => e.Price31)
                    .HasColumnName("Price_3")
                    .HasMaxLength(255);

                entity.Property(e => e.Quality1).HasMaxLength(255);

                entity.Property(e => e.Quality11)
                    .HasColumnName("Quality_1")
                    .HasMaxLength(255);

                entity.Property(e => e.Quality2).HasMaxLength(255);

                entity.Property(e => e.Quality21)
                    .HasColumnName("Quality_2")
                    .HasMaxLength(255);

                entity.Property(e => e.Quality3).HasMaxLength(255);

                entity.Property(e => e.Quality31)
                    .HasColumnName("Quality_3")
                    .HasMaxLength(255);

                entity.Property(e => e.Quantity1).HasMaxLength(255);

                entity.Property(e => e.Quantity11)
                    .HasColumnName("Quantity_1")
                    .HasMaxLength(255);

                entity.Property(e => e.Quantity2).HasMaxLength(255);

                entity.Property(e => e.Quantity21)
                    .HasColumnName("Quantity_2")
                    .HasMaxLength(255);

                entity.Property(e => e.Quantity3).HasMaxLength(255);

                entity.Property(e => e.Quantity31)
                    .HasColumnName("Quantity_3")
                    .HasMaxLength(255);

                entity.Property(e => e.State).HasMaxLength(255);

                entity.Property(e => e.Taluka).HasMaxLength(255);

                entity.Property(e => e.TradingCrops)
                    .HasColumnName("Trading_crops")
                    .HasMaxLength(255);

                entity.Property(e => e.VendorName)
                    .HasColumnName("Vendor_name")
                    .HasMaxLength(255);

                entity.Property(e => e.WhatsAppNo).HasColumnName("WhatsApp_no#");

                entity.Property(e => e.WillingnessToUseAnApp)
                    .HasColumnName("willingness_to_use_an_App")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.Property(e => e.CatId).HasColumnName("cat_id");

                entity.Property(e => e.CategoryName).HasMaxLength(50);

                entity.Property(e => e.HiCategoryName)
                    .HasColumnName("Hi_CategoryName")
                    .HasMaxLength(500);

                entity.Property(e => e.MrCategoryName)
                    .HasColumnName("Mr_CategoryName")
                    .HasMaxLength(500);

                entity.Property(e => e.TeCategoryName)
                    .HasColumnName("Te_CategoryName")
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<CropMaster>(entity =>
            {
                entity.HasKey(e => e.CropId);

                entity.ToTable("Crop_Master");

                entity.Property(e => e.CategoryName).HasMaxLength(50);

                entity.Property(e => e.CropName).HasMaxLength(50);

                entity.Property(e => e.HiCropName)
                    .HasColumnName("Hi_CropName")
                    .HasMaxLength(500);

                entity.Property(e => e.MrCropName)
                    .HasColumnName("Mr_CropName")
                    .HasMaxLength(500);

                entity.Property(e => e.TeCropName)
                    .HasColumnName("Te_CropName")
                    .HasMaxLength(500);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.CropMaster)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_Crop_Master_Category");
            });

            modelBuilder.Entity<DistrictMaster>(entity =>
            {
                entity.HasKey(e => e.DistrictCode)
                    .HasName("PK_District_Master_1");

                entity.ToTable("District_Master");

                entity.Property(e => e.DistrictCode).HasMaxLength(256);

                entity.Property(e => e.DistrictName).HasMaxLength(256);

                entity.Property(e => e.StateCode)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<MandiBanner>(entity =>
            {
                entity.ToTable("Mandi_Banner");

                entity.Property(e => e.BannerTitle).HasMaxLength(100);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ImageType).HasMaxLength(100);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<MandiCartInfo>(entity =>
            {
                entity.HasKey(e => e.CartId);

                entity.ToTable("Mandi_CartInfo");

                entity.Property(e => e.BuyerName).HasMaxLength(500);

                entity.Property(e => e.BuyerNumber).HasMaxLength(50);

                entity.Property(e => e.CartType).HasMaxLength(50);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DealId)
                    .HasColumnName("Deal_Id")
                    .HasMaxLength(50);

                entity.Property(e => e.FkEnquiryId).HasColumnName("Fk_EnquiryId");

                entity.Property(e => e.FkInterestedProductId).HasColumnName("Fk_InterestedProductId");

                entity.Property(e => e.FkProductStatus).HasColumnName("Fk_ProductStatus");

                entity.Property(e => e.LogisticsCost)
                    .HasColumnName("Logistics_Cost")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OtherCharges)
                    .HasColumnName("Other_Charges")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Product).HasMaxLength(500);

                entity.Property(e => e.ProductId).HasColumnName("Product_Id");

                entity.Property(e => e.ProductImage).IsUnicode(false);

                entity.Property(e => e.Quantity).HasMaxLength(64);

                entity.Property(e => e.QuantityUnit).HasMaxLength(64);

                entity.Property(e => e.SellerMobileNumber)
                    .HasColumnName("Seller_MobileNumber")
                    .HasMaxLength(50);

                entity.Property(e => e.SellerName).HasMaxLength(50);

                entity.Property(e => e.ServiceTax).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Taxes).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.FkEnquiry)
                    .WithMany(p => p.MandiCartInfo)
                    .HasForeignKey(d => d.FkEnquiryId)
                    .HasConstraintName("FK_Mandi_CartInfo_Mandi_UserEnquiry");

                entity.HasOne(d => d.FkInterestedProduct)
                    .WithMany(p => p.MandiCartInfo)
                    .HasForeignKey(d => d.FkInterestedProductId)
                    .HasConstraintName("FK_Mandi_CartInfo_Mandi_InterestedProductForUser");

                entity.HasOne(d => d.FkProductStatusNavigation)
                    .WithMany(p => p.MandiCartInfo)
                    .HasForeignKey(d => d.FkProductStatus)
                    .HasConstraintName("FK_Mandi_CartInfo_Mandi_CartProductStatus");
            });

            modelBuilder.Entity<MandiCartProductStatus>(entity =>
            {
                entity.ToTable("Mandi_CartProductStatus");
            });

            modelBuilder.Entity<MandiInterestedProductForUser>(entity =>
            {
                entity.ToTable("Mandi_InterestedProductForUser");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.FkMobileNumber)
                    .HasColumnName("Fk_MobileNumber")
                    .HasMaxLength(256);

                entity.Property(e => e.ProductId).HasMaxLength(50);

                entity.HasOne(d => d.FkMobileNumberNavigation)
                    .WithMany(p => p.MandiInterestedProductForUser)
                    .HasForeignKey(d => d.FkMobileNumber)
                    .HasConstraintName("FK_Mandi_InterestedProductForUser_Mandi_UserInfo");
            });

            modelBuilder.Entity<MandiNotification>(entity =>
            {
                entity.HasKey(e => e.SerialNumber);

                entity.ToTable("Mandi_Notification");

                entity.Property(e => e.MobileNumber).HasMaxLength(15);

                entity.Property(e => e.TrDate)
                    .HasColumnName("Tr_Date")
                    .HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<MandiOrderDetails>(entity =>
            {
                entity.HasKey(e => e.OrderId);

                entity.ToTable("Mandi_OrderDetails");

                entity.Property(e => e.OrderId).HasColumnName("Order_Id");

                entity.Property(e => e.BuyerMobile)
                    .HasColumnName("Buyer_Mobile")
                    .HasMaxLength(256);

                entity.Property(e => e.BuyerName)
                    .HasColumnName("Buyer_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GeoAddress).HasMaxLength(256);

                entity.Property(e => e.OfferDiscountValue)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OfferTransactionId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrderDate).HasColumnType("datetime");

                entity.Property(e => e.OrderStatus)
                    .HasColumnName("Order_Status")
                    .IsUnicode(false);

                entity.Property(e => e.PaymentMode)
                    .HasColumnName("Payment_Mode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ResponseCode).IsUnicode(false);

                entity.Property(e => e.RzpOrderId)
                    .HasColumnName("rzp_order_id")
                    .IsUnicode(false);

                entity.Property(e => e.RzpPaymentId)
                    .HasColumnName("rzp_payment_Id")
                    .IsUnicode(false);

                entity.Property(e => e.RzpPaymentSignature)
                    .HasColumnName("rzp_payment_signature")
                    .IsUnicode(false);

                entity.Property(e => e.RzpPaymentStatus)
                    .HasColumnName("rzp_payment_status")
                    .IsUnicode(false);

                entity.Property(e => e.SelectedTotalQty)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceTax).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ShippingAddressId).HasColumnName("Shipping_Address_Id");

                entity.Property(e => e.TotalAmount)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TotalPrice)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TransactionId).IsUnicode(false);

                entity.Property(e => e.TransactionStatus).IsUnicode(false);
            });

            modelBuilder.Entity<MandiOrderProductDetails>(entity =>
            {
                entity.HasKey(e => e.TrId);

                entity.ToTable("Mandi_OrderProductDetails");

                entity.Property(e => e.TrId).HasColumnName("Tr_Id");

                entity.Property(e => e.OrderId).HasColumnName("Order_Id");

                entity.Property(e => e.ProductId).HasColumnName("Product_Id");

                entity.Property(e => e.SelectedProductPrice).HasMaxLength(64);

                entity.Property(e => e.SelectedQuantity).HasMaxLength(64);

                entity.Property(e => e.TotalQuantity).HasMaxLength(64);

                entity.Property(e => e.TrDate)
                    .HasColumnName("Tr_Date")
                    .HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<MandiProductMaster>(entity =>
            {
                entity.HasKey(e => e.TrId);

                entity.ToTable("Mandi_ProductMaster");

                entity.HasIndex(e => new { e.VarietyId, e.IsActive })
                    .HasName("idx_varityid_isactive");

                entity.HasIndex(e => new { e.TrId, e.CategoryId, e.VarietyId, e.CropEndDate, e.ProductAddress, e.GeoAddress, e.MobileNumber, e.NetBankingId, e.Quantity, e.QuantityUnit, e.Price, e.ServiceTax, e.AvailabilityDate, e.PaymentMethod, e.IsQualityTestNeeded, e.IsLogisticNeeded, e.ProductImageUrl, e.TrDate, e.State, e.District, e.Taluka, e.ProductPriority, e.SecondaryProductImage, e.ProductDescription, e.TermsAndCondition, e.HiProductDescription, e.TeProductDescription, e.CropId, e.IsActive, e.IsApproved })
                    .HasName("IX_Mandi_ProductMaster_CropId_IsActive_IsApproved");

                entity.Property(e => e.TrId).HasColumnName("Tr_Id");

                entity.Property(e => e.AvailabilityDate).HasColumnType("smalldatetime");

                entity.Property(e => e.CropEndDate).HasColumnType("datetime");

                entity.Property(e => e.District).HasMaxLength(256);

                entity.Property(e => e.GeoAddress).HasMaxLength(256);

                entity.Property(e => e.HiProductDescription)
                    .HasColumnName("Hi_ProductDescription")
                    .HasMaxLength(500);

                entity.Property(e => e.IsApproved).HasDefaultValueSql("((0))");

                entity.Property(e => e.MobileNumber).HasMaxLength(256);

                entity.Property(e => e.MrProductDescription)
                    .HasColumnName("Mr_ProductDescription")
                    .HasMaxLength(500);

                entity.Property(e => e.NetBankingId).HasMaxLength(256);

                entity.Property(e => e.PaymentMethod).HasMaxLength(64);

                entity.Property(e => e.ProductAddress).HasMaxLength(256);

                entity.Property(e => e.ProductDescription).HasMaxLength(256);

                entity.Property(e => e.ProductImageUrl).HasColumnType("varchar(max)");

                entity.Property(e => e.ProductPriority)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ProductStatus)
                    .HasColumnName("Product_Status")
                    .HasMaxLength(500);

                entity.Property(e => e.QualityCertificate)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.QualityDetail).IsUnicode(false);

                entity.Property(e => e.Quantity).HasMaxLength(64);

                entity.Property(e => e.QuantitySolde).HasDefaultValueSql("((0))");

                entity.Property(e => e.QuantityUnit).HasMaxLength(64);

                entity.Property(e => e.SecondaryProductImage).HasColumnType("varchar(max)");

                entity.Property(e => e.ServiceTax).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.SoldeStatus).HasDefaultValueSql("((0))");

                entity.Property(e => e.State).HasMaxLength(256);

                entity.Property(e => e.Taluka).HasMaxLength(256);

                entity.Property(e => e.TeProductDescription)
                    .HasColumnName("Te_ProductDescription")
                    .HasMaxLength(500);

                entity.Property(e => e.TermsAndCondition).HasColumnType("nvarchar(max)");

                entity.Property(e => e.TrDate)
                    .HasColumnName("Tr_Date")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Village).HasMaxLength(256);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.MandiProductMaster)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_Mandi_ProductMaster_Crop_Master");

                entity.HasOne(d => d.Crop)
                    .WithMany(p => p.MandiProductMaster)
                    .HasForeignKey(d => d.CropId)
                    .HasConstraintName("FK_Mandi_ProductMaster_Mandi_UserInfo");

                entity.HasOne(d => d.Variety)
                    .WithMany(p => p.MandiProductMaster)
                    .HasForeignKey(d => d.VarietyId)
                    .HasConstraintName("FK_Mandi_ProductMaster_Variety_Master");
            });

            modelBuilder.Entity<MandiRequirement>(entity =>
            {
                entity.ToTable("Mandi_Requirement");

                entity.Property(e => e.BuyerAddress).HasMaxLength(500);

                entity.Property(e => e.BuyerContact).HasMaxLength(50);

                entity.Property(e => e.BuyerId).HasMaxLength(50);

                entity.Property(e => e.CropName).HasMaxLength(50);

                entity.Property(e => e.DeliveryLocation).HasMaxLength(500);

                entity.Property(e => e.ExpectedDate).HasColumnType("datetime");

                entity.Property(e => e.ExpectedPrice).HasMaxLength(50);

                entity.Property(e => e.MobileNumber).HasMaxLength(256);

                entity.Property(e => e.QualitySpecification).HasMaxLength(150);

                entity.Property(e => e.Quantity).HasMaxLength(50);

                entity.Property(e => e.TrDate)
                    .HasColumnName("Tr_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Variety).HasMaxLength(50);
            });

            modelBuilder.Entity<MandiRoles>(entity =>
            {
                entity.HasKey(e => e.RoleId);

                entity.ToTable("Mandi_Roles");

                entity.Property(e => e.RoleId).ValueGeneratedNever();

                entity.Property(e => e.RoleName).HasMaxLength(50);
            });

            modelBuilder.Entity<MandiUserEnquiry>(entity =>
            {
                entity.HasKey(e => e.TrId);

                entity.ToTable("Mandi_UserEnquiry");

                entity.Property(e => e.TrId).HasColumnName("Tr_Id");

                entity.Property(e => e.EmailId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MobileNumber).HasMaxLength(256);

                entity.Property(e => e.TrDate)
                    .HasColumnName("Tr_Date")
                    .HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<MandiUserFeedback>(entity =>
            {
                entity.HasKey(e => e.FeedbackId);

                entity.ToTable("Mandi_UserFeedback");

                entity.Property(e => e.TrDate)
                    .HasColumnName("Tr_Date")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Usercode).HasMaxLength(256);

                entity.Property(e => e.VarietyName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MandiUserInfo>(entity =>
            {
                entity.HasKey(e => e.MobileNumber);

                entity.ToTable("Mandi_UserInfo");

                entity.Property(e => e.MobileNumber).HasMaxLength(256);

                entity.Property(e => e.AdharId).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeviceToken).IsUnicode(false);

                entity.Property(e => e.District).HasMaxLength(256);

                entity.Property(e => e.FullName).HasMaxLength(256);

                entity.Property(e => e.Pincode).HasMaxLength(256);

                entity.Property(e => e.ProfilePictureUrl).IsUnicode(false);

                entity.Property(e => e.State).HasMaxLength(64);

                entity.Property(e => e.Taluka).HasMaxLength(256);

                entity.Property(e => e.UserType).HasMaxLength(256);

                entity.Property(e => e.Village).HasMaxLength(100);
            });

            modelBuilder.Entity<MandiUserInfoBkp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Mandi_UserInfo_bkp");

                entity.Property(e => e.AdharId).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeviceToken).IsUnicode(false);

                entity.Property(e => e.District).HasMaxLength(256);

                entity.Property(e => e.FullName).HasMaxLength(256);

                entity.Property(e => e.MobileNumber)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.Pincode).HasMaxLength(256);

                entity.Property(e => e.ProfilePictureUrl).IsUnicode(false);

                entity.Property(e => e.State).HasMaxLength(64);

                entity.Property(e => e.Taluka).HasMaxLength(256);

                entity.Property(e => e.UserType).HasMaxLength(256);

                entity.Property(e => e.Village).HasMaxLength(100);
            });

            modelBuilder.Entity<MandiUserInfoBkp2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Mandi_UserInfo_bkp_2");

                entity.Property(e => e.AdharId).HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DeviceToken).IsUnicode(false);

                entity.Property(e => e.District).HasMaxLength(256);

                entity.Property(e => e.FullName).HasMaxLength(256);

                entity.Property(e => e.MobileNumber)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.Pincode).HasMaxLength(256);

                entity.Property(e => e.ProfilePictureUrl).IsUnicode(false);

                entity.Property(e => e.State).HasMaxLength(64);

                entity.Property(e => e.Taluka).HasMaxLength(256);

                entity.Property(e => e.UserType).HasMaxLength(256);

                entity.Property(e => e.Village).HasMaxLength(100);
            });

            modelBuilder.Entity<MandiUserRoles>(entity =>
            {
                entity.HasKey(e => e.SerialNumber);

                entity.ToTable("Mandi_UserRoles");

                entity.Property(e => e.MobileNumber)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.HasOne(d => d.MobileNumberNavigation)
                    .WithMany(p => p.MandiUserRoles)
                    .HasForeignKey(d => d.MobileNumber)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Mandi_UserRoles_Mandi_UserInfo");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.MandiUserRoles)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Mandi_UserRoles_Mandi_Roles");
            });

            modelBuilder.Entity<OrderDetails>(entity =>
            {
                entity.HasKey(e => e.OrderId);

                entity.Property(e => e.OrderId).HasColumnName("Order_Id");

                entity.Property(e => e.GeoCoordinates).IsUnicode(false);

                entity.Property(e => e.OrderDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.OrderStatus)
                    .HasColumnName("Order_Status")
                    .IsUnicode(false);

                entity.Property(e => e.PaymentMode)
                    .HasColumnName("Payment_Mode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RetailerId)
                    .HasColumnName("Retailer_Id")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RetailerMobile)
                    .HasColumnName("Retailer_Mobile")
                    .HasMaxLength(256);

                entity.Property(e => e.RzpOrderId)
                    .HasColumnName("Rzp_Order_Id")
                    .IsUnicode(false);

                entity.Property(e => e.RzpPaymentId)
                    .HasColumnName("Rzp_Payment_Id")
                    .IsUnicode(false);

                entity.Property(e => e.RzpPaymentStatus)
                    .HasColumnName("Rzp_Payment_Status")
                    .IsUnicode(false);

                entity.Property(e => e.RzpSignature)
                    .HasColumnName("Rzp_Signature")
                    .IsUnicode(false);

                entity.Property(e => e.SapOrderId)
                    .HasColumnName("SAP_Order_ID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShippingAddressId).HasColumnName("Shipping_Address_Id");

                entity.Property(e => e.Totalprice)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.RetailerMobileNavigation)
                    .WithMany(p => p.OrderDetails)
                    .HasForeignKey(d => d.RetailerMobile)
                    .HasConstraintName("FK_OrderDetails_UserInfo");
            });

            modelBuilder.Entity<OrderErrorLogDetails>(entity =>
            {
                entity.HasKey(e => e.TrId);

                entity.Property(e => e.TrId).HasColumnName("Tr_Id");

                entity.Property(e => e.CsvFile)
                    .HasColumnName("Csv_File")
                    .IsUnicode(false);

                entity.Property(e => e.ErrorMsg)
                    .HasColumnName("Error_Msg")
                    .IsUnicode(false);

                entity.Property(e => e.PaymentMode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Qty)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RetailerId)
                    .HasColumnName("Retailer_Id")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RetailerMobile)
                    .HasColumnName("Retailer_Mobile")
                    .HasMaxLength(256);

                entity.Property(e => e.TotalPrice)
                    .HasColumnName("Total_Price")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TrDate)
                    .HasColumnName("Tr_Date")
                    .HasColumnType("smalldatetime");

                entity.HasOne(d => d.RetailerMobileNavigation)
                    .WithMany(p => p.OrderErrorLogDetails)
                    .HasForeignKey(d => d.RetailerMobile)
                    .HasConstraintName("FK_OrderErrorLogDetails_UserInfo");
            });

            modelBuilder.Entity<OrderProductDetails>(entity =>
            {
                entity.HasKey(e => e.TrId);

                entity.Property(e => e.TrId).HasColumnName("tr_id");

                entity.Property(e => e.OrderId).HasColumnName("order_id");

                entity.Property(e => e.Price)
                    .HasColumnName("price")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProductId)
                    .HasColumnName("product_id")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Qty)
                    .HasColumnName("qty")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SapOrderId)
                    .HasColumnName("SAP_order_ID")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TrDate)
                    .HasColumnName("tr_date")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.OrderProductDetails)
                    .HasForeignKey(d => d.OrderId)
                    .HasConstraintName("FK_OrderProductDetails_OrderDetails");
            });

            modelBuilder.Entity<ProductMaster>(entity =>
            {
                entity.HasKey(e => e.SkuId);

                entity.ToTable("Product_Master");

                entity.Property(e => e.AllowSaporder).HasColumnName("AllowSAPOrder");

                entity.Property(e => e.CurrentQuantity).HasMaxLength(64);

                entity.Property(e => e.Gstpercent)
                    .HasColumnName("GSTPercent")
                    .HasMaxLength(64);

                entity.Property(e => e.ImageUrl).HasMaxLength(64);

                entity.Property(e => e.ItemCode).HasMaxLength(64);

                entity.Property(e => e.MaxQuantittyToBook).HasMaxLength(64);

                entity.Property(e => e.MinQuantittyToBook).HasMaxLength(64);

                entity.Property(e => e.PrdCompanyName).HasMaxLength(64);

                entity.Property(e => e.PrdState).HasMaxLength(64);

                entity.Property(e => e.Price).HasMaxLength(64);

                entity.Property(e => e.SkuCreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Status).HasMaxLength(64);
            });

            modelBuilder.Entity<Quality>(entity =>
            {
                entity.Property(e => e.DefaultValue).HasMaxLength(200);

                entity.Property(e => e.Title).HasMaxLength(200);
            });

            modelBuilder.Entity<Roles>(entity =>
            {
                entity.HasKey(e => e.RoleId)
                    .HasName("PK_UserRoles");

                entity.Property(e => e.RoleId).ValueGeneratedNever();

                entity.Property(e => e.RoleName).HasMaxLength(50);
            });

            modelBuilder.Entity<Seller1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("seller_1");

                entity.Property(e => e.AndriodPhone)
                    .HasColumnName("Andriod_Phone")
                    .HasMaxLength(255);

                entity.Property(e => e.CallStatus)
                    .HasColumnName("Call_Status")
                    .HasMaxLength(255);

                entity.Property(e => e.CalledBy)
                    .HasColumnName("Called_By")
                    .HasMaxLength(255);

                entity.Property(e => e.Comments).HasMaxLength(255);

                entity.Property(e => e.Crop1).HasMaxLength(255);

                entity.Property(e => e.Crop2).HasMaxLength(255);

                entity.Property(e => e.Crop3).HasMaxLength(255);

                entity.Property(e => e.Crop4).HasMaxLength(255);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.District).HasMaxLength(255);

                entity.Property(e => e.FarmerName)
                    .HasColumnName("Farmer_Name")
                    .HasMaxLength(255);

                entity.Property(e => e.HarvestTime)
                    .HasColumnName("Harvest_time")
                    .HasMaxLength(255);

                entity.Property(e => e.InterestedForApp)
                    .HasColumnName("Interested_for_app?")
                    .HasMaxLength(255);

                entity.Property(e => e.MobNo).HasColumnName("Mob_No");

                entity.Property(e => e.OtherQueries)
                    .HasColumnName("Other_Queries")
                    .HasMaxLength(255);

                entity.Property(e => e.PaymentIn1015DayOkay)
                    .HasColumnName("Payment_in_10-15_day_okay?")
                    .HasMaxLength(255);

                entity.Property(e => e.Quantity1).HasMaxLength(255);

                entity.Property(e => e.Quantity2).HasMaxLength(255);

                entity.Property(e => e.Quantity3).HasMaxLength(255);

                entity.Property(e => e.Quantity4).HasMaxLength(255);

                entity.Property(e => e.Sr).HasColumnName("Sr#");

                entity.Property(e => e.State).HasMaxLength(255);

                entity.Property(e => e.Taluka).HasMaxLength(255);

                entity.Property(e => e.Village).HasMaxLength(255);

                entity.Property(e => e.WhatsappNumber)
                    .HasColumnName("whatsapp_number?")
                    .HasMaxLength(255);

                entity.Property(e => e.WhereTheySell)
                    .HasColumnName("Where_they_sell?")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<SellerGmCallCentre>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Seller_GM_CallCentre");

                entity.Property(e => e.AndriodPhone)
                    .HasColumnName("Andriod_Phone")
                    .HasMaxLength(255);

                entity.Property(e => e.CallStatus)
                    .HasColumnName("Call_Status")
                    .HasMaxLength(255);

                entity.Property(e => e.CalledBy)
                    .HasColumnName("Called_By")
                    .HasMaxLength(255);

                entity.Property(e => e.Comments).HasMaxLength(255);

                entity.Property(e => e.Crop1).HasMaxLength(255);

                entity.Property(e => e.Crop2).HasMaxLength(255);

                entity.Property(e => e.Crop3).HasMaxLength(255);

                entity.Property(e => e.Crop4).HasMaxLength(255);

                entity.Property(e => e.DateOfCall)
                    .HasColumnName("Date_of_call ")
                    .HasColumnType("datetime");

                entity.Property(e => e.District).HasMaxLength(255);

                entity.Property(e => e.FarmerName)
                    .HasColumnName("Farmer_Name")
                    .HasMaxLength(255);

                entity.Property(e => e.HarvestTimeMajorCrop)
                    .HasColumnName("Harvest_time(Major_Crop)")
                    .HasMaxLength(255);

                entity.Property(e => e.InterestedForApp)
                    .HasColumnName("Interested_for_app?")
                    .HasMaxLength(255);

                entity.Property(e => e.MobNo).HasColumnName("Mob#_No");

                entity.Property(e => e.OtherQueries)
                    .HasColumnName("Other_Queries")
                    .HasMaxLength(255);

                entity.Property(e => e.PaymentIn1015DayOkay)
                    .HasColumnName("Payment_in_10-15_day_okay?")
                    .HasMaxLength(255);

                entity.Property(e => e.Quantity4).HasMaxLength(255);

                entity.Property(e => e.Sr).HasColumnName("Sr#");

                entity.Property(e => e.State).HasMaxLength(255);

                entity.Property(e => e.Taluka).HasMaxLength(255);

                entity.Property(e => e.Village).HasMaxLength(255);

                entity.Property(e => e.WhatsappNumber)
                    .HasColumnName("whatsapp_number?")
                    .HasMaxLength(255);

                entity.Property(e => e.WhereTheySell)
                    .HasColumnName("Where_they_sell?")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<SellerGmNew2>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Seller_GM_new_2");

                entity.Property(e => e.AndriodPhone)
                    .HasColumnName("Andriod_Phone")
                    .HasMaxLength(255);

                entity.Property(e => e.CallStatus)
                    .HasColumnName("Call_Status")
                    .HasMaxLength(255);

                entity.Property(e => e.CalledBy)
                    .HasColumnName("Called_By")
                    .HasMaxLength(255);

                entity.Property(e => e.Comments).HasMaxLength(255);

                entity.Property(e => e.Crop1).HasMaxLength(255);

                entity.Property(e => e.Crop2).HasMaxLength(255);

                entity.Property(e => e.Crop3).HasMaxLength(255);

                entity.Property(e => e.Crop4).HasMaxLength(255);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.District).HasMaxLength(255);

                entity.Property(e => e.FarmerName)
                    .HasColumnName("Farmer_Name")
                    .HasMaxLength(255);

                entity.Property(e => e.HarvestTime)
                    .HasColumnName("Harvest_time")
                    .HasMaxLength(255);

                entity.Property(e => e.InterestedForApp)
                    .HasColumnName("Interested_for_app?")
                    .HasMaxLength(255);

                entity.Property(e => e.MobNo).HasColumnName("Mob_No");

                entity.Property(e => e.OtherQueries)
                    .HasColumnName("Other_Queries")
                    .HasMaxLength(255);

                entity.Property(e => e.PaymentIn1015DayOkay)
                    .HasColumnName("Payment_in_10-15_day_okay?")
                    .HasMaxLength(255);

                entity.Property(e => e.Quantity4).HasMaxLength(255);

                entity.Property(e => e.Sr).HasColumnName("Sr#");

                entity.Property(e => e.State).HasMaxLength(255);

                entity.Property(e => e.Taluka).HasMaxLength(255);

                entity.Property(e => e.Village).HasMaxLength(255);

                entity.Property(e => e.WhatsappNumber)
                    .HasColumnName("whatsapp_number?")
                    .HasMaxLength(255);

                entity.Property(e => e.WhereTheySell)
                    .HasColumnName("Where_they_sell?")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<SellerNew>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Seller_new");

                entity.Property(e => e.AndriodPhone)
                    .HasColumnName("Andriod_Phone")
                    .HasMaxLength(255);

                entity.Property(e => e.CallStatus)
                    .HasColumnName("Call_Status")
                    .HasMaxLength(255);

                entity.Property(e => e.CalledBy)
                    .HasColumnName("Called_By")
                    .HasMaxLength(255);

                entity.Property(e => e.Comments).HasMaxLength(255);

                entity.Property(e => e.Crop1).HasMaxLength(255);

                entity.Property(e => e.Crop2).HasMaxLength(255);

                entity.Property(e => e.Crop3).HasMaxLength(255);

                entity.Property(e => e.Crop4).HasMaxLength(255);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.District).HasMaxLength(255);

                entity.Property(e => e.FarmerName)
                    .HasColumnName("Farmer_Name")
                    .HasMaxLength(255);

                entity.Property(e => e.HarvestTime)
                    .HasColumnName("Harvest_time")
                    .HasMaxLength(255);

                entity.Property(e => e.InterestedForApp)
                    .HasColumnName("Interested_for_app?")
                    .HasMaxLength(255);

                entity.Property(e => e.MobNo).HasColumnName("Mob_No");

                entity.Property(e => e.OtherQueries)
                    .HasColumnName("Other_Queries")
                    .HasMaxLength(255);

                entity.Property(e => e.PaymentIn1015DayOkay)
                    .HasColumnName("Payment_in_10-15_day_okay?")
                    .HasMaxLength(255);

                entity.Property(e => e.Quantity3).HasMaxLength(255);

                entity.Property(e => e.Quantity4).HasMaxLength(255);

                entity.Property(e => e.Sr).HasColumnName("Sr#");

                entity.Property(e => e.State).HasMaxLength(255);

                entity.Property(e => e.Taluka).HasMaxLength(255);

                entity.Property(e => e.Village).HasMaxLength(255);

                entity.Property(e => e.WhatsappNumber).HasColumnName("whatsapp_number?");

                entity.Property(e => e.WhereTheySell)
                    .HasColumnName("Where_they_sell?")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<StateMaster>(entity =>
            {
                entity.HasKey(e => e.StateCode)
                    .HasName("PK_State_Master_1");

                entity.ToTable("State_Master");

                entity.Property(e => e.StateCode).HasMaxLength(256);

                entity.Property(e => e.StateName).HasMaxLength(256);
            });

            modelBuilder.Entity<SubCategory>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.ImageUrl).HasMaxLength(256);

                entity.Property(e => e.SubCategoryName).HasMaxLength(50);

                entity.HasOne(d => d.Category)
                    .WithMany()
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SubCategory_Category");
            });

            modelBuilder.Entity<TalukaMaster>(entity =>
            {
                entity.HasKey(e => e.TalukaCode)
                    .HasName("PK_Taluka_Master_1");

                entity.ToTable("Taluka_Master");

                entity.Property(e => e.TalukaCode).HasMaxLength(256);

                entity.Property(e => e.DistrictCode).HasMaxLength(256);

                entity.Property(e => e.TalukaName).HasMaxLength(256);
            });

            modelBuilder.Entity<TblBuyRequest>(entity =>
            {
                entity.HasKey(e => e.ReqId);

                entity.ToTable("tblBuyRequest");

                entity.Property(e => e.ReqId).HasColumnName("ReqID");

                entity.Property(e => e.ApplicationType)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ApprovedByEmail)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ApprovedDate).HasColumnType("datetime");

                entity.Property(e => e.BuyerId)
                    .HasColumnName("BuyerID")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.LastUpdateDate).HasColumnType("datetime");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.RejectionReason).HasMaxLength(500);

                entity.Property(e => e.ReqPrice).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.ReqQty).HasColumnType("numeric(18, 4)");

                entity.Property(e => e.Status)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.TnC).HasMaxLength(500);

                entity.Property(e => e.Unit)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ValidTillDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Testbulk>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("testbulk");

                entity.Property(e => e.BrandName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Price)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ProductId)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ProductName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Warrenty)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UserCategoryMapping>(entity =>
            {
                entity.Property(e => e.CategoryName).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.FkMobileNumber)
                    .HasColumnName("Fk_MobileNumber")
                    .HasMaxLength(256);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.UserCategoryMapping)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK_UserCategoryMapping_Category");

                entity.HasOne(d => d.FkMobileNumberNavigation)
                    .WithMany(p => p.UserCategoryMapping)
                    .HasForeignKey(d => d.FkMobileNumber)
                    .HasConstraintName("FK_UserCategoryMapping_Mandi_UserInfo");
            });

            modelBuilder.Entity<UserFeedback>(entity =>
            {
                entity.HasKey(e => e.TrId);

                entity.Property(e => e.TrId).HasColumnName("Tr_Id");

                entity.Property(e => e.Product)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TrDate)
                    .HasColumnName("Tr_Date")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Usercode).HasMaxLength(256);

                entity.HasOne(d => d.UsercodeNavigation)
                    .WithMany(p => p.UserFeedback)
                    .HasForeignKey(d => d.Usercode)
                    .HasConstraintName("FK_UserFeedback_UserInfo");
            });

            modelBuilder.Entity<UserInfo>(entity =>
            {
                entity.HasKey(e => e.MobileNumber);

                entity.Property(e => e.MobileNumber).HasMaxLength(256);

                entity.Property(e => e.Address).HasMaxLength(256);

                entity.Property(e => e.BankAccountNumber).HasMaxLength(256);

                entity.Property(e => e.BirthDate).HasColumnType("datetime");

                entity.Property(e => e.Cstnnumber)
                    .HasColumnName("CSTNNumber")
                    .HasMaxLength(256);

                entity.Property(e => e.Depo).HasMaxLength(256);

                entity.Property(e => e.District).HasMaxLength(256);

                entity.Property(e => e.EmailId).HasMaxLength(256);

                entity.Property(e => e.EntryDate).HasColumnType("datetime");

                entity.Property(e => e.FcmSubscriptionTopic).HasMaxLength(256);

                entity.Property(e => e.FirmName)
                    .HasColumnName("Firm_Name")
                    .HasMaxLength(256);

                entity.Property(e => e.Flag).HasMaxLength(256);

                entity.Property(e => e.GeoAddress).HasMaxLength(256);

                entity.Property(e => e.Gstnumber)
                    .HasColumnName("GSTNumber")
                    .HasMaxLength(256);

                entity.Property(e => e.HouseNumber).HasMaxLength(256);

                entity.Property(e => e.Imeinumber)
                    .HasColumnName("IMEINumber")
                    .HasMaxLength(256);

                entity.Property(e => e.LicenseNumber).HasMaxLength(256);

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.Pannumber)
                    .HasColumnName("PANNumber")
                    .HasMaxLength(256);

                entity.Property(e => e.Pincode).HasMaxLength(256);

                entity.Property(e => e.RetailerId).HasMaxLength(256);

                entity.Property(e => e.RetailerLastName).HasMaxLength(256);

                entity.Property(e => e.RetailerName).HasMaxLength(256);

                entity.Property(e => e.SapRetailerIdFcmToken).HasMaxLength(256);

                entity.Property(e => e.SeedLicenseValidity).HasColumnType("datetime");

                entity.Property(e => e.State).HasMaxLength(64);

                entity.Property(e => e.StreetLine1).HasMaxLength(256);

                entity.Property(e => e.StreetLine2).HasMaxLength(256);

                entity.Property(e => e.Taluka).HasMaxLength(256);

                entity.Property(e => e.Town).HasMaxLength(256);

                entity.Property(e => e.Type).HasMaxLength(256);

                entity.Property(e => e.UserCode).HasMaxLength(256);

                entity.Property(e => e.UserCompany).HasMaxLength(256);

                entity.Property(e => e.UserPassword).HasMaxLength(256);

                entity.Property(e => e.Vatnumber)
                    .HasColumnName("VATNumber")
                    .HasMaxLength(256);

                entity.Property(e => e.Village).HasMaxLength(256);
            });

            modelBuilder.Entity<UserOtpinfo>(entity =>
            {
                entity.HasKey(e => e.SerialNumber);

                entity.ToTable("UserOTPInfo");

                entity.Property(e => e.GenratedDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MobileNumber).HasMaxLength(15);

                entity.Property(e => e.Otp)
                    .HasColumnName("OTP")
                    .HasMaxLength(8);
            });

            modelBuilder.Entity<UserWallet>(entity =>
            {
                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.MobileNumber).HasMaxLength(256);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.WalletBalance).HasMaxLength(50);

                entity.HasOne(d => d.MobileNumberNavigation)
                    .WithMany(p => p.UserWallet)
                    .HasForeignKey(d => d.MobileNumber)
                    .HasConstraintName("FK_UserWallet_UserInfo");
            });

            modelBuilder.Entity<UsersAddress>(entity =>
            {
                entity.HasKey(e => e.TrId);

                entity.Property(e => e.TrId).HasColumnName("tr_id");

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmailId)
                    .HasColumnName("email_id")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MobileNumberForMandi).HasMaxLength(256);

                entity.Property(e => e.MobileNumberForOnline).HasMaxLength(256);

                entity.Property(e => e.PanNumber)
                    .HasColumnName("Pan_number")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Pincode)
                    .HasColumnName("pincode")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.ReciverName)
                    .HasColumnName("reciver_name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RetailerId)
                    .HasColumnName("retailer_id")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipAddress)
                    .HasColumnName("ship_address")
                    .IsUnicode(false);

                entity.Property(e => e.ShipMobile)
                    .HasColumnName("ship_mobile")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.TrDate)
                    .HasColumnName("tr_date")
                    .HasColumnType("smalldatetime");

                entity.HasOne(d => d.MobileNumberForMandiNavigation)
                    .WithMany(p => p.UsersAddress)
                    .HasForeignKey(d => d.MobileNumberForMandi)
                    .HasConstraintName("FK_UsersAddress_Mandi_UserInfo");

                entity.HasOne(d => d.MobileNumberForOnlineNavigation)
                    .WithMany(p => p.UsersAddress)
                    .HasForeignKey(d => d.MobileNumberForOnline)
                    .HasConstraintName("FK_UsersAddress_UserInfo");
            });

            modelBuilder.Entity<UsersBankAccountDetails>(entity =>
            {
                entity.Property(e => e.AccountHolderName).HasMaxLength(100);

                entity.Property(e => e.AccountNumber)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.AccountType).HasMaxLength(150);

                entity.Property(e => e.BankName)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.Branch)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.IfscCode)
                    .HasColumnName("IFSC_Code")
                    .HasMaxLength(256);

                entity.Property(e => e.MobileNumber)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.UserName).HasMaxLength(256);

                entity.HasOne(d => d.MobileNumberNavigation)
                    .WithMany(p => p.UsersBankAccountDetails)
                    .HasForeignKey(d => d.MobileNumber)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UsersBankAccountDetails_Mandi_UserInfo");
            });

            modelBuilder.Entity<VarietyMaster>(entity =>
            {
                entity.HasKey(e => e.VarietyId);

                entity.ToTable("Variety_Master");

                entity.Property(e => e.VarietyName).HasMaxLength(50);

                entity.Property(e => e.VarietyOrigin).HasMaxLength(50);

                entity.HasOne(d => d.Crop)
                    .WithMany(p => p.VarietyMaster)
                    .HasForeignKey(d => d.CropId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Variety_Master_Crop_Master");
            });

            modelBuilder.Entity<ViewVarietyMaster>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_Variety_Master");

                entity.Property(e => e.CategoryName).HasMaxLength(50);

                entity.Property(e => e.CropName).HasMaxLength(50);

                entity.Property(e => e.VarietyName).HasMaxLength(50);

                entity.Property(e => e.VarietyOrigin).HasMaxLength(50);
            });

            modelBuilder.Entity<WebMandiUsermaster>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Web_Mandi_usermaster");

                entity.Property(e => e.ChangePass)
                    .HasColumnName("change_pass")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsLogin).HasDefaultValueSql("((0))");

                entity.Property(e => e.LockStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SessionId)
                    .HasColumnName("sessionID")
                    .IsUnicode(false);

                entity.Property(e => e.TrId)
                    .HasColumnName("tr_id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.UserMail)
                    .HasColumnName("user_mail")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserMobile)
                    .HasColumnName("user_mobile")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasColumnName("user_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserPwd)
                    .HasColumnName("user_pwd")
                    .IsUnicode(false);

                entity.Property(e => e.UserRole).HasColumnName("user_role");

                entity.Property(e => e.UserState)
                    .HasColumnName("user_state")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserStatus)
                    .HasColumnName("userStatus")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('ACTIVE')");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
