using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Cat_Paw_Footprint.Models;

public partial class WebTravel2Context : DbContext
{
    public WebTravel2Context(DbContextOptions<WebTravel2Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Coupon> Coupons { get; set; }

    public virtual DbSet<CouponPic> CouponPics { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<CustomerBlacklist> CustomerBlacklists { get; set; }

    public virtual DbSet<CustomerCouponsRecord> CustomerCouponsRecords { get; set; }

    public virtual DbSet<CustomerLevel> CustomerLevels { get; set; }

    public virtual DbSet<CustomerLoginHistory> CustomerLoginHistories { get; set; }

    public virtual DbSet<CustomerOrder> CustomerOrders { get; set; }

    public virtual DbSet<CustomerOrderFeedback> CustomerOrderFeedbacks { get; set; }

    public virtual DbSet<CustomerOrderMemberInfo> CustomerOrderMemberInfos { get; set; }

    public virtual DbSet<CustomerProfile> CustomerProfiles { get; set; }

    public virtual DbSet<CustomerSupportFeedback> CustomerSupportFeedbacks { get; set; }

    public virtual DbSet<CustomerSupportMessage> CustomerSupportMessages { get; set; }

    public virtual DbSet<CustomerSupportTicket> CustomerSupportTickets { get; set; }

    public virtual DbSet<CustomerTripProject> CustomerTripProjects { get; set; }

    public virtual DbSet<DateDimension> DateDimensions { get; set; }

    public virtual DbSet<District> Districts { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<EmployeeProfile> EmployeeProfiles { get; set; }

    public virtual DbSet<EmployeeRole> EmployeeRoles { get; set; }

    public virtual DbSet<Faq> Faqs { get; set; }

    public virtual DbSet<Faqcategory> Faqcategorys { get; set; }

    public virtual DbSet<Hotel> Hotels { get; set; }

    public virtual DbSet<HotelKeyword> HotelKeywords { get; set; }

    public virtual DbSet<HotelPic> HotelPics { get; set; }

    public virtual DbSet<Keyword> Keywords { get; set; }

    public virtual DbSet<Location> Locations { get; set; }

    public virtual DbSet<LocationKeyword> LocationKeywords { get; set; }

    public virtual DbSet<LocationPic> LocationPics { get; set; }

    public virtual DbSet<NewsPic> NewsPics { get; set; }

    public virtual DbSet<NewsTable> NewsTables { get; set; }

    public virtual DbSet<OrderPaymentInfo> OrderPaymentInfos { get; set; }

    public virtual DbSet<OrderStatus> OrderStatuses { get; set; }

    public virtual DbSet<PaymentStatus> PaymentStatuses { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<ProductAnalysis> ProductAnalyses { get; set; }

    public virtual DbSet<ProductPic> ProductPics { get; set; }

    public virtual DbSet<ProductsHotel> ProductsHotels { get; set; }

    public virtual DbSet<ProductsLocation> ProductsLocations { get; set; }

    public virtual DbSet<ProductsPromotion> ProductsPromotions { get; set; }

    public virtual DbSet<ProductsRestaurant> ProductsRestaurants { get; set; }

    public virtual DbSet<ProductsTransportation> ProductsTransportations { get; set; }

    public virtual DbSet<Promotion> Promotions { get; set; }

    public virtual DbSet<Region> Regions { get; set; }

    public virtual DbSet<Restaurant> Restaurants { get; set; }

    public virtual DbSet<RestaurantKeyword> RestaurantKeywords { get; set; }

    public virtual DbSet<RestaurantPic> RestaurantPics { get; set; }

    public virtual DbSet<SemiHotel> SemiHotels { get; set; }

    public virtual DbSet<SemiLocation> SemiLocations { get; set; }

    public virtual DbSet<SemiSelfProduct> SemiSelfProducts { get; set; }

    public virtual DbSet<SemiTransportation> SemiTransportations { get; set; }

    public virtual DbSet<SupportAnalysis> SupportAnalyses { get; set; }

    public virtual DbSet<TicketPriority> TicketPriorities { get; set; }

    public virtual DbSet<TicketStatus> TicketStatuses { get; set; }

    public virtual DbSet<TicketType> TicketTypes { get; set; }

    public virtual DbSet<TransportKeyword> TransportKeywords { get; set; }

    public virtual DbSet<TransportPic> TransportPics { get; set; }

    public virtual DbSet<Transportation> Transportations { get; set; }

    public virtual DbSet<TripProjectDetail> TripProjectDetails { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Coupon>(entity =>
        {
            entity.HasKey(e => e.CouponId).HasName("PK__Coupons__384AF1DAA63FECA6");

            entity.HasIndex(e => e.CouponCode, "UQ__Coupons__D3490800A9C7E8AC").IsUnique();

            entity.Property(e => e.CouponId).HasColumnName("CouponID");
            entity.Property(e => e.CouponCode).HasMaxLength(50);
            entity.Property(e => e.DiscountValue).HasColumnType("numeric(7, 2)");
        });

        modelBuilder.Entity<CouponPic>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.CouponId).HasColumnName("CouponID");

            entity.HasOne(d => d.Coupon).WithMany()
                .HasForeignKey(d => d.CouponId)
                .HasConstraintName("FK__CouponPic__Coupo__40058253");
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(e => e.CustomerId).HasName("PK__Customer__A4AE64B871483160");

            entity.HasIndex(e => e.CustomerCode, "UQ_Customers_CustomerCode").IsUnique();

            entity.HasIndex(e => e.Account, "UQ__Customer__B0C3AC46C3B22E74").IsUnique();

            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.Account).HasMaxLength(50);
            entity.Property(e => e.CustomerCode)
                .HasMaxLength(4000)
                .HasComputedColumnSql("((N'Cus'+replicate(N'0',case when len(CONVERT([varchar](20),[CustomerID]))<(5) then (5)-len(CONVERT([varchar](20),[CustomerID])) else (0) end))+CONVERT([varchar](20),[CustomerID]))", true);
            entity.Property(e => e.FullName).HasMaxLength(20);
            entity.Property(e => e.Password).HasMaxLength(200);

            entity.HasOne(d => d.LevelNavigation).WithMany(p => p.Customers)
                .HasForeignKey(d => d.Level)
                .HasConstraintName("FK__Customers__Level__18EBB532");
        });

        modelBuilder.Entity<CustomerBlacklist>(entity =>
        {
            entity.HasKey(e => e.BlacklistId).HasName("PK__Customer__AFDBF438A631D061");

            entity.ToTable("CustomerBlacklist");

            entity.Property(e => e.BlacklistId).HasColumnName("BlacklistID");
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

            entity.HasOne(d => d.Customer).WithMany(p => p.CustomerBlacklists)
                .HasPrincipalKey(p => p.CustomerId)
                .HasForeignKey(d => d.CustomerId)
                .HasConstraintName("FK__CustomerB__Custo__5224328E");
        });

        modelBuilder.Entity<CustomerCouponsRecord>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.CouponId).HasColumnName("CouponID");
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

