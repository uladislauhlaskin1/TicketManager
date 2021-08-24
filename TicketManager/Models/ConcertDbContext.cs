using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicketManager.Models
{
    public class ConcertDbContext : IdentityDbContext<IdentityUser> //DbContext
    {
        public DbSet<Band> Bands { get; set; }
        public DbSet<Concert> Concerts { get; set; }
        public DbSet<ConcertType> ConcertTypes { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<PromoCode> PromoCodes { get; set; }

        public ConcertDbContext(DbContextOptions<ConcertDbContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            SeedBands(modelBuilder);
            SeedConcertTypes(modelBuilder);
            SeedLocations(modelBuilder);
            SeedConcerts(modelBuilder);
            SeedTickets(modelBuilder);
            SeedPromoCodes(modelBuilder);
        }

        private static void SeedLocations(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Location>().HasData(
            new Location[]
            {
                new Location { Id = 1, Latitude = 33.3333, Longitude = 44.4444, Name = "Unknown location"},
                new Location { Id = 2, Latitude = 22.2222, Longitude = 55.5555, Name = "Another location"},
            });
        }

        private static void SeedBands(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Band>().HasData(
            new Band[]
            {
                new Band { Id = 1, Name = "Nightwish"},
                new Band { Id = 2, Name = "Dio"},
                new Band { Id = 3, Name = "The Offspring"},
                new Band { Id = 4, Name = "Some classic singer"},
                new Band { Id = 5, Name = "Another singer"},
            });
        }

        private static void SeedConcertTypes(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ConcertType>().HasData(
            new ConcertType[]
            {
                new ConcertType { Id = 1, Name = "Classic music", NameRu = "Классическая музыка"},
                new ConcertType { Id = 2, Name = "Party", NameRu = "Вечеринка"},
                new ConcertType { Id = 3, Name = "Open Air", NameRu = "Опенэйр"},
            });
        }

        private static void SeedConcerts(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Concert>().HasData(
            new Concert[]
            {
                new Concert { Id = 1, BandId = 1, ConcertTypeId = 1, LocationId = 1, Date = DateTime.Now.AddMonths(1) },
                new Concert { Id = 2, BandId = 1, ConcertTypeId = 1, LocationId = 2, Date = DateTime.Now.AddMonths(2) },
                new Concert { Id = 3, BandId = 2, ConcertTypeId = 2, LocationId = 2, Date = DateTime.Now.AddMonths(1) },
                new Concert { Id = 4, BandId = 3, ConcertTypeId = 3, LocationId = 1, Date = DateTime.Now.AddMonths(3) },
            });
        }

        private static void SeedTickets(ModelBuilder modelBuilder)
        {
            int id = 1;
            modelBuilder.Entity<Ticket>().HasData(
            new Ticket[]
            {
                new Ticket { Id = id++, ConcertId = 1, CustomerInfo = " - ", Price = 5, IsReserved = false },
                new Ticket { Id = id++, ConcertId = 1, CustomerInfo = " - ", Price = 5, IsReserved = false },
                new Ticket { Id = id++, ConcertId = 1, CustomerInfo = " - ", Price = 5, IsReserved = false },
                new Ticket { Id = id++, ConcertId = 2, CustomerInfo = " - ", Price = 5, IsReserved = false },
                new Ticket { Id = id++, ConcertId = 2, CustomerInfo = " - ", Price = 5, IsReserved = false },
                new Ticket { Id = id++, ConcertId = 2, CustomerInfo = " - ", Price = 5, IsReserved = false },
                new Ticket { Id = id++, ConcertId = 3, CustomerInfo = " - ", Price = 5, IsReserved = false },
                new Ticket { Id = id++, ConcertId = 3, CustomerInfo = " - ", Price = 5, IsReserved = false },
                new Ticket { Id = id++, ConcertId = 3, CustomerInfo = " - ", Price = 5, IsReserved = false },
                new Ticket { Id = id++, ConcertId = 4, CustomerInfo = " - ", Price = 5, IsReserved = false },
                new Ticket { Id = id++, ConcertId = 4, CustomerInfo = " - ", Price = 5, IsReserved = false },
                new Ticket { Id = id++, ConcertId = 4, CustomerInfo = " - ", Price = 5, IsReserved = false },
            });
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

    }
}
