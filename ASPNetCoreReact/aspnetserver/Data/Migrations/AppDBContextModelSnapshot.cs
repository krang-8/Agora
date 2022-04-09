﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using aspnetserver.Data;

#nullable disable

namespace aspnetserver.Data.Migrations
{
    [DbContext(typeof(AppDBContext))]
    partial class AppDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.3");

            modelBuilder.Entity("aspnetserver.Data.Item", b =>
                {
                    b.Property<int>("ItemID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(10000)
                        .HasColumnType("TEXT");

                    b.Property<int>("SellerID")
                        .HasMaxLength(9999)
                        .HasColumnType("INTEGER");

                    b.Property<string>("image")
                        .IsRequired()
                        .HasMaxLength(10000)
                        .HasColumnType("TEXT");

                    b.Property<string>("itemName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<int>("itemPrice")
                        .HasMaxLength(9999)
                        .HasColumnType("INTEGER");

                    b.Property<int>("stock")
                        .HasMaxLength(9999)
                        .HasColumnType("INTEGER");

                    b.HasKey("ItemID");

                    b.ToTable("Items");

                    b.HasData(
                        new
                        {
                            ItemID = 1,
                            Description = "This is item 1 and it is very cheap.",
                            SellerID = 1000,
                            image = "URL",
                            itemName = "Post 1",
                            itemPrice = 10,
                            stock = 50
                        },
                        new
                        {
                            ItemID = 2,
                            Description = "This is item 2 and it is very cheap.",
                            SellerID = 2000,
                            image = "URL",
                            itemName = "Post 2",
                            itemPrice = 20,
                            stock = 100
                        },
                        new
                        {
                            ItemID = 3,
                            Description = "This is item 3 and it is very cheap.",
                            SellerID = 3000,
                            image = "URL",
                            itemName = "Post 3",
                            itemPrice = 30,
                            stock = 150
                        },
                        new
                        {
                            ItemID = 4,
                            Description = "This is item 4 and it is very cheap.",
                            SellerID = 4000,
                            image = "URL",
                            itemName = "Post 4",
                            itemPrice = 40,
                            stock = 200
                        },
                        new
                        {
                            ItemID = 5,
                            Description = "This is item 5 and it is very cheap.",
                            SellerID = 5000,
                            image = "URL",
                            itemName = "Post 5",
                            itemPrice = 50,
                            stock = 250
                        },
                        new
                        {
                            ItemID = 6,
                            Description = "This is item 6 and it is very cheap.",
                            SellerID = 6000,
                            image = "URL",
                            itemName = "Post 6",
                            itemPrice = 60,
                            stock = 300
                        });
                });

            modelBuilder.Entity("aspnetserver.Data.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address1")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("TEXT");

                    b.Property<string>("Address2")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("TEXT");

                    b.Property<string>("Address3")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("TEXT");

                    b.Property<int>("cartID")
                        .HasMaxLength(1000)
                        .HasColumnType("INTEGER");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("TEXT");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasMaxLength(16)
                        .HasColumnType("TEXT");

                    b.Property<int>("userType")
                        .HasColumnType("INTEGER");

                    b.Property<string>("username")
                        .IsRequired()
                        .HasMaxLength(16)
                        .HasColumnType("TEXT");

                    b.HasKey("UserId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            Address1 = "My Location 1",
                            Address2 = "My Location 2",
                            Address3 = "My Location 3",
                            cartID = 1000,
                            name = "My name is Agent 1",
                            password = "This is item 1 and it is very cheap.",
                            userType = 1,
                            username = "Post 1"
                        },
                        new
                        {
                            UserId = 2,
                            Address1 = "My Location 1",
                            Address2 = "My Location 2",
                            Address3 = "My Location 3",
                            cartID = 2000,
                            name = "My name is Agent 2",
                            password = "This is item 2 and it is very cheap.",
                            userType = 0,
                            username = "Post 2"
                        },
                        new
                        {
                            UserId = 3,
                            Address1 = "My Location 1",
                            Address2 = "My Location 2",
                            Address3 = "My Location 3",
                            cartID = 3000,
                            name = "My name is Agent 3",
                            password = "This is item 3 and it is very cheap.",
                            userType = 1,
                            username = "Post 3"
                        },
                        new
                        {
                            UserId = 4,
                            Address1 = "My Location 1",
                            Address2 = "My Location 2",
                            Address3 = "My Location 3",
                            cartID = 4000,
                            name = "My name is Agent 4",
                            password = "This is item 4 and it is very cheap.",
                            userType = 0,
                            username = "Post 4"
                        },
                        new
                        {
                            UserId = 5,
                            Address1 = "My Location 1",
                            Address2 = "My Location 2",
                            Address3 = "My Location 3",
                            cartID = 5000,
                            name = "My name is Agent 5",
                            password = "This is item 5 and it is very cheap.",
                            userType = 1,
                            username = "Post 5"
                        },
                        new
                        {
                            UserId = 6,
                            Address1 = "My Location 1",
                            Address2 = "My Location 2",
                            Address3 = "My Location 3",
                            cartID = 6000,
                            name = "My name is Agent 6",
                            password = "This is item 6 and it is very cheap.",
                            userType = 0,
                            username = "Post 6"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
