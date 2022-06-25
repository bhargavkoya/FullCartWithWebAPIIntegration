﻿// <auto-generated />
using System;
using E_CommerceAPI.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace E_CommerceAPI.Migrations
{
    [DbContext(typeof(ShoppingDbContext))]
    partial class ShoppingDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("E_CommerceAPI.Models.Address", b =>
                {
                    b.Property<int>("AddressId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("AddressLineone")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("AddressLinetwo")
                        .HasColumnType("text");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("CustId")
                        .HasColumnType("integer");

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PhoneNo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PinCode")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("AddressId");

                    b.HasIndex("CustId");

                    b.ToTable("Address");
                });

            modelBuilder.Entity("E_CommerceAPI.Models.Admin", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("Balance")
                        .HasColumnType("integer");

                    b.Property<string>("ConfirmPassword")
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("character varying(12)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("UserId");

                    b.ToTable("Admin");
                });

            modelBuilder.Entity("E_CommerceAPI.Models.Cart", b =>
                {
                    b.Property<int>("CartId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("FreeDelivery")
                        .HasColumnType("boolean");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.Property<int>("Quantity")
                        .HasColumnType("integer");

                    b.Property<int>("Userid")
                        .HasColumnType("integer");

                    b.Property<string>("productImage")
                        .HasColumnType("text");

                    b.Property<string>("productName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("CartId");

                    b.HasIndex("Userid");

                    b.ToTable("Cart");
                });

            modelBuilder.Entity("E_CommerceAPI.Models.Customer", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("Balance")
                        .HasColumnType("integer");

                    b.Property<string>("ConfirmPassword")
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("character varying(12)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("UserId");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("E_CommerceAPI.Models.ElectronicDevice", b =>
                {
                    b.Property<int>("EId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<bool>("Active")
                        .HasColumnType("boolean");

                    b.Property<int>("Category")
                        .HasColumnType("integer");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<int>("EBrand")
                        .HasColumnType("integer");

                    b.Property<string>("EName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("FreeDelivery")
                        .HasColumnType("boolean");

                    b.Property<string>("ImageFile")
                        .HasColumnType("text");

                    b.Property<DateTime>("LaunchDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.Property<int>("Quantity")
                        .HasColumnType("integer");

                    b.Property<int>("Rating")
                        .HasColumnType("integer");

                    b.HasKey("EId");

                    b.ToTable("ElectronicDevice");
                });

            modelBuilder.Entity("E_CommerceAPI.Models.Fashion", b =>
                {
                    b.Property<int>("FId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<bool>("Active")
                        .HasColumnType("boolean");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<int>("FBrand")
                        .HasColumnType("integer");

                    b.Property<string>("FName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("FType")
                        .HasColumnType("integer");

                    b.Property<bool>("FreeDelivery")
                        .HasColumnType("boolean");

                    b.Property<string>("ImageFile")
                        .HasColumnType("text");

                    b.Property<DateTime>("LaunchDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.Property<int>("Quantity")
                        .HasColumnType("integer");

                    b.Property<int>("Rating")
                        .HasColumnType("integer");

                    b.Property<int>("SubCategory")
                        .HasColumnType("integer");

                    b.HasKey("FId");

                    b.ToTable("Fashion");
                });

            modelBuilder.Entity("E_CommerceAPI.Models.HomeDecor", b =>
                {
                    b.Property<int>("HId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<bool>("Active")
                        .HasColumnType("boolean");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<bool>("FreeDelivery")
                        .HasColumnType("boolean");

                    b.Property<int>("HBrand")
                        .HasColumnType("integer");

                    b.Property<string>("HName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("HType")
                        .HasColumnType("integer");

                    b.Property<string>("ImageFile")
                        .HasColumnType("text");

                    b.Property<DateTime>("LaunchDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.Property<int>("Quantity")
                        .HasColumnType("integer");

                    b.Property<int>("Rating")
                        .HasColumnType("integer");

                    b.HasKey("HId");

                    b.ToTable("HomeDecor");
                });

            modelBuilder.Entity("E_CommerceAPI.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("AddrId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("DateOfDelivery")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("DateOfOrder")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("OrderStatus")
                        .HasColumnType("integer");

                    b.Property<int>("PaymentMode")
                        .HasColumnType("integer");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.HasKey("OrderId");

                    b.HasIndex("AddrId");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("E_CommerceAPI.Models.OrderReview", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<int>("OId")
                        .HasColumnType("integer");

                    b.Property<int>("O_Rating")
                        .HasColumnType("integer");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.Property<int>("UserID")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("UserID");

                    b.ToTable("OrderReview");
                });

            modelBuilder.Entity("E_CommerceAPI.Models.Payment", b =>
                {
                    b.Property<int>("PId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<double>("Balance")
                        .HasColumnType("double precision");

                    b.Property<string>("CardHolderName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<long>("CardNumber")
                        .HasColumnType("bigint");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("PId");

                    b.ToTable("Payment");
                });

            modelBuilder.Entity("E_CommerceAPI.Models.Address", b =>
                {
                    b.HasOne("E_CommerceAPI.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("E_CommerceAPI.Models.Cart", b =>
                {
                    b.HasOne("E_CommerceAPI.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("Userid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("E_CommerceAPI.Models.Order", b =>
                {
                    b.HasOne("E_CommerceAPI.Models.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddrId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Address");
                });

            modelBuilder.Entity("E_CommerceAPI.Models.OrderReview", b =>
                {
                    b.HasOne("E_CommerceAPI.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });
#pragma warning restore 612, 618
        }
    }
}