            entity.HasOne(d => d.Coupon).WithMany()
                .HasForeignKey(d => d.CouponId)
                .HasConstraintName("FK__CustomerC__Coupo__41EDCAC5");

            entity.HasOne(d => d.Customer).WithMany()
                .HasForeignKey(d => d.CustomerId)
                .HasConstraintName("FK__CustomerC__Custo__40F9A68C");
        });

        modelBuilder.Entity<CustomerLevel>(entity =>
        {
            entity.HasKey(e => e.Level).HasName("PK__Customer__AAF89963DA4B1984");

            entity.Property(e => e.Level).ValueGeneratedNever();
            entity.Property(e => e.LevelName).HasMaxLength(20);
        });

        modelBuilder.Entity<CustomerLoginHistory>(entity =>
        {
            entity.HasKey(e => e.LoginLogId).HasName("PK__Customer__D42E7ACC5FE72CCC");

            entity.ToTable("CustomerLoginHistory");

            entity.Property(e => e.LoginLogId)
                .ValueGeneratedNever()
                .HasColumnName("LoginLogID");
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.LoginIp)
                .HasMaxLength(45)
                .HasColumnName("LoginIP");

            entity.HasOne(d => d.Customer).WithMany(p => p.CustomerLoginHistories)
                .HasForeignKey(d => d.CustomerId)
                .HasConstraintName("FK__CustomerL__Custo__17F790F9");
        });

        modelBuilder.Entity<CustomerOrder>(entity =>
        {
            entity.HasKey(e => e.OrderId).HasName("PK__Customer__C3905BAF82D75597");

            entity.Property(e => e.OrderId).HasColumnName("OrderID");
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.OrderStatusId).HasColumnName("OrderStatusID");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");

            entity.HasOne(d => d.Customer).WithMany(p => p.CustomerOrders)
                .HasPrincipalKey(p => p.CustomerId)
                .HasForeignKey(d => d.CustomerId)
                .HasConstraintName("FK__CustomerO__Custo__42E1EEFE");

            entity.HasOne(d => d.OrderStatus).WithMany(p => p.CustomerOrders)
                .HasForeignKey(d => d.OrderStatusId)
                .HasConstraintName("FK__CustomerO__Order__45BE5BA9");

            entity.HasOne(d => d.Product).WithMany(p => p.CustomerOrders)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK__CustomerO__Produ__43D61337");

            entity.HasOne(d => d.ProductNavigation).WithMany(p => p.CustomerOrders)
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK__CustomerO__Produ__44CA3770");
        });

        modelBuilder.Entity<CustomerOrderFeedback>(entity =>
        {
            entity.HasKey(e => e.FeedbackId).HasName("PK__Customer__6A4BEDF6CECCAC3D");

            entity.ToTable("CustomerOrderFeedback");

            entity.Property(e => e.FeedbackId).HasColumnName("FeedbackID");
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.OrderId).HasColumnName("OrderID");

            entity.HasOne(d => d.Order).WithMany(p => p.CustomerOrderFeedbacks)
                .HasForeignKey(d => d.OrderId)
                .HasConstraintName("FK__CustomerO__Order__46B27FE2");
        });

        modelBuilder.Entity<CustomerOrderMemberInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CustomerOrderMemberInfo");

            entity.Property(e => e.CustomerName).HasMaxLength(50);
            entity.Property(e => e.Idnumber)
                .HasMaxLength(20)
                .HasColumnName("IDNumber");
            entity.Property(e => e.OrderId).HasColumnName("OrderID");

            entity.HasOne(d => d.Order).WithMany()
                .HasForeignKey(d => d.OrderId)
                .HasConstraintName("FK__CustomerO__Order__47A6A41B");
        });

        modelBuilder.Entity<CustomerProfile>(entity =>
        {
            entity.HasKey(e => e.CustomerProfilesId).HasName("PK__Customer__13B529265313EC3F");

            entity.ToTable("CustomerProfile");

            entity.HasIndex(e => e.ProfileCode, "UQ_CustomerProfile_ProfileCode").IsUnique();

            entity.HasIndex(e => e.CustomerId, "UQ__Customer__A4AE64B992F63C82").IsUnique();

            entity.Property(e => e.CustomerProfilesId).HasColumnName("CustomerProfilesID");
            entity.Property(e => e.Address).HasMaxLength(200);
            entity.Property(e => e.CustomerId)
                .IsRequired()
                .HasColumnName("CustomerID");
            entity.Property(e => e.CustomerName).HasMaxLength(50);
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Idnumber)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("IDNumber");
            entity.Property(e => e.Phone)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ProfileCode)
                .HasMaxLength(4000)
                .HasComputedColumnSql("((N'CusPD'+replicate(N'0',case when len(CONVERT([varchar](20),[CustomerProfilesID]))<(5) then (5)-len(CONVERT([varchar](20),[CustomerProfilesID])) else (0) end))+CONVERT([varchar](20),[CustomerProfilesID]))", true);

            entity.HasOne(d => d.Customer).WithOne(p => p.CustomerProfile)
                .HasForeignKey<CustomerProfile>(d => d.CustomerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CustomerP__Custo__17036CC0");
        });

        modelBuilder.Entity<CustomerSupportFeedback>(entity =>
        {
            entity.HasKey(e => e.FeedbackId).HasName("PK__Customer__6A4BEDF6E6C5961B");

            entity.ToTable("CustomerSupportFeedback");

            entity.Property(e => e.FeedbackId).HasColumnName("FeedbackID");
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.TicketId).HasColumnName("TicketID");

            entity.HasOne(d => d.Ticket).WithMany(p => p.CustomerSupportFeedbacks)
                .HasForeignKey(d => d.TicketId)
                .HasConstraintName("FK__CustomerS__Ticke__4F47C5E3");
        });

        modelBuilder.Entity<CustomerSupportMessage>(entity =>
        {
            entity.HasKey(e => e.MessageId).HasName("PK__Customer__C87C037C881AA82A");

            entity.HasIndex(e => e.TicketId, "UQ__Customer__712CC626DA18075A").IsUnique();

            entity.Property(e => e.MessageId).HasColumnName("MessageID");
            entity.Property(e => e.AttachmentUrl)
                .HasMaxLength(500)
                .HasColumnName("AttachmentURL");
            entity.Property(e => e.ReceiverId).HasColumnName("ReceiverID");
            entity.Property(e => e.SenderId).HasColumnName("SenderID");
            entity.Property(e => e.TicketId).HasColumnName("TicketID");

            entity.HasOne(d => d.Ticket).WithOne(p => p.CustomerSupportMessage)
                .HasForeignKey<CustomerSupportMessage>(d => d.TicketId)
                .HasConstraintName("FK__CustomerS__Ticke__4A8310C6");
        });

        modelBuilder.Entity<CustomerSupportTicket>(entity =>
        {
            entity.HasKey(e => e.TicketId).HasName("PK__Customer__712CC627F1BDDA18");

            entity.Property(e => e.TicketId).HasColumnName("TicketID");
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.PriorityId).HasColumnName("PriorityID");
            entity.Property(e => e.StatusId).HasColumnName("StatusID");
            entity.Property(e => e.Subject).HasMaxLength(200);
            entity.Property(e => e.TicketTypeId).HasColumnName("TicketTypeID");

            entity.HasOne(d => d.Customer).WithMany(p => p.CustomerSupportTickets)
                .HasPrincipalKey(p => p.CustomerId)
                .HasForeignKey(d => d.CustomerId)
                .HasConstraintName("FK__CustomerS__Custo__4D5F7D71");

            entity.HasOne(d => d.Employee).WithMany(p => p.CustomerSupportTickets)
                .HasForeignKey(d => d.EmployeeId)
                .HasConstraintName("FK__CustomerS__Emplo__4E53A1AA");

            entity.HasOne(d => d.Priority).WithMany(p => p.CustomerSupportTickets)
                .HasForeignKey(d => d.PriorityId)
                .HasConstraintName("FK__CustomerS__Prior__4C6B5938");

            entity.HasOne(d => d.Status).WithMany(p => p.CustomerSupportTickets)
                .HasForeignKey(d => d.StatusId)
                .HasConstraintName("FK__CustomerS__Statu__4B7734FF");

            entity.HasOne(d => d.TicketType).WithMany(p => p.CustomerSupportTickets)
                .HasForeignKey(d => d.TicketTypeId)
                .HasConstraintName("FK__CustomerS__Ticke__503BEA1C");
        });

        modelBuilder.Entity<CustomerTripProject>(entity =>
        {
            entity.HasKey(e => e.ProjectId).HasName("PK__Customer__761ABED0D737A839");

            entity.Property(e => e.ProjectId).HasColumnName("ProjectID");
            entity.Property(e => e.CustomerId).HasColumnName("CustomerID");
            entity.Property(e => e.ProjectName).HasMaxLength(100);
        });

        modelBuilder.Entity<DateDimension>(entity =>
        {
            entity.HasKey(e => e.DateId).HasName("PK__DateDime__A426F253289D7407");

            entity.ToTable("DateDimension");

            entity.Property(e => e.DateId).HasColumnName("DateID");
            entity.Property(e => e.DayName).HasMaxLength(10);
        });

        modelBuilder.Entity<District>(entity =>
        {
            entity.HasKey(e => e.DistrictId).HasName("PK__District__85FDA4A6831ABC43");

            entity.Property(e => e.DistrictId).HasColumnName("DistrictID");
            entity.Property(e => e.DistrictName).HasMaxLength(20);
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.EmployeeId).HasName("PK__Employee__7AD04FF172DCDE5D");

            entity.HasIndex(e => e.EmployeeCode, "UQ_Employees_EmployeeCode").IsUnique();

            entity.HasIndex(e => e.Account, "UQ__Employee__B0C3AC46E77487F7").IsUnique();

            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.Account).HasMaxLength(50);
            entity.Property(e => e.EmployeeCode)
                .HasMaxLength(4000)
                .HasComputedColumnSql("((N'Emp'+replicate(N'0',case when len(CONVERT([varchar](20),[EmployeeID]))<(5) then (5)-len(CONVERT([varchar](20),[EmployeeID])) else (0) end))+CONVERT([varchar](20),[EmployeeID]))", true);
            entity.Property(e => e.Password).HasMaxLength(200);
            entity.Property(e => e.RoleId).HasColumnName("RoleID");

            entity.HasOne(d => d.Role).WithMany(p => p.Employees)
                .HasForeignKey(d => d.RoleId)
                .HasConstraintName("FK__Employees__RoleI__151B244E");
        });

        modelBuilder.Entity<EmployeeProfile>(entity =>
        {
            entity.HasKey(e => e.ProfileId).HasName("PK__Employee__290C88847884C080");

            entity.ToTable("EmployeeProfile");

            entity.HasIndex(e => e.ProfileCode, "UQ_EmployeeProfile_ProfileCode").IsUnique();

            entity.HasIndex(e => e.EmployeeId, "UQ__Employee__7AD04FF0DF0ED38F").IsUnique();

            entity.Property(e => e.ProfileId).HasColumnName("ProfileID");
            entity.Property(e => e.Address).HasMaxLength(200);
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.EmployeeId)
                .IsRequired()
                .HasColumnName("EmployeeID");
            entity.Property(e => e.EmployeeName).HasMaxLength(50);
            entity.Property(e => e.Idnumber)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("IDNumber");
            entity.Property(e => e.Phone)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ProfileCode)
                .HasMaxLength(4000)
                .HasComputedColumnSql("((N'EmpPD'+replicate(N'0',case when len(CONVERT([varchar](20),[ProfileID]))<(5) then (5)-len(CONVERT([varchar](20),[ProfileID])) else (0) end))+CONVERT([varchar](20),[ProfileID]))", true);

            entity.HasOne(d => d.Employee).WithOne(p => p.EmployeeProfile)
                .HasForeignKey<EmployeeProfile>(d => d.EmployeeId)
                .HasConstraintName("FK__EmployeeP__Emplo__160F4887");
        });

        modelBuilder.Entity<EmployeeRole>(entity =>
        {
            entity.HasKey(e => e.RoleId).HasName("PK__Employee__8AFACE3AEEA9CF7B");

            entity.Property(e => e.RoleId)
                .ValueGeneratedNever()
                .HasColumnName("RoleID");
            entity.Property(e => e.RoleName).HasMaxLength(20);
        });

        modelBuilder.Entity<Faq>(entity =>
        {
            entity.HasKey(e => e.Faqid).HasName("PK__FAQs__4B89D1E2280F8DA9");

            entity.ToTable("FAQs");

            entity.Property(e => e.Faqid).HasColumnName("FAQID");
            entity.Property(e => e.CategoryId).HasColumnName("CategoryID");
            entity.Property(e => e.Question).HasMaxLength(200);

            entity.HasOne(d => d.Category).WithMany(p => p.Faqs)
                .HasForeignKey(d => d.CategoryId)
                .HasConstraintName("FK__FAQs__CategoryID__51300E55");
        });

        modelBuilder.Entity<Faqcategory>(entity =>
        {
            entity.HasKey(e => e.CategoryId).HasName("PK__FAQCateg__19093A2BF4B93F6C");

            entity.ToTable("FAQCategorys");

            entity.Property(e => e.CategoryId).HasColumnName("CategoryID");
            entity.Property(e => e.CategoryName).HasMaxLength(200);
        });

        modelBuilder.Entity<Hotel>(entity =>
        {
            entity.HasKey(e => e.HotelId).HasName("PK__Hotels__46023BBFEEDEC27E");

            entity.Property(e => e.HotelId).HasColumnName("HotelID");
            entity.Property(e => e.DistrictId).HasColumnName("DistrictID");
            entity.Property(e => e.HotelAddr).HasMaxLength(200);
            entity.Property(e => e.HotelLat).HasColumnType("numeric(9, 6)");
            entity.Property(e => e.HotelLng).HasColumnType("numeric(9, 6)");
            entity.Property(e => e.HotelName).HasMaxLength(200);
            entity.Property(e => e.Rating).HasColumnType("numeric(2, 1)");
            entity.Property(e => e.RegionId).HasColumnName("RegionID");

            entity.HasOne(d => d.District).WithMany(p => p.Hotels)
                .HasForeignKey(d => d.DistrictId)
                .HasConstraintName("FK__Hotels__District__1EA48E88");

            entity.HasOne(d => d.Region).WithMany(p => p.Hotels)
                .HasForeignKey(d => d.RegionId)
                .HasConstraintName("FK__Hotels__RegionID__2DE6D218");
        });

        modelBuilder.Entity<HotelKeyword>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.HotelId).HasColumnName("HotelID");
            entity.Property(e => e.KeywordId).HasColumnName("KeywordID");

            entity.HasOne(d => d.Hotel).WithMany()
                .HasForeignKey(d => d.HotelId)
                .HasConstraintName("FK__HotelKeyw__Hotel__1F98B2C1");

            entity.HasOne(d => d.Keyword).WithMany()
                .HasForeignKey(d => d.KeywordId)
                .HasConstraintName("FK__HotelKeyw__Keywo__3D2915A8");
        });

        modelBuilder.Entity<HotelPic>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.HotelId).HasColumnName("HotelID");

            entity.HasOne(d => d.Hotel).WithMany()
                .HasForeignKey(d => d.HotelId)
                .HasConstraintName("FK__HotelPics__Hotel__1DB06A4F");
        });

        modelBuilder.Entity<Keyword>(entity =>
        {
            entity.HasKey(e => e.KeywordId).HasName("PK__Keywords__37C135C1711EEC05");

            entity.Property(e => e.KeywordId)
                .ValueGeneratedNever()
                .HasColumnName("KeywordID");
            entity.Property(e => e.Keyword1)
                .HasMaxLength(15)
                .HasColumnName("Keyword");
        });

        modelBuilder.Entity<Location>(entity =>
        {
            entity.HasKey(e => e.LocationId).HasName("PK__Location__E7FEA477236E439F");

            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.DistrictId).HasColumnName("DistrictID");
            entity.Property(e => e.LocationAddr).HasMaxLength(200);
            entity.Property(e => e.LocationLat).HasColumnType("numeric(9, 6)");
            entity.Property(e => e.LocationLng).HasColumnType("numeric(9, 6)");
            entity.Property(e => e.LocationName).HasMaxLength(50);
            entity.Property(e => e.Rating).HasColumnType("numeric(2, 1)");
            entity.Property(e => e.RegionId).HasColumnName("RegionID");

            entity.HasOne(d => d.District).WithMany(p => p.Locations)
                .HasForeignKey(d => d.DistrictId)
                .HasConstraintName("FK__Locations__Distr__2739D489");

            entity.HasOne(d => d.Region).WithMany(p => p.Locations)
                .HasForeignKey(d => d.RegionId)
                .HasConstraintName("FK__Locations__Regio__2BFE89A6");
        });

        modelBuilder.Entity<LocationKeyword>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.KeywordId).HasColumnName("KeywordID");
            entity.Property(e => e.LocationId).HasColumnName("LocationID");

            entity.HasOne(d => d.Keyword).WithMany()
                .HasForeignKey(d => d.KeywordId)
                .HasConstraintName("FK__LocationK__Keywo__3E1D39E1");

            entity.HasOne(d => d.Location).WithMany()
                .HasForeignKey(d => d.LocationId)
                .HasConstraintName("FK__LocationK__Locat__282DF8C2");
        });

        modelBuilder.Entity<LocationPic>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.LocationId).HasColumnName("LocationID");

            entity.HasOne(d => d.Location).WithMany()
                .HasForeignKey(d => d.LocationId)
                .HasConstraintName("FK__LocationP__Locat__2645B050");
        });

        modelBuilder.Entity<NewsPic>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.NewsId).HasColumnName("NewsID");
            entity.Property(e => e.NewsPic1).HasColumnName("NewsPic");

            entity.HasOne(d => d.News).WithMany()
                .HasForeignKey(d => d.NewsId)
                .HasConstraintName("FK__NewsPics__NewsID__55F4C372");
        });

        modelBuilder.Entity<NewsTable>(entity =>
        {
            entity.HasKey(e => e.NewsId).HasName("PK__NewsTabl__954EBDD3EBDB7D80");

            entity.ToTable("NewsTable");

            entity.Property(e => e.NewsId).HasColumnName("NewsID");
            entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");
            entity.Property(e => e.NewsTitle).HasMaxLength(200);

            entity.HasOne(d => d.Employee).WithMany(p => p.NewsTables)
                .HasPrincipalKey(p => p.EmployeeId)
                .HasForeignKey(d => d.EmployeeId)
                .HasConstraintName("FK__NewsTable__Emplo__55009F39");
        });

        modelBuilder.Entity<OrderPaymentInfo>(entity =>
        {
            entity.HasKey(e => e.PaymentId).HasName("PK__OrderPay__9B556A58A74D4FCD");

            entity.ToTable("OrderPaymentInfo");

            entity.Property(e => e.PaymentId).HasColumnName("PaymentID");
            entity.Property(e => e.OrderId).HasColumnName("OrderID");
            entity.Property(e => e.PaymentStatusId).HasColumnName("PaymentStatusID");

            entity.HasOne(d => d.Order).WithMany(p => p.OrderPaymentInfos)
                .HasForeignKey(d => d.OrderId)
                .HasConstraintName("FK__OrderPaym__Order__498EEC8D");

            entity.HasOne(d => d.PaymentStatus).WithMany(p => p.OrderPaymentInfos)
                .HasForeignKey(d => d.PaymentStatusId)
                .HasConstraintName("FK__OrderPaym__Payme__489AC854");
        });

        modelBuilder.Entity<OrderStatus>(entity =>
        {
            entity.HasKey(e => e.OrderStatusId).HasName("PK__OrderSta__BC674F41E5AA8B7D");

            entity.ToTable("OrderStatus");

            entity.Property(e => e.OrderStatusId).HasColumnName("OrderStatusID");
            entity.Property(e => e.StatusDesc).HasMaxLength(50);
        });

        modelBuilder.Entity<PaymentStatus>(entity =>
        {
            entity.HasKey(e => e.PayMentStatusId).HasName("PK__PaymentS__F177127FB5B95734");

            entity.ToTable("PaymentStatus");

            entity.Property(e => e.PayMentStatusId).HasColumnName("PayMentStatusID");
            entity.Property(e => e.StatusDesc).HasMaxLength(50);
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.ProductId).HasName("PK__Products__B40CC6EDF3B48DFB");

            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.ProductDesc).HasMaxLength(200);
            entity.Property(e => e.ProductName).HasMaxLength(150);
            entity.Property(e => e.ProductNote).HasMaxLength(200);
            entity.Property(e => e.RegionId).HasColumnName("RegionID");

            entity.HasOne(d => d.Region).WithMany(p => p.Products)
                .HasForeignKey(d => d.RegionId)
                .HasConstraintName("FK__Products__Region__2B0A656D");
        });

        modelBuilder.Entity<ProductAnalysis>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ProductAnalysis");

            entity.Property(e => e.ProductId).HasColumnName("ProductID");

            entity.HasOne(d => d.Product).WithMany()
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK__ProductAn__Produ__1CBC4616");
        });

        modelBuilder.Entity<ProductPic>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.ProductId).HasColumnName("ProductID");

            entity.HasOne(d => d.Product).WithMany()
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK__ProductPi__Produ__1BC821DD");
        });

        modelBuilder.Entity<ProductsHotel>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Products_Hotels");

            entity.Property(e => e.HotelId).HasColumnName("HotelID");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");

            entity.HasOne(d => d.Hotel).WithMany()
                .HasForeignKey(d => d.HotelId)
                .HasConstraintName("FK__Products___Hotel__1AD3FDA4");

            entity.HasOne(d => d.Product).WithMany()
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK__Products___Produ__19DFD96B");
        });

        modelBuilder.Entity<ProductsLocation>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Products_Locations");

            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");

            entity.HasOne(d => d.Location).WithMany()
                .HasForeignKey(d => d.LocationId)
                .HasConstraintName("FK__Products___Locat__2A164134");

            entity.HasOne(d => d.Product).WithMany()
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK__Products___Produ__29221CFB");
        });

        modelBuilder.Entity<ProductsPromotion>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Products_Promotions");

            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.PromoId).HasColumnName("PromoID");

            entity.HasOne(d => d.Product).WithMany()
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK__Products___Produ__540C7B00");

            entity.HasOne(d => d.Promo).WithMany()
                .HasForeignKey(d => d.PromoId)
                .HasConstraintName("FK__Products___Promo__531856C7");
        });

        modelBuilder.Entity<ProductsRestaurant>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Products_Restaurants");

            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.RestaurantId).HasColumnName("RestaurantID");

            entity.HasOne(d => d.Product).WithMany()
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK__Products___Produ__32AB8735");

            entity.HasOne(d => d.Restaurant).WithMany()
                .HasForeignKey(d => d.RestaurantId)
                .HasConstraintName("FK__Products___Resta__339FAB6E");
        });

        modelBuilder.Entity<ProductsTransportation>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Products_Transportations");

            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.TransportId).HasColumnName("TransportID");

            entity.HasOne(d => d.Product).WithMany()
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK__Products___Produ__2180FB33");

            entity.HasOne(d => d.Transport).WithMany()
                .HasForeignKey(d => d.TransportId)
                .HasConstraintName("FK__Products___Trans__245D67DE");
        });

        modelBuilder.Entity<Promotion>(entity =>
        {
            entity.HasKey(e => e.PromoId).HasName("PK__Promotio__33D334D0CFE2D6D4");

            entity.Property(e => e.PromoId).HasColumnName("PromoID");
            entity.Property(e => e.DiscountValue).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.PromoName).HasMaxLength(200);
        });

        modelBuilder.Entity<Region>(entity =>
        {
            entity.HasKey(e => e.RegionId).HasName("PK__Regions__ACD84443C77B3F0E");

            entity.Property(e => e.RegionId).HasColumnName("RegionID");
            entity.Property(e => e.RegionName).HasMaxLength(10);
        });

        modelBuilder.Entity<Restaurant>(entity =>
        {
            entity.HasKey(e => e.RestaurantId).HasName("PK__Restaura__87454CB5115F360F");

            entity.Property(e => e.RestaurantId).HasColumnName("RestaurantID");
            entity.Property(e => e.DistrictId).HasColumnName("DistrictID");
            entity.Property(e => e.Rating).HasColumnType("numeric(2, 1)");
            entity.Property(e => e.RegionId).HasColumnName("RegionID");
            entity.Property(e => e.RestaurantAddr).HasMaxLength(200);
            entity.Property(e => e.RestaurantLat).HasColumnType("numeric(9, 6)");
            entity.Property(e => e.RestaurantLng).HasColumnType("numeric(9, 6)");
            entity.Property(e => e.RestaurantName).HasMaxLength(50);

            entity.HasOne(d => d.District).WithMany(p => p.Restaurants)
                .HasForeignKey(d => d.DistrictId)
                .HasConstraintName("FK__Restauran__Distr__30C33EC3");

            entity.HasOne(d => d.Region).WithMany(p => p.Restaurants)
                .HasForeignKey(d => d.RegionId)
                .HasConstraintName("FK__Restauran__Regio__2CF2ADDF");
        });

        modelBuilder.Entity<RestaurantKeyword>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.KeywordId).HasColumnName("KeywordID");
            entity.Property(e => e.RestaurantId).HasColumnName("RestaurantID");

            entity.HasOne(d => d.Keyword).WithMany()
                .HasForeignKey(d => d.KeywordId)
                .HasConstraintName("FK__Restauran__Keywo__3C34F16F");

            entity.HasOne(d => d.Restaurant).WithMany()
                .HasForeignKey(d => d.RestaurantId)
                .HasConstraintName("FK__Restauran__Resta__2EDAF651");
        });

        modelBuilder.Entity<RestaurantPic>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.RestaurantId).HasColumnName("RestaurantID");

            entity.HasOne(d => d.Restaurant).WithMany()
                .HasForeignKey(d => d.RestaurantId)
                .HasConstraintName("FK__Restauran__Resta__2FCF1A8A");
        });

        modelBuilder.Entity<SemiHotel>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Semi_Hotels");

            entity.Property(e => e.HotelId).HasColumnName("HotelID");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");

            entity.HasOne(d => d.Hotel).WithMany()
                .HasForeignKey(d => d.HotelId)
                .HasConstraintName("FK__Semi_Hote__Hotel__367C1819");

            entity.HasOne(d => d.Product).WithMany()
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK__Semi_Hote__Produ__37703C52");
        });

        modelBuilder.Entity<SemiLocation>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Semi_Locations");

            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.ProductId).HasColumnName("ProductID");

            entity.HasOne(d => d.Location).WithMany()
                .HasForeignKey(d => d.LocationId)
                .HasConstraintName("FK__Semi_Loca__Locat__3493CFA7");

            entity.HasOne(d => d.Product).WithMany()
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK__Semi_Loca__Produ__3587F3E0");
        });

        modelBuilder.Entity<SemiSelfProduct>(entity =>
        {
            entity.HasKey(e => e.ProductId).HasName("PK__SemiSelf__B40CC6EDD5768615");

            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.ProjectName).HasMaxLength(100);
        });

        modelBuilder.Entity<SemiTransportation>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Semi_Transportations");

            entity.Property(e => e.ProductId).HasColumnName("ProductID");
            entity.Property(e => e.TransportId).HasColumnName("TransportID");

            entity.HasOne(d => d.Product).WithMany()
                .HasForeignKey(d => d.ProductId)
                .HasConstraintName("FK__Semi_Tran__Produ__395884C4");

            entity.HasOne(d => d.Transport).WithMany()
                .HasForeignKey(d => d.TransportId)
                .HasConstraintName("FK__Semi_Tran__Trans__3864608B");
        });

        modelBuilder.Entity<SupportAnalysis>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SupportAnalysis");

            entity.Property(e => e.DateId).HasColumnName("DateID");
            entity.Property(e => e.TicketId).HasColumnName("TicketID");
            entity.Property(e => e.TopCategory).HasMaxLength(200);

            entity.HasOne(d => d.Date).WithMany()
                .HasForeignKey(d => d.DateId)
                .HasConstraintName("FK__SupportAn__DateI__57DD0BE4");

            entity.HasOne(d => d.Ticket).WithMany()
                .HasForeignKey(d => d.TicketId)
                .HasConstraintName("FK__SupportAn__Ticke__56E8E7AB");
        });

        modelBuilder.Entity<TicketPriority>(entity =>
        {
            entity.HasKey(e => e.PriorityId).HasName("PK__TicketPr__D0A3D0DE8CA44994");

            entity.ToTable("TicketPriority");

            entity.Property(e => e.PriorityId).HasColumnName("PriorityID");
            entity.Property(e => e.PriorityDesc).HasMaxLength(100);
        });

        modelBuilder.Entity<TicketStatus>(entity =>
        {
            entity.HasKey(e => e.StatusId).HasName("PK__TicketSt__C8EE2043B1BA9CF2");

            entity.ToTable("TicketStatus");

            entity.Property(e => e.StatusId).HasColumnName("StatusID");
            entity.Property(e => e.StatusDesc).HasMaxLength(100);
        });

        modelBuilder.Entity<TicketType>(entity =>
        {
            entity.HasKey(e => e.TicketTypeId).HasName("PK__TicketTy__6CD684519F2882C9");

            entity.Property(e => e.TicketTypeId).HasColumnName("TicketTypeID");
            entity.Property(e => e.TicketTypeName).HasMaxLength(200);
        });

        modelBuilder.Entity<TransportKeyword>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.KeywordId).HasColumnName("KeywordID");
            entity.Property(e => e.TransportId).HasColumnName("TransportID");

            entity.HasOne(d => d.Keyword).WithMany()
                .HasForeignKey(d => d.KeywordId)
                .HasConstraintName("FK__Transport__Keywo__3F115E1A");

            entity.HasOne(d => d.Transport).WithMany()
                .HasForeignKey(d => d.TransportId)
                .HasConstraintName("FK__Transport__Trans__22751F6C");
        });

        modelBuilder.Entity<TransportPic>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.TransportId).HasColumnName("TransportID");

            entity.HasOne(d => d.Transport).WithMany()
                .HasForeignKey(d => d.TransportId)
                .HasConstraintName("FK__Transport__Trans__236943A5");
        });

        modelBuilder.Entity<Transportation>(entity =>
        {
            entity.HasKey(e => e.TransportId).HasName("PK__Transpor__19E9A17D4EBAE12B");

            entity.Property(e => e.TransportId).HasColumnName("TransportID");
            entity.Property(e => e.Rating).HasColumnType("numeric(2, 1)");
            entity.Property(e => e.TransportName).HasMaxLength(30);
        });

        modelBuilder.Entity<TripProjectDetail>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.HotelId).HasColumnName("HotelID");
            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.ProjectId).HasColumnName("ProjectID");
            entity.Property(e => e.RestaurantId).HasColumnName("RestaurantID");
            entity.Property(e => e.TransportId).HasColumnName("TransportID");
            entity.Property(e => e.TripType).HasMaxLength(50);

            entity.HasOne(d => d.Hotel).WithMany()
                .HasForeignKey(d => d.HotelId)
                .HasConstraintName("FK__TripProje__Hotel__208CD6FA");

            entity.HasOne(d => d.Location).WithMany()
                .HasForeignKey(d => d.LocationId)
                .HasConstraintName("FK__TripProje__Locat__25518C17");

            entity.HasOne(d => d.Project).WithMany()
                .HasForeignKey(d => d.ProjectId)
                .HasConstraintName("FK__TripProje__Proje__3A4CA8FD");

            entity.HasOne(d => d.Restaurant).WithMany()
                .HasForeignKey(d => d.RestaurantId)
                .HasConstraintName("FK__TripProje__Resta__31B762FC");

            entity.HasOne(d => d.Transport).WithMany()
                .HasForeignKey(d => d.TransportId)
                .HasConstraintName("FK__TripProje__Trans__3B40CD36");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
