﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SmartphonePortal_Vervoort_Wagner.Server.Data;

#nullable disable

namespace SmartphonePortal_Vervoort_Wagner.Server.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230412063433_add_username_to_review")]
    partial class add_username_to_review
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.15");

            modelBuilder.Entity("Duende.IdentityServer.EntityFramework.Entities.DeviceFlowCodes", b =>
                {
                    b.Property<string>("UserCode")
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<string>("ClientId")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("Data")
                        .IsRequired()
                        .HasMaxLength(50000)
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<string>("DeviceCode")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("Expiration")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("SessionId")
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("SubjectId")
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.HasKey("UserCode");

                    b.HasIndex("DeviceCode")
                        .IsUnique();

                    b.HasIndex("Expiration");

                    b.ToTable("DeviceCodes", (string)null);
                });

            modelBuilder.Entity("Duende.IdentityServer.EntityFramework.Entities.Key", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("Algorithm")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Created")
                        .HasColumnType("TEXT");

                    b.Property<string>("Data")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("DataProtected")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsX509Certificate")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Use")
                        .HasColumnType("TEXT");

                    b.Property<int>("Version")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("Use");

                    b.ToTable("Keys");
                });

            modelBuilder.Entity("Duende.IdentityServer.EntityFramework.Entities.PersistedGrant", b =>
                {
                    b.Property<string>("Key")
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<string>("ClientId")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("ConsumedTime")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreationTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("Data")
                        .IsRequired()
                        .HasMaxLength(50000)
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("Expiration")
                        .HasColumnType("TEXT");

                    b.Property<string>("SessionId")
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.Property<string>("SubjectId")
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("Key");

                    b.HasIndex("ConsumedTime");

                    b.HasIndex("Expiration");

                    b.HasIndex("SubjectId", "ClientId", "Type");

                    b.HasIndex("SubjectId", "SessionId", "Type");

                    b.ToTable("PersistedGrants", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "07acc716-9129-452d-9314-c131dccea93e",
                            ConcurrencyStamp = "169dafcb-b161-42e5-8bfe-ad82ed3497d4",
                            Name = "User",
                            NormalizedName = "USER"
                        },
                        new
                        {
                            Id = "c592496a-31b0-4daf-a27b-0d98393a513b",
                            ConcurrencyStamp = "2d0cb3d3-4c89-4599-8a99-ee67e6d3e9ad",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("SmartphonePortal_Vervoort_Wagner.Server.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("TEXT");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("SmartphonePortal_Vervoort_Wagner.Server.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("SmartphonePortal_Vervoort_Wagner.Server.Models.Comment", b =>
                {
                    b.Property<int>("CommentId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("CommentId");

                    b.HasIndex("UserId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("SmartphonePortal_Vervoort_Wagner.Server.Models.Manufacturer", b =>
                {
                    b.Property<int>("ManufacturerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LinkToHomePage")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ManufacturerId");

                    b.ToTable("Manufacturers");
                });

            modelBuilder.Entity("SmartphonePortal_Vervoort_Wagner.Server.Models.Picture", b =>
                {
                    b.Property<int>("PictureId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("PathToData")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("SmartphoneId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("PictureId");

                    b.HasIndex("SmartphoneId");

                    b.ToTable("Pictures");
                });

            modelBuilder.Entity("SmartphonePortal_Vervoort_Wagner.Server.Models.Processor", b =>
                {
                    b.Property<int>("ProcessorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CoreCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Gigaherz")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ProcessorId");

                    b.ToTable("Processors");
                });

            modelBuilder.Entity("SmartphonePortal_Vervoort_Wagner.Server.Models.Rating", b =>
                {
                    b.Property<int>("RatingId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SmartphoneId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Stars")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("RatingId");

                    b.HasIndex("SmartphoneId");

                    b.HasIndex("UserId");

                    b.ToTable("Ratings");
                });

            modelBuilder.Entity("SmartphonePortal_Vervoort_Wagner.Server.Models.Review", b =>
                {
                    b.Property<int>("ReviewId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("SmartphoneId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ReviewId");

                    b.HasIndex("SmartphoneId");

                    b.HasIndex("UserId");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("SmartphonePortal_Vervoort_Wagner.Server.Models.Smartphone", b =>
                {
                    b.Property<int>("SmartphoneId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("DisplaySize")
                        .HasColumnType("REAL");

                    b.Property<int>("ManufacturerId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("ProcessorId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Resolution")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("Weight")
                        .HasColumnType("REAL");

                    b.HasKey("SmartphoneId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("ManufacturerId");

                    b.HasIndex("ProcessorId");

                    b.ToTable("Smartphones");
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
                    b.HasOne("SmartphonePortal_Vervoort_Wagner.Server.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("SmartphonePortal_Vervoort_Wagner.Server.Models.ApplicationUser", null)
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

                    b.HasOne("SmartphonePortal_Vervoort_Wagner.Server.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("SmartphonePortal_Vervoort_Wagner.Server.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SmartphonePortal_Vervoort_Wagner.Server.Models.Comment", b =>
                {
                    b.HasOne("SmartphonePortal_Vervoort_Wagner.Server.Models.Review", "Review")
                        .WithMany("Comments")
                        .HasForeignKey("CommentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SmartphonePortal_Vervoort_Wagner.Server.Models.ApplicationUser", "User")
                        .WithMany("Comments")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Review");

                    b.Navigation("User");
                });

            modelBuilder.Entity("SmartphonePortal_Vervoort_Wagner.Server.Models.Picture", b =>
                {
                    b.HasOne("SmartphonePortal_Vervoort_Wagner.Server.Models.Smartphone", "Smartphone")
                        .WithMany("Pictures")
                        .HasForeignKey("SmartphoneId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Smartphone");
                });

            modelBuilder.Entity("SmartphonePortal_Vervoort_Wagner.Server.Models.Rating", b =>
                {
                    b.HasOne("SmartphonePortal_Vervoort_Wagner.Server.Models.Review", "Review")
                        .WithMany("Ratings")
                        .HasForeignKey("RatingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SmartphonePortal_Vervoort_Wagner.Server.Models.Smartphone", "Smartphone")
                        .WithMany("Ratings")
                        .HasForeignKey("SmartphoneId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SmartphonePortal_Vervoort_Wagner.Server.Models.ApplicationUser", "User")
                        .WithMany("Ratings")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Review");

                    b.Navigation("Smartphone");

                    b.Navigation("User");
                });

            modelBuilder.Entity("SmartphonePortal_Vervoort_Wagner.Server.Models.Review", b =>
                {
                    b.HasOne("SmartphonePortal_Vervoort_Wagner.Server.Models.Smartphone", "Smartphone")
                        .WithMany("Reviews")
                        .HasForeignKey("SmartphoneId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SmartphonePortal_Vervoort_Wagner.Server.Models.ApplicationUser", "User")
                        .WithMany("Reviews")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Smartphone");

                    b.Navigation("User");
                });

            modelBuilder.Entity("SmartphonePortal_Vervoort_Wagner.Server.Models.Smartphone", b =>
                {
                    b.HasOne("SmartphonePortal_Vervoort_Wagner.Server.Models.Category", "Category")
                        .WithMany("Smartphones")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SmartphonePortal_Vervoort_Wagner.Server.Models.Manufacturer", "Manufacturer")
                        .WithMany("Smartphones")
                        .HasForeignKey("ManufacturerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SmartphonePortal_Vervoort_Wagner.Server.Models.Processor", "Processor")
                        .WithMany("Smartphones")
                        .HasForeignKey("ProcessorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Manufacturer");

                    b.Navigation("Processor");
                });

            modelBuilder.Entity("SmartphonePortal_Vervoort_Wagner.Server.Models.ApplicationUser", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("Ratings");

                    b.Navigation("Reviews");
                });

            modelBuilder.Entity("SmartphonePortal_Vervoort_Wagner.Server.Models.Category", b =>
                {
                    b.Navigation("Smartphones");
                });

            modelBuilder.Entity("SmartphonePortal_Vervoort_Wagner.Server.Models.Manufacturer", b =>
                {
                    b.Navigation("Smartphones");
                });

            modelBuilder.Entity("SmartphonePortal_Vervoort_Wagner.Server.Models.Processor", b =>
                {
                    b.Navigation("Smartphones");
                });

            modelBuilder.Entity("SmartphonePortal_Vervoort_Wagner.Server.Models.Review", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("Ratings");
                });

            modelBuilder.Entity("SmartphonePortal_Vervoort_Wagner.Server.Models.Smartphone", b =>
                {
                    b.Navigation("Pictures");

                    b.Navigation("Ratings");

                    b.Navigation("Reviews");
                });
#pragma warning restore 612, 618
        }
    }
}
