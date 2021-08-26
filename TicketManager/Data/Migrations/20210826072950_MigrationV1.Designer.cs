﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TicketManager.Data;

namespace TicketManager.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210826072950_MigrationV1")]
    partial class MigrationV1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

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
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("TicketManager.Models.Concert", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LocationId")
                        .HasColumnType("int");

                    b.Property<int>("SingerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LocationId");

                    b.HasIndex("SingerId");

                    b.ToTable("Concerts");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Concert");
                });

            modelBuilder.Entity("TicketManager.Models.Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Latitude")
                        .HasColumnType("float");

                    b.Property<double>("Longitude")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("NameRu")
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.HasKey("Id");

                    b.ToTable("Locations");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Latitude = 33.333300000000001,
                            Longitude = 44.444400000000002,
                            Name = "Unknown location"
                        },
                        new
                        {
                            Id = 2,
                            Latitude = 22.222200000000001,
                            Longitude = 55.555500000000002,
                            Name = "Another location"
                        });
                });

            modelBuilder.Entity("TicketManager.Models.PromoCode", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<double>("Coefficient")
                        .HasColumnType("float");

                    b.Property<int>("ConcertId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ConcertId");

                    b.ToTable("PromoCodes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Code = "QWERTY",
                            Coefficient = 0.90000000000000002,
                            ConcertId = 1
                        },
                        new
                        {
                            Id = 2,
                            Code = "PromoCode420",
                            Coefficient = 0.80000000000000004,
                            ConcertId = 1
                        },
                        new
                        {
                            Id = 3,
                            Code = "SuperCode",
                            Coefficient = 0.75,
                            ConcertId = 2
                        },
                        new
                        {
                            Id = 4,
                            Code = "McCode",
                            Coefficient = 0.90000000000000002,
                            ConcertId = 3
                        });
                });

            modelBuilder.Entity("TicketManager.Models.Singer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Singers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Nightwish"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Dio"
                        },
                        new
                        {
                            Id = 3,
                            Name = "The Offspring"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Some classic singer"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Another singer"
                        });
                });

            modelBuilder.Entity("TicketManager.Models.Ticket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ConcertId")
                        .HasColumnType("int");

                    b.Property<bool>("IsReserved")
                        .HasColumnType("bit");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("ConcertId");

                    b.HasIndex("UserId");

                    b.ToTable("Tickets");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ConcertId = 1,
                            IsReserved = false
                        },
                        new
                        {
                            Id = 2,
                            ConcertId = 1,
                            IsReserved = false
                        },
                        new
                        {
                            Id = 3,
                            ConcertId = 1,
                            IsReserved = false
                        },
                        new
                        {
                            Id = 4,
                            ConcertId = 2,
                            IsReserved = false
                        },
                        new
                        {
                            Id = 5,
                            ConcertId = 2,
                            IsReserved = false
                        },
                        new
                        {
                            Id = 6,
                            ConcertId = 2,
                            IsReserved = false
                        },
                        new
                        {
                            Id = 7,
                            ConcertId = 3,
                            IsReserved = false
                        },
                        new
                        {
                            Id = 8,
                            ConcertId = 3,
                            IsReserved = false
                        },
                        new
                        {
                            Id = 9,
                            ConcertId = 3,
                            IsReserved = false
                        },
                        new
                        {
                            Id = 10,
                            ConcertId = 4,
                            IsReserved = false
                        },
                        new
                        {
                            Id = 11,
                            ConcertId = 4,
                            IsReserved = false
                        },
                        new
                        {
                            Id = 12,
                            ConcertId = 4,
                            IsReserved = false
                        });
                });

            modelBuilder.Entity("TicketManager.Models.ApplicationUser", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.HasDiscriminator().HasValue("ApplicationUser");

                    b.HasData(
                        new
                        {
                            Id = "ab07a835-1db0-4610-8661-380134b7d361",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "6acd4474-1cff-4a41-ae57-3ea0918c9938",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedUserName = "ADMIN@CONCERTS.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEDxdknSoSe/5vy5G7Q0DQ1nnLD4RgnvF6EKOY5abo466zd59E0MHy9l9tHmmf41YcA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "cf72a5af-8574-4e87-a5b1-cf0f42ab2a89",
                            TwoFactorEnabled = false,
                            UserName = "admin@concerts.com"
                        },
                        new
                        {
                            Id = "5c9b1c79-8cb8-4d85-b693-f8b1f6560dcd",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "20e9aa4f-bde8-4bf3-bb19-c9b74238d28c",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedUserName = "USER1@MAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEG066ACnO7Pe3JWrtW9/Xv7E3wVmPkPDDKzilniraysOh8gRKXSaYgEyiL/XqF5zhA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "acbf103b-05c7-4f0d-b64a-5ca663f140f7",
                            TwoFactorEnabled = false,
                            UserName = "user1@mail.com"
                        },
                        new
                        {
                            Id = "79e3f8c0-d2cb-4fc0-b688-df6a4079cbec",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "d6a5afe4-7e6c-4850-b33d-f6da17f7e471",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedUserName = "USER2@CONCERTS.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEPB7NBK/JWcy09rgwGeOXWC1ix69P+ubHHfbtoxkp8Aq3n8VhQzYBvTO7hnX0c61rA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "fa2d822d-a09b-47f7-bc1c-dba620e63c22",
                            TwoFactorEnabled = false,
                            UserName = "user2@concerts.com"
                        },
                        new
                        {
                            Id = "79e3f8c0-d3cb-4fc0-b688-df6a4079cbec",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "ad96f93b-9a1a-42b0-a4f2-0ba65e7e7965",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedUserName = "TEST@MAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEJY8MjXFHHKboBJdQsh879cbaz7ISt1cv3RH7LkbpU0kKRGt10mzogwPTaDt8qQyFA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "c8e1646f-0679-43a6-ace8-8b45cb87a688",
                            TwoFactorEnabled = false,
                            UserName = "test@mail.com"
                        });
                });

            modelBuilder.Entity("TicketManager.Models.ConcertTypes.ClassicMusic", b =>
                {
                    b.HasBaseType("TicketManager.Models.Concert");

                    b.Property<string>("Composer")
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("ConcertName")
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("VoiceType")
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.HasDiscriminator().HasValue("ClassicMusic");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Date = new DateTime(2021, 9, 26, 10, 29, 49, 895, DateTimeKind.Local).AddTicks(4027),
                            LocationId = 1,
                            SingerId = 1,
                            Composer = "Unknown",
                            ConcertName = "Classic#1",
                            VoiceType = "Tenor"
                        });
                });

            modelBuilder.Entity("TicketManager.Models.ConcertTypes.OpenAir", b =>
                {
                    b.HasBaseType("TicketManager.Models.Concert");

                    b.Property<string>("Headliner")
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("LocationInstruction")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasDiscriminator().HasValue("OpenAir");

                    b.HasData(
                        new
                        {
                            Id = 4,
                            Date = new DateTime(2021, 11, 26, 10, 29, 49, 897, DateTimeKind.Local).AddTicks(4358),
                            LocationId = 1,
                            SingerId = 3,
                            Headliner = "YOOO HEADLINER",
                            LocationInstruction = "Turn left, turn right"
                        });
                });

            modelBuilder.Entity("TicketManager.Models.ConcertTypes.Party", b =>
                {
                    b.HasBaseType("TicketManager.Models.Concert");

                    b.Property<string>("DocumentAgeConfirmation")
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.HasDiscriminator().HasValue("Party");

                    b.HasData(
                        new
                        {
                            Id = 2,
                            Date = new DateTime(2021, 10, 26, 10, 29, 49, 897, DateTimeKind.Local).AddTicks(3424),
                            LocationId = 2,
                            SingerId = 1,
                            DocumentAgeConfirmation = "Passport"
                        },
                        new
                        {
                            Id = 3,
                            Date = new DateTime(2021, 9, 26, 10, 29, 49, 897, DateTimeKind.Local).AddTicks(3784),
                            LocationId = 2,
                            SingerId = 1,
                            DocumentAgeConfirmation = "Passport"
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

            modelBuilder.Entity("TicketManager.Models.Concert", b =>
                {
                    b.HasOne("TicketManager.Models.Location", "Location")
                        .WithMany()
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TicketManager.Models.Singer", "Singer")
                        .WithMany()
                        .HasForeignKey("SingerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Location");

                    b.Navigation("Singer");
                });

            modelBuilder.Entity("TicketManager.Models.PromoCode", b =>
                {
                    b.HasOne("TicketManager.Models.Concert", "Concert")
                        .WithMany("PromoCodes")
                        .HasForeignKey("ConcertId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Concert");
                });

            modelBuilder.Entity("TicketManager.Models.Ticket", b =>
                {
                    b.HasOne("TicketManager.Models.Concert", "Concert")
                        .WithMany("Tickets")
                        .HasForeignKey("ConcertId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TicketManager.Models.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("Concert");

                    b.Navigation("User");
                });

            modelBuilder.Entity("TicketManager.Models.Concert", b =>
                {
                    b.Navigation("PromoCodes");

                    b.Navigation("Tickets");
                });
#pragma warning restore 612, 618
        }
    }
}