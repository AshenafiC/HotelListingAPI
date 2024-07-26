using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure.Internal;

namespace HotelListingAPI.Data
{
    public class HotelListingDbContext : DbContext
  {
        public HotelListingDbContext(DbContextOptions options) :base(options) 
        {
            
        }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Hotel> Hotels { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasData(
                new Country
                {
                    Id = 1,
                    Name = "Ethiopia",
                    ShortName = "ET"
                },
                new Country
                {
                    Id = 2,
                    Name = "Kenya",
                    ShortName = "KN"
                },
                new Country
                {
                    Id = 3,
                    Name = "Rwanda",
                    ShortName = "RW"
                }
                );

            modelBuilder.Entity<Hotel>().HasData(
                new Hotel
                { 
                    Id = 1, 
                    Name = "Ilili",
                    Address = "Addis Ababa Kasanchis",
                    Rating = 5,
                    CountryId = 1
                },
                 new Hotel
                 {
                     Id = 2,
                     Name = "Radisan Blue",
                     Address = "Nairobi",
                     Rating = 5,
                     CountryId = 2
                 },
                  new Hotel
                  {
                      Id = 3,
                      Name = "Hilton",
                      Address = "Kigali",
                      Rating = 5,
                      CountryId = 3
                  },
                   new Hotel
                   {
                       Id = 4,
                       Name = "Hilton",
                       Address = "Addis Ababa Kasanchis",
                       Rating = 5,
                       CountryId = 1
                   }
                );
        }
    }
}
