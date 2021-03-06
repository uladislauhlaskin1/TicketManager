using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TicketManager.Models;
using TicketManager.Models.ConcertTypes;

namespace TicketManager.Data
{
    public class ApplicationDbContext : IdentityDbContext //ApiAuthorizationDbContext<ApplicationUser>//
    {
        public DbSet<Singer> Singers { get; set; }
        public DbSet<Concert> Concerts { get; set; }
        public DbSet<Party> Parties { get; set; }
        public DbSet<ClassicMusic> ClassicMusics { get; set; }
        public DbSet<OpenAir> OpenAirs { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<PromoCode> PromoCodes { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //todo: seed in another class
            SeedUsers(modelBuilder);
            SeedSingers(modelBuilder);
            SeedLocations(modelBuilder);
            SeedConcerts(modelBuilder);
            SeedTickets(modelBuilder);
            SeedPromoCodes(modelBuilder);
        }

        private static void SeedUsers(ModelBuilder modelBuilder)
        {
            var hasher = new PasswordHasher<ApplicationUser>();
            modelBuilder.Entity<ApplicationUser>().HasData(
            new ApplicationUser[]
            {
                new ApplicationUser
                {
                    Id = "ab07a835-1db0-4610-8661-380134b7d361",
                    UserName = "admin@mail.com",
                    NormalizedUserName = "ADMIN@MAIL.COM",
                    PasswordHash = hasher.HashPassword(null, "123aA!"),
                    EmailConfirmed = true,
                    
                },
                new ApplicationUser
                {
                    Id = "5c9b1c79-8cb8-4d85-b693-f8b1f6560dcd",
                    UserName = "user1@mail.com",
                    NormalizedUserName = "USER1@MAIL.COM",
                    PasswordHash = hasher.HashPassword(null, "123aA!"),
                    EmailConfirmed = true
                },
                new ApplicationUser
                {
                    Id = "79e3f8c0-d2cb-4fc0-b688-df6a4079cbec",
                    UserName = "user2@mail.com",
                    NormalizedUserName = "USER2@MAIL.COM",
                    PasswordHash = hasher.HashPassword(null, "123aA!"),
                    EmailConfirmed = true
                },
                new ApplicationUser
                {
                    Id = "79e3f8c0-d3cb-4fc0-b688-df6a4079cbec",
                    UserName = "test@mail.com",
                    NormalizedUserName = "TEST@MAIL.COM",
                    PasswordHash = hasher.HashPassword(null, "Pa$$w0rd"),
                    EmailConfirmed = true
                },

            });

            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole { Id = "2c5e174e-3b0e-446f-86af-483d56fd7210", Name = "Administrator", NormalizedName = "ADMINISTRATOR".ToUpper()
                });

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
            new IdentityUserRole<string>
            {
                RoleId = "2c5e174e-3b0e-446f-86af-483d56fd7210",
                UserId = "ab07a835-1db0-4610-8661-380134b7d361"
            }
        );
        }

        private static void SeedSingers(ModelBuilder modelBuilder)
        {
            int i = 1;
            modelBuilder.Entity<Singer>().HasData(
            new Singer[]
            {
                new Singer { Id = i++, Name = "Nightwish"},
                new Singer { Id = i++, Name = "Dio"},
                new Singer { Id = i++, Name = "The Offspring"},
                new Singer { Id = i++, Name = "Some classic singer"},
                new Singer { Id = i++, Name = "Another singer"},
            });
        }

        private static void SeedLocations(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Location>().HasData(
            new Location[]
            {
                new Location { Id = 1, Latitude = 53.915048, Longitude = 27.6980264, Name = "Unknown location"},
                new Location { Id = 2, Latitude = 53.836269, Longitude = 27.413867, Name = "Another location"},
            });
        }

        private static void SeedConcerts(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ClassicMusic>().HasData(
                new ClassicMusic { Id = 1, SingerId = 1, LocationId = 1, Date = DateTime.Now.AddMonths(1), Composer = "Unknown", ConcertName = "Classic#1", VoiceType = "Tenor" }
                );

            modelBuilder.Entity<Party>().HasData(
                new Party { Id = 2, SingerId = 1, LocationId = 2, Date = DateTime.Now.AddMonths(2), DocumentAgeConfirmation = "Passport" },
                new Party { Id = 3, SingerId = 1, LocationId = 2, Date = DateTime.Now.AddMonths(1), DocumentAgeConfirmation = "Passport" }
                );

            modelBuilder.Entity<OpenAir>().HasData(
                new OpenAir { Id = 4, SingerId = 3, LocationId = 1, Date = DateTime.Now.AddMonths(3), Headliner = "YOOO HEADLINER", LocationInstruction = "Turn left, turn right" }
                );
        }

        private static void SeedPromoCodes(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PromoCode>().HasData(
                new PromoCode[]
                {
                    new PromoCode { Id = 1, Code = "QWERTY", Coefficient = 0.9, ConcertId = 1 },
                    new PromoCode { Id = 2, Code = "PromoCode420", Coefficient = 0.8, ConcertId = 1 },
                    new PromoCode { Id = 3, Code = "SuperCode", Coefficient = 0.75, ConcertId = 2 },
                    new PromoCode { Id = 4, Code = "McCode", Coefficient = 0.9, ConcertId = 3 },
                });
        }

        private static void SeedTickets(ModelBuilder modelBuilder)
        {
            int id = 1;
            modelBuilder.Entity<Ticket>().HasData(
            new Ticket[]
            {
                new Ticket { Id = id++, ConcertId = 1, IsReserved = false },
                new Ticket { Id = id++, ConcertId = 1, IsReserved = false },
                new Ticket { Id = id++, ConcertId = 1, IsReserved = false },
                new Ticket { Id = id++, ConcertId = 2, IsReserved = false },
                new Ticket { Id = id++, ConcertId = 2, IsReserved = false },
                new Ticket { Id = id++, ConcertId = 2, IsReserved = false },
                new Ticket { Id = id++, ConcertId = 3, IsReserved = false },
                new Ticket { Id = id++, ConcertId = 3, IsReserved = false },
                new Ticket { Id = id++, ConcertId = 3, IsReserved = false },
                new Ticket { Id = id++, ConcertId = 4, IsReserved = false },
                new Ticket { Id = id++, ConcertId = 4, IsReserved = false },
                new Ticket { Id = id++, ConcertId = 4, IsReserved = false },
            });
        }

    }
}
