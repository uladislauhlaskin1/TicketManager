// <auto-generated />
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
    [Migration("20210827125546_MigrationV5")]
    partial class MigrationV5
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

                    b.HasData(
                        new
                        {
                            Id = "2c5e174e-3b0e-446f-86af-483d56fd7210",
                            ConcurrencyStamp = "e31cdf4f-e1d2-4e70-8d64-7db57d8b6fe0",
                            Name = "Administrator",
                            NormalizedName = "ADMINISTRATOR"
                        });
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

                    b.HasData(
                        new
                        {
                            UserId = "ab07a835-1db0-4610-8661-380134b7d361",
                            RoleId = "2c5e174e-3b0e-446f-86af-483d56fd7210"
                        });
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
                            Latitude = 53.915047999999999,
                            Longitude = 27.6980264,
                            Name = "Unknown location"
                        },
                        new
                        {
                            Id = 2,
                            Latitude = 53.836269000000001,
                            Longitude = 27.413867,
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
                            ConcurrencyStamp = "2bdf0fae-eb6e-455c-8898-01243899df50",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedUserName = "ADMIN@MAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEFQF99yjEIOJuOFCgB6WbqW/kB3ukuNc4HG5oVOep49Aa3Ed+5juydAK/kTqUMfPdw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "2b27053f-afa1-4f3a-a973-cc05cefd4199",
                            TwoFactorEnabled = false,
                            UserName = "admin@mail.com"
                        },
                        new
                        {
                            Id = "5c9b1c79-8cb8-4d85-b693-f8b1f6560dcd",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "f584a65c-2bc5-46f3-a376-be83f7394427",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedUserName = "USER1@MAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEGQpwSn7znHULzfTz3Z8YbqrKJf++f3JiTx10yV8PZsmaai9dlcwSB17o0Y1s17jrg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "5057ba7d-86de-452a-9e84-7c43d35dd161",
                            TwoFactorEnabled = false,
                            UserName = "user1@mail.com"
                        },
                        new
                        {
                            Id = "79e3f8c0-d2cb-4fc0-b688-df6a4079cbec",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "4f9991cf-d0e7-455b-8a81-fcabdc940456",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedUserName = "USER2@MAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEBlUThONCgDzZv3ZuGE/GkY8XVH4lo7St0s8n/3yuC0NG5OfbLtlINvGo1kULu7USQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "6f984fec-daa4-4e16-8f4d-2a6fc8b38026",
                            TwoFactorEnabled = false,
                            UserName = "user2@mail.com"
                        },
                        new
                        {
                            Id = "79e3f8c0-d3cb-4fc0-b688-df6a4079cbec",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "fddc547e-0916-45ae-a7be-8fc1dbf4b8e6",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedUserName = "TEST@MAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAENjmF8cQSd2gKYU1JcPBMB3+EIcpG4MxDlX11HrR6Xjf1WowHvd14z8UqLXH8c+C+A==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "672aafb1-b225-4e42-8585-1301612af6b5",
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
                            Date = new DateTime(2021, 9, 27, 15, 55, 45, 564, DateTimeKind.Local).AddTicks(8111),
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
                            Date = new DateTime(2021, 11, 27, 15, 55, 45, 566, DateTimeKind.Local).AddTicks(9583),
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
                            Date = new DateTime(2021, 10, 27, 15, 55, 45, 566, DateTimeKind.Local).AddTicks(8402),
                            LocationId = 2,
                            SingerId = 1,
                            DocumentAgeConfirmation = "Passport"
                        },
                        new
                        {
                            Id = 3,
                            Date = new DateTime(2021, 9, 27, 15, 55, 45, 566, DateTimeKind.Local).AddTicks(8853),
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
