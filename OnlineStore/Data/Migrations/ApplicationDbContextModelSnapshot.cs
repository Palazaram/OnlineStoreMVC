﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OnlineStore.Data;

#nullable disable

namespace OnlineStore.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.21")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
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

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

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
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
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

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
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

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("OnlineStore.Models.Entities.CartDetail", b =>
                {
                    b.Property<int>("CartDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CartDetailId"), 1L, 1);

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("INT");

                    b.Property<int>("ShoppingCartId")
                        .HasColumnType("int");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("MONEY");

                    b.HasKey("CartDetailId");

                    b.HasIndex("ProductId");

                    b.HasIndex("ShoppingCartId");

                    b.ToTable("CartDetails");
                });

            modelBuilder.Entity("OnlineStore.Models.Entities.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"), 1L, 1);

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("NVARCHAR(30)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Овочі"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Фрукти"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Квіти"
                        });
                });

            modelBuilder.Entity("OnlineStore.Models.Entities.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderId"), 1L, 1);

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("BIT");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("DATE");

                    b.Property<int>("OrderStatusId")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(450)");

                    b.HasKey("OrderId");

                    b.HasIndex("OrderStatusId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("OnlineStore.Models.Entities.OrderList", b =>
                {
                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("INT");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("MONEY");

                    b.HasKey("OrderId", "ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderList");

                    b.HasCheckConstraint("CK_Quantity", "Quantity >= 0");
                });

            modelBuilder.Entity("OnlineStore.Models.Entities.OrderStatus", b =>
                {
                    b.Property<int>("OrderStatusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderStatusId"), 1L, 1);

                    b.Property<string>("OrderStatusName")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(20)");

                    b.HasKey("OrderStatusId");

                    b.ToTable("OrderStatus");

                    b.HasData(
                        new
                        {
                            OrderStatusId = 1,
                            OrderStatusName = "Pending"
                        },
                        new
                        {
                            OrderStatusId = 2,
                            OrderStatusName = "Completed"
                        },
                        new
                        {
                            OrderStatusId = 3,
                            OrderStatusName = "Shipped"
                        },
                        new
                        {
                            OrderStatusId = 4,
                            OrderStatusName = "Cancelled"
                        },
                        new
                        {
                            OrderStatusId = 5,
                            OrderStatusName = "Declined"
                        },
                        new
                        {
                            OrderStatusId = 6,
                            OrderStatusName = "Refunded"
                        },
                        new
                        {
                            OrderStatusId = 7,
                            OrderStatusName = "Disputed"
                        });
                });

            modelBuilder.Entity("OnlineStore.Models.Entities.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("ProductDescription")
                        .HasMaxLength(450)
                        .HasColumnType("NVARCHAR(450)");

                    b.Property<string>("ProductImageName")
                        .HasColumnType("NVARCHAR(450)");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("NVARCHAR(100)");

                    b.Property<decimal>("ProductPrice")
                        .HasColumnType("MONEY");

                    b.Property<int>("SupplierId")
                        .HasColumnType("int");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("SupplierId");

                    b.ToTable("Products");

                    b.HasCheckConstraint("CK_ProductPrice", "ProductPrice >= 0");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            CategoryId = 1,
                            ProductDescription = "Середньоранній (50-54 дні) гібрид корніншонного типу.",
                            ProductImageName = "vegetables/cucumber/sm_ogurec-akter.jpg",
                            ProductName = "ОГІРОК АКТОР F1",
                            ProductPrice = 9.00m,
                            SupplierId = 1
                        },
                        new
                        {
                            ProductId = 2,
                            CategoryId = 1,
                            ProductDescription = "Пізній сорт селекції голландської фірми Syngenta. Термін дозрівання 115-120 днів.",
                            ProductImageName = "vegetables/cabbage/sm_agressor.jpg",
                            ProductName = "КАПУСТА АГРЕСОР F1",
                            ProductPrice = 18.00m,
                            SupplierId = 2
                        },
                        new
                        {
                            ProductId = 3,
                            CategoryId = 1,
                            ProductDescription = "Середньостиглий, технічна стиглість плодів настає через 118-120 днів після сходів.",
                            ProductImageName = "vegetables/eggplant/sm_almaz.jpg",
                            ProductName = "БАКЛАЖАН АЛМАЗ",
                            ProductPrice = 6.20m,
                            SupplierId = 3
                        },
                        new
                        {
                            ProductId = 4,
                            CategoryId = 1,
                            ProductDescription = "Середньоранній високоврожайний сорт. Період вегетації становить 80-110 днів.",
                            ProductImageName = "vegetables/sugarbeet/sm_egipetskaya-ploskaya.jpg",
                            ProductName = "БУРЯК ЄГИПЕТСЬКИЙ ПЛОСКИЙ",
                            ProductPrice = 6.00m,
                            SupplierId = 1
                        },
                        new
                        {
                            ProductId = 5,
                            CategoryId = 2,
                            ProductDescription = "Новий середньостиглий сорт селекції Дніпропетровської дослідної станції.",
                            ProductImageName = "fruits/melon/sm_ineya.jpg",
                            ProductName = "ДИНЯ ІНЕЯ",
                            ProductPrice = 6.20m,
                            SupplierId = 1
                        },
                        new
                        {
                            ProductId = 6,
                            CategoryId = 2,
                            ProductDescription = "Середньоранній (80-90 днів) італійський гібрид кавуна для відкритого ґрунту і плівкових укриттів.",
                            ProductImageName = "fruits/watermelon/sm_arbuz-imperator.jpg",
                            ProductName = "КАВУН ІМПЕРАТОР F1",
                            ProductPrice = 14.00m,
                            SupplierId = 3
                        },
                        new
                        {
                            ProductId = 7,
                            CategoryId = 3,
                            ProductDescription = "Сортотип американських кущових айстр.",
                            ProductImageName = "flowers/sm_amerikanskaya-krasavica.jpg",
                            ProductName = "АЙСТРА АМЕРИКАНСЬКА КРАСУНЯ",
                            ProductPrice = 6.00m,
                            SupplierId = 3
                        },
                        new
                        {
                            ProductId = 8,
                            CategoryId = 3,
                            ProductDescription = "Кущ компактний, висотою 50-55 см.",
                            ProductImageName = "flowers/sm_imperiya.jpg",
                            ProductName = "АЙСТРА ІМПЕРІЯ",
                            ProductPrice = 6.00m,
                            SupplierId = 2
                        },
                        new
                        {
                            ProductId = 9,
                            CategoryId = 3,
                            ProductDescription = "Сортотип півонієвидних айстр. Кущ напіврозлогий, висотою 55-60 см.",
                            ProductImageName = "flowers/sm_ivenus.jpg",
                            ProductName = "АЙСТРА ІВЕНУС",
                            ProductPrice = 6.00m,
                            SupplierId = 1
                        });
                });

            modelBuilder.Entity("OnlineStore.Models.Entities.ShoppingCart", b =>
                {
                    b.Property<int>("ShoppingCartId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ShoppingCartId"), 1L, 1);

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("BIT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(450)");

                    b.HasKey("ShoppingCartId");

                    b.ToTable("ShoppingCart");
                });

            modelBuilder.Entity("OnlineStore.Models.Entities.Supplier", b =>
                {
                    b.Property<int>("SupplierId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SupplierId"), 1L, 1);

                    b.Property<string>("SupplierEmail")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(30)");

                    b.Property<string>("SupplierName")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(30)");

                    b.Property<string>("SupplierPhone")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(30)");

                    b.HasKey("SupplierId");

                    b.ToTable("Suppliers");

                    b.HasData(
                        new
                        {
                            SupplierId = 1,
                            SupplierEmail = "veles@gmail.com",
                            SupplierName = "Велес",
                            SupplierPhone = "+380 (67) 716-14-19"
                        },
                        new
                        {
                            SupplierId = 2,
                            SupplierEmail = "helios@gmail.com",
                            SupplierName = "Геліос",
                            SupplierPhone = "+380 (66) 312-77-80"
                        },
                        new
                        {
                            SupplierId = 3,
                            SupplierEmail = "floramarket@gmail.com",
                            SupplierName = "Флорамаркет",
                            SupplierPhone = "+380 (67) 273-61-10"
                        });
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

            modelBuilder.Entity("OnlineStore.Models.Entities.CartDetail", b =>
                {
                    b.HasOne("OnlineStore.Models.Entities.Product", "Product")
                        .WithMany("CartDetails")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OnlineStore.Models.Entities.ShoppingCart", "ShoppingCart")
                        .WithMany("CartDetails")
                        .HasForeignKey("ShoppingCartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("ShoppingCart");
                });

            modelBuilder.Entity("OnlineStore.Models.Entities.Order", b =>
                {
                    b.HasOne("OnlineStore.Models.Entities.OrderStatus", "OrderStatus")
                        .WithMany("Orders")
                        .HasForeignKey("OrderStatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OrderStatus");
                });

            modelBuilder.Entity("OnlineStore.Models.Entities.OrderList", b =>
                {
                    b.HasOne("OnlineStore.Models.Entities.Order", "Order")
                        .WithMany("OrderList")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OnlineStore.Models.Entities.Product", "Product")
                        .WithMany("OrderList")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("OnlineStore.Models.Entities.Product", b =>
                {
                    b.HasOne("OnlineStore.Models.Entities.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OnlineStore.Models.Entities.Supplier", "Supplier")
                        .WithMany("Products")
                        .HasForeignKey("SupplierId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Supplier");
                });

            modelBuilder.Entity("OnlineStore.Models.Entities.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("OnlineStore.Models.Entities.Order", b =>
                {
                    b.Navigation("OrderList");
                });

            modelBuilder.Entity("OnlineStore.Models.Entities.OrderStatus", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("OnlineStore.Models.Entities.Product", b =>
                {
                    b.Navigation("CartDetails");

                    b.Navigation("OrderList");
                });

            modelBuilder.Entity("OnlineStore.Models.Entities.ShoppingCart", b =>
                {
                    b.Navigation("CartDetails");
                });

            modelBuilder.Entity("OnlineStore.Models.Entities.Supplier", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
