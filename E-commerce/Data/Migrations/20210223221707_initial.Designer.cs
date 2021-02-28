﻿// <auto-generated />
using System;
using Data.DbContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Data.Migrations
{
    [DbContext(typeof(E_commerceDB))]
    [Migration("20210223221707_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Data.EntityModels.Branch", b =>
                {
                    b.Property<int>("BranchID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CityID")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WorkingHours")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BranchID");

                    b.HasIndex("CityID");

                    b.ToTable("Branch");
                });

            modelBuilder.Entity("Data.EntityModels.BrandCategory", b =>
                {
                    b.Property<int>("BrandCategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BrandCategoryID");

                    b.ToTable("BrandCategory");
                });

            modelBuilder.Entity("Data.EntityModels.Category", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryID");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("Data.EntityModels.Check", b =>
                {
                    b.Property<int>("CheckID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CouponID")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<float>("Discount")
                        .HasColumnType("real");

                    b.Property<int>("PaymentMethodID")
                        .HasColumnType("int");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.Property<float>("TotalPrice")
                        .HasColumnType("real");

                    b.HasKey("CheckID");

                    b.HasIndex("CouponID");

                    b.HasIndex("PaymentMethodID");

                    b.ToTable("Check");
                });

            modelBuilder.Entity("Data.EntityModels.City", b =>
                {
                    b.Property<int>("CityID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PostalCode")
                        .HasColumnType("int");

                    b.HasKey("CityID");

                    b.ToTable("City");
                });

            modelBuilder.Entity("Data.EntityModels.Coupon", b =>
                {
                    b.Property<int>("CouponID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ExpiredDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsValid")
                        .HasColumnType("bit");

                    b.Property<float>("Value")
                        .HasColumnType("real");

                    b.HasKey("CouponID");

                    b.ToTable("Coupon");
                });

            modelBuilder.Entity("Data.EntityModels.CreditCard", b =>
                {
                    b.Property<int>("CreditCardID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CardNumber")
                        .HasColumnType("int");

                    b.Property<string>("CardType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CustomerID")
                        .HasColumnType("int");

                    b.Property<string>("CustomerID1")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("ExpDate")
                        .HasColumnType("int");

                    b.Property<string>("Expyear")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CreditCardID");

                    b.HasIndex("CustomerID1");

                    b.ToTable("CreditCard");
                });

            modelBuilder.Entity("Data.EntityModels.Customer", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AccountID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<float>("TotalSpent")
                        .HasColumnType("real");

                    b.HasKey("ID");

                    b.HasIndex("AccountID")
                        .IsUnique()
                        .HasFilter("[AccountID] IS NOT NULL");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("Data.EntityModels.Employee", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AccountID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("BranchID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("AccountID")
                        .IsUnique()
                        .HasFilter("[AccountID] IS NOT NULL");

                    b.HasIndex("BranchID");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("Data.EntityModels.GenderCategory", b =>
                {
                    b.Property<int>("GenderCategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GenderCategoryID");

                    b.ToTable("GenderCategory");
                });

            modelBuilder.Entity("Data.EntityModels.HistoryOfPayments", b =>
                {
                    b.Property<int>("HistoryOfPaymentsID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CheckID")
                        .HasColumnType("int");

                    b.Property<int?>("CustomerID")
                        .HasColumnType("int");

                    b.Property<string>("CustomerID1")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.HasKey("HistoryOfPaymentsID");

                    b.HasIndex("CheckID")
                        .IsUnique();

                    b.HasIndex("CustomerID1");

                    b.ToTable("HistoryOfPayments");
                });

            modelBuilder.Entity("Data.EntityModels.Inventory", b =>
                {
                    b.Property<int>("InventoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BranchID")
                        .HasColumnType("int");

                    b.Property<bool>("IsAvailable")
                        .HasColumnType("bit");

                    b.Property<int>("ItemSizeID")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("InventoryID");

                    b.HasIndex("BranchID");

                    b.HasIndex("ItemSizeID");

                    b.ToTable("Inventory");
                });

            modelBuilder.Entity("Data.EntityModels.Item", b =>
                {
                    b.Property<int>("ItemID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BrandCategoryID")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GenderCategoryID")
                        .HasColumnType("int");

                    b.Property<int>("ItemCostHistoryID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.Property<string>("SerialNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SubCategoryID")
                        .HasColumnType("int");

                    b.HasKey("ItemID");

                    b.HasIndex("BrandCategoryID");

                    b.HasIndex("GenderCategoryID");

                    b.HasIndex("ItemCostHistoryID");

                    b.HasIndex("SubCategoryID");

                    b.ToTable("Item");
                });

            modelBuilder.Entity("Data.EntityModels.ItemCostHistory", b =>
                {
                    b.Property<int>("ItemCostHistoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("CurrentPrice")
                        .HasColumnType("real");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<float>("PreviousPrice")
                        .HasColumnType("real");

                    b.HasKey("ItemCostHistoryID");

                    b.ToTable("ItemCostHistory");
                });

            modelBuilder.Entity("Data.EntityModels.ItemSize", b =>
                {
                    b.Property<int>("ItemSizeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ItemID")
                        .HasColumnType("int");

                    b.Property<int>("SizeID")
                        .HasColumnType("int");

                    b.HasKey("ItemSizeID");

                    b.HasIndex("ItemID");

                    b.HasIndex("SizeID");

                    b.ToTable("ItemSize");
                });

            modelBuilder.Entity("Data.EntityModels.Order", b =>
                {
                    b.Property<int>("OrderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<float>("Discount")
                        .HasColumnType("real");

                    b.Property<int>("ItemSizeID")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("ShoppingCartID")
                        .HasColumnType("int");

                    b.Property<float>("TotalPrice")
                        .HasColumnType("real");

                    b.Property<float>("UnitCost")
                        .HasColumnType("real");

                    b.HasKey("OrderID");

                    b.HasIndex("ItemSizeID");

                    b.HasIndex("ShoppingCartID");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("Data.EntityModels.PaymentMethod", b =>
                {
                    b.Property<int>("PaymentMethodID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PaymentMethodID");

                    b.ToTable("PaymentMethod");
                });

            modelBuilder.Entity("Data.EntityModels.Purchase", b =>
                {
                    b.Property<int>("PurchaseID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BranchID")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("EmployeeID")
                        .HasColumnType("int");

                    b.Property<string>("EmployeeID1")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("ItemSizeID")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("PurchaseID");

                    b.HasIndex("BranchID");

                    b.HasIndex("EmployeeID1");

                    b.HasIndex("ItemSizeID");

                    b.ToTable("Purchase");
                });

            modelBuilder.Entity("Data.EntityModels.ShoppingCart", b =>
                {
                    b.Property<int>("ShoppingCartID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("BranchID")
                        .HasColumnType("int");

                    b.Property<int>("CheckID")
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CreditCardID")
                        .HasColumnType("int");

                    b.Property<int?>("CustomerID")
                        .HasColumnType("int");

                    b.Property<string>("CustomerID1")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<float>("TotalPrice")
                        .HasColumnType("real");

                    b.HasKey("ShoppingCartID");

                    b.HasIndex("BranchID");

                    b.HasIndex("CheckID")
                        .IsUnique();

                    b.HasIndex("CreditCardID");

                    b.HasIndex("CustomerID1");

                    b.ToTable("ShoppingCart");
                });

            modelBuilder.Entity("Data.EntityModels.Size", b =>
                {
                    b.Property<int>("SizeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SizeID");

                    b.ToTable("Size");
                });

            modelBuilder.Entity("Data.EntityModels.SubCategory", b =>
                {
                    b.Property<int>("SubCategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SubCategoryID");

                    b.HasIndex("CategoryID");

                    b.ToTable("SubCategory");
                });

            modelBuilder.Entity("Data.EntityModels.Warehouse", b =>
                {
                    b.Property<int>("WarehouseID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BranchID")
                        .HasColumnType("int");

                    b.Property<int>("CurrentBalance")
                        .HasColumnType("int");

                    b.Property<int>("Income")
                        .HasColumnType("int");

                    b.Property<int>("ItemSizeID")
                        .HasColumnType("int");

                    b.Property<int>("PreviousBalance")
                        .HasColumnType("int");

                    b.Property<int>("Sold")
                        .HasColumnType("int");

                    b.HasKey("WarehouseID");

                    b.HasIndex("BranchID");

                    b.HasIndex("ItemSizeID");

                    b.ToTable("Warehouse");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Data.EntityModels.Account", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Account");
                });

            modelBuilder.Entity("Data.EntityModels.Branch", b =>
                {
                    b.HasOne("Data.EntityModels.City", "City")
                        .WithMany()
                        .HasForeignKey("CityID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Data.EntityModels.Check", b =>
                {
                    b.HasOne("Data.EntityModels.Coupon", "Coupon")
                        .WithMany()
                        .HasForeignKey("CouponID");

                    b.HasOne("Data.EntityModels.PaymentMethod", "PaymentMethod")
                        .WithMany()
                        .HasForeignKey("PaymentMethodID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Data.EntityModels.CreditCard", b =>
                {
                    b.HasOne("Data.EntityModels.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerID1");
                });

            modelBuilder.Entity("Data.EntityModels.Customer", b =>
                {
                    b.HasOne("Data.EntityModels.Account", "Account")
                        .WithOne("Customer")
                        .HasForeignKey("Data.EntityModels.Customer", "AccountID");
                });

            modelBuilder.Entity("Data.EntityModels.Employee", b =>
                {
                    b.HasOne("Data.EntityModels.Account", "Account")
                        .WithOne("Employee")
                        .HasForeignKey("Data.EntityModels.Employee", "AccountID");

                    b.HasOne("Data.EntityModels.Branch", "Branch")
                        .WithMany()
                        .HasForeignKey("BranchID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Data.EntityModels.HistoryOfPayments", b =>
                {
                    b.HasOne("Data.EntityModels.Check", "Check")
                        .WithOne("HistoryOfPayments")
                        .HasForeignKey("Data.EntityModels.HistoryOfPayments", "CheckID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data.EntityModels.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerID1");
                });

            modelBuilder.Entity("Data.EntityModels.Inventory", b =>
                {
                    b.HasOne("Data.EntityModels.Branch", "Branch")
                        .WithMany()
                        .HasForeignKey("BranchID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data.EntityModels.ItemSize", "ItemSize")
                        .WithMany()
                        .HasForeignKey("ItemSizeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Data.EntityModels.Item", b =>
                {
                    b.HasOne("Data.EntityModels.BrandCategory", "BrandCategory")
                        .WithMany()
                        .HasForeignKey("BrandCategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data.EntityModels.GenderCategory", "GenderCategory")
                        .WithMany()
                        .HasForeignKey("GenderCategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data.EntityModels.ItemCostHistory", "ItemCostHistory")
                        .WithMany()
                        .HasForeignKey("ItemCostHistoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data.EntityModels.SubCategory", "SubCategory")
                        .WithMany()
                        .HasForeignKey("SubCategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Data.EntityModels.ItemSize", b =>
                {
                    b.HasOne("Data.EntityModels.Item", "Item")
                        .WithMany()
                        .HasForeignKey("ItemID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data.EntityModels.Size", "Size")
                        .WithMany()
                        .HasForeignKey("SizeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Data.EntityModels.Order", b =>
                {
                    b.HasOne("Data.EntityModels.ItemSize", "ItemSize")
                        .WithMany()
                        .HasForeignKey("ItemSizeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data.EntityModels.ShoppingCart", "ShoppingCart")
                        .WithMany()
                        .HasForeignKey("ShoppingCartID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Data.EntityModels.Purchase", b =>
                {
                    b.HasOne("Data.EntityModels.Branch", "Branch")
                        .WithMany()
                        .HasForeignKey("BranchID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data.EntityModels.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeID1");

                    b.HasOne("Data.EntityModels.ItemSize", "ItemSize")
                        .WithMany()
                        .HasForeignKey("ItemSizeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Data.EntityModels.ShoppingCart", b =>
                {
                    b.HasOne("Data.EntityModels.Branch", "Branch")
                        .WithMany()
                        .HasForeignKey("BranchID");

                    b.HasOne("Data.EntityModels.Check", "Check")
                        .WithOne("ShoppingCart")
                        .HasForeignKey("Data.EntityModels.ShoppingCart", "CheckID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data.EntityModels.CreditCard", "CreditCard")
                        .WithMany()
                        .HasForeignKey("CreditCardID");

                    b.HasOne("Data.EntityModels.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerID1");
                });

            modelBuilder.Entity("Data.EntityModels.SubCategory", b =>
                {
                    b.HasOne("Data.EntityModels.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Data.EntityModels.Warehouse", b =>
                {
                    b.HasOne("Data.EntityModels.Branch", "Branch")
                        .WithMany()
                        .HasForeignKey("BranchID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Data.EntityModels.ItemSize", "ItemSize")
                        .WithMany()
                        .HasForeignKey("ItemSizeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
