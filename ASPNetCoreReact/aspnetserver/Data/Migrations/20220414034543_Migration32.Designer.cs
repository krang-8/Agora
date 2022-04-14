﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using aspnetserver.Data;

#nullable disable

namespace aspnetserver.Data.Migrations
{
    [DbContext(typeof(AppDBContext))]
    [Migration("20220414034543_Migration32")]
    partial class Migration32
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.3");

            modelBuilder.Entity("aspnetserver.Data.Buyer", b =>
                {
                    b.Property<int>("BuyerId")
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

                    b.Property<int>("CartID")
                        .HasMaxLength(32)
                        .HasColumnType("INTEGER");

                    b.Property<int>("UserId")
                        .HasMaxLength(32)
                        .HasColumnType("INTEGER");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("TEXT");

                    b.HasKey("BuyerId");

                    b.ToTable("Buyers");

                    b.HasData(
                        new
                        {
                            BuyerId = 1,
                            Address1 = "addy",
                            Address2 = "ta",
                            Address3 = "bhai home",
                            CartID = 0,
                            UserId = 1,
                            name = "test"
                        },
                        new
                        {
                            BuyerId = 3,
                            Address1 = "addy",
                            Address2 = "ta",
                            Address3 = "bhai home",
                            CartID = 5000,
                            UserId = 3,
                            name = "test"
                        },
                        new
                        {
                            BuyerId = 5,
                            Address1 = "addy",
                            Address2 = "ta",
                            Address3 = "bhai home",
                            CartID = 10000,
                            UserId = 5,
                            name = "test"
                        });
                });

            modelBuilder.Entity("aspnetserver.Data.Cart", b =>
                {
                    b.Property<int>("CartID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("BuyerID")
                        .HasMaxLength(9999)
                        .HasColumnType("INTEGER");

                    b.Property<string>("Quantity")
                        .IsRequired()
                        .HasMaxLength(999999)
                        .HasColumnType("TEXT");

                    b.Property<string>("cartItems")
                        .IsRequired()
                        .HasMaxLength(999999)
                        .HasColumnType("TEXT");

                    b.HasKey("CartID");

                    b.ToTable("Carts");

                    b.HasData(
                        new
                        {
                            CartID = 1000,
                            BuyerID = 1,
                            Quantity = "1,1,2",
                            cartItems = "1,2,4"
                        },
                        new
                        {
                            CartID = 2000,
                            BuyerID = 2,
                            Quantity = "1,1,2",
                            cartItems = "1,2,4"
                        },
                        new
                        {
                            CartID = 3000,
                            BuyerID = 3,
                            Quantity = "1,1,2",
                            cartItems = "1,2,4"
                        },
                        new
                        {
                            CartID = 4000,
                            BuyerID = 4,
                            Quantity = "1,1,2",
                            cartItems = "1,2,4"
                        },
                        new
                        {
                            CartID = 5000,
                            BuyerID = 5,
                            Quantity = "1,1,2",
                            cartItems = "1,2,4"
                        },
                        new
                        {
                            CartID = 6000,
                            BuyerID = 6,
                            Quantity = "1,1,2",
                            cartItems = "1,2,4"
                        });
                });

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
                        .HasMaxLength(32)
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
                            image = "https://www.freelogoservices.com/blog/wp-content/uploads/iStock-458591871.jpg",
                            itemName = "Item 1",
                            itemPrice = 10,
                            stock = 50
                        },
                        new
                        {
                            ItemID = 2,
                            Description = "This is item 2 and it is very cheap.",
                            SellerID = 2000,
                            image = "https://www.freelogoservices.com/blog/wp-content/uploads/iStock-458591871.jpg",
                            itemName = "Item 2",
                            itemPrice = 20,
                            stock = 100
                        },
                        new
                        {
                            ItemID = 3,
                            Description = "This is item 3 and it is very cheap.",
                            SellerID = 3000,
                            image = "https://www.freelogoservices.com/blog/wp-content/uploads/iStock-458591871.jpg",
                            itemName = "Item 3",
                            itemPrice = 30,
                            stock = 150
                        },
                        new
                        {
                            ItemID = 4,
                            Description = "This is item 4 and it is very cheap.",
                            SellerID = 4000,
                            image = "https://www.freelogoservices.com/blog/wp-content/uploads/iStock-458591871.jpg",
                            itemName = "Item 4",
                            itemPrice = 40,
                            stock = 200
                        },
                        new
                        {
                            ItemID = 5,
                            Description = "This is item 5 and it is very cheap.",
                            SellerID = 5000,
                            image = "https://www.freelogoservices.com/blog/wp-content/uploads/iStock-458591871.jpg",
                            itemName = "Item 5",
                            itemPrice = 50,
                            stock = 250
                        },
                        new
                        {
                            ItemID = 6,
                            Description = "This is item 6 and it is very cheap.",
                            SellerID = 6000,
                            image = "https://www.freelogoservices.com/blog/wp-content/uploads/iStock-458591871.jpg",
                            itemName = "Item 6",
                            itemPrice = 60,
                            stock = 300
                        });
                });

            modelBuilder.Entity("aspnetserver.Data.Order", b =>
                {
                    b.Property<int>("OrderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("BuyerID")
                        .HasMaxLength(9999)
                        .HasColumnType("INTEGER");

                    b.Property<string>("FromAddress")
                        .IsRequired()
                        .HasMaxLength(999999)
                        .HasColumnType("TEXT");

                    b.Property<string>("ToAddress")
                        .IsRequired()
                        .HasMaxLength(999999)
                        .HasColumnType("TEXT");

                    b.HasKey("OrderID");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("aspnetserver.Data.Seller", b =>
                {
                    b.Property<int>("SellerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address1")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("TEXT");

                    b.Property<int>("UserId")
                        .HasMaxLength(32)
                        .HasColumnType("INTEGER");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("TEXT");

                    b.HasKey("SellerId");

                    b.ToTable("Sellers");

                    b.HasData(
                        new
                        {
                            SellerId = 2,
                            Address1 = "addy",
                            UserId = 2,
                            name = "test"
                        },
                        new
                        {
                            SellerId = 4,
                            Address1 = "addy",
                            UserId = 4,
                            name = "test"
                        },
                        new
                        {
                            SellerId = 6,
                            Address1 = "addy",
                            UserId = 6,
                            name = "test"
                        });
                });

            modelBuilder.Entity("aspnetserver.Data.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

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
                            password = "password",
                            userType = 1,
                            username = "User1"
                        },
                        new
                        {
                            UserId = 2,
                            password = "password",
                            userType = 0,
                            username = "User2"
                        },
                        new
                        {
                            UserId = 3,
                            password = "password",
                            userType = 1,
                            username = "User3"
                        },
                        new
                        {
                            UserId = 4,
                            password = "password",
                            userType = 0,
                            username = "User4"
                        },
                        new
                        {
                            UserId = 5,
                            password = "password",
                            userType = 1,
                            username = "User5"
                        },
                        new
                        {
                            UserId = 6,
                            password = "password",
                            userType = 0,
                            username = "User6"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
