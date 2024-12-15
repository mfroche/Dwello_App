﻿// <auto-generated />
using System;
using Dwello_App.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Dwello_App.Migrations
{
    [DbContext(typeof(DwelloContext))]
    [Migration("20241210214935_SeedUserTable")]
    partial class SeedUserTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Dwello_App.Models.Bookings", b =>
                {
                    b.Property<int>("BookingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookingId"));

                    b.Property<DateTime>("CheckInDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CheckOutDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ListingId")
                        .HasColumnType("int");

                    b.Property<int>("NumOfDays")
                        .HasColumnType("int");

                    b.Property<int?>("PaymentsPaymentId")
                        .HasColumnType("int");

                    b.Property<int>("Rate")
                        .HasColumnType("int");

                    b.Property<int?>("ReviewsReviewId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("BookingId");

                    b.HasIndex("PaymentsPaymentId");

                    b.HasIndex("ReviewsReviewId");

                    b.ToTable("Bookings");
                });

            modelBuilder.Entity("Dwello_App.Models.Host", b =>
                {
                    b.Property<int>("HostId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HostId"));

                    b.Property<int>("HostRating")
                        .HasColumnType("int");

                    b.Property<int?>("ListingsListingId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("HostId");

                    b.HasIndex("ListingsListingId");

                    b.ToTable("Hosts");
                });

            modelBuilder.Entity("Dwello_App.Models.Listings", b =>
                {
                    b.Property<int>("ListingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ListingId"));

                    b.Property<int?>("BookingsBookingId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("HostId")
                        .HasColumnType("int");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ListingId");

                    b.HasIndex("BookingsBookingId");

                    b.ToTable("Listings");
                });

            modelBuilder.Entity("Dwello_App.Models.Payments", b =>
                {
                    b.Property<int>("PaymentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PaymentId"));

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int>("BookingId")
                        .HasColumnType("int");

                    b.Property<string>("PaymentMethod")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PaymentId");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("Dwello_App.Models.Reviews", b =>
                {
                    b.Property<int>("ReviewId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReviewId"));

                    b.Property<int>("BookingId")
                        .HasColumnType("int");

                    b.Property<string>("Feedback")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("ReviewId");

                    b.HasIndex("UserId");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("Dwello_App.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<int?>("BookingsBookingId")
                        .HasColumnType("int");

                    b.Property<int?>("HostId")
                        .HasColumnType("int");

                    b.Property<string>("UserAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserFirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserLastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.HasIndex("BookingsBookingId");

                    b.HasIndex("HostId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            UserAddress = "123 Main Street",
                            UserDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                            UserEmail = "john.doe@example.com",
                            UserFirstName = "John",
                            UserLastName = "Doe"
                        },
                        new
                        {
                            UserId = 2,
                            UserAddress = "456 Oak Avenue",
                            UserDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
                            UserEmail = "jane.smith@example.com",
                            UserFirstName = "Jane",
                            UserLastName = "Smith"
                        });
                });

            modelBuilder.Entity("Dwello_App.Models.Bookings", b =>
                {
                    b.HasOne("Dwello_App.Models.Payments", null)
                        .WithMany("Bookings")
                        .HasForeignKey("PaymentsPaymentId");

                    b.HasOne("Dwello_App.Models.Reviews", null)
                        .WithMany("Bookings")
                        .HasForeignKey("ReviewsReviewId");
                });

            modelBuilder.Entity("Dwello_App.Models.Host", b =>
                {
                    b.HasOne("Dwello_App.Models.Listings", null)
                        .WithMany("Hosts")
                        .HasForeignKey("ListingsListingId");
                });

            modelBuilder.Entity("Dwello_App.Models.Listings", b =>
                {
                    b.HasOne("Dwello_App.Models.Bookings", null)
                        .WithMany("Listings")
                        .HasForeignKey("BookingsBookingId");
                });

            modelBuilder.Entity("Dwello_App.Models.Reviews", b =>
                {
                    b.HasOne("Dwello_App.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Dwello_App.Models.User", b =>
                {
                    b.HasOne("Dwello_App.Models.Bookings", null)
                        .WithMany("Users")
                        .HasForeignKey("BookingsBookingId");

                    b.HasOne("Dwello_App.Models.Host", null)
                        .WithMany("Users")
                        .HasForeignKey("HostId");
                });

            modelBuilder.Entity("Dwello_App.Models.Bookings", b =>
                {
                    b.Navigation("Listings");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("Dwello_App.Models.Host", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("Dwello_App.Models.Listings", b =>
                {
                    b.Navigation("Hosts");
                });

            modelBuilder.Entity("Dwello_App.Models.Payments", b =>
                {
                    b.Navigation("Bookings");
                });

            modelBuilder.Entity("Dwello_App.Models.Reviews", b =>
                {
                    b.Navigation("Bookings");
                });
#pragma warning restore 612, 618
        }
    }
}
