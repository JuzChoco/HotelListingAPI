using Microsoft.EntityFrameworkCore;

namespace HotelListingAPI.Data
{
    public class HotelListingDbContext : DbContext
    {

        public HotelListingDbContext(DbContextOptions options) : base(options) 
        {
              
        }

        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Country> Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasData(
                new Country
                {
                    Id = 1,
                    Name = "Singapore",
                    ShortName = "SG"
                },
                new Country
                {
                    Id = 2,
                    Name = "Japan",
                    ShortName = "JP"
                },
                new Country
                {
                    Id = 3,
                    Name = "Austria",
                    ShortName = "AT"
                }
                );

            modelBuilder.Entity<Hotel>().HasData(

                new Hotel
                {
                    Id = 1,
                    Name = "Ritz Carlton",
                    Address = "Marina Bay 7, Raffles Ave., 039799",
                    CountryId = 1,
                    Rating = 4.6
                },
                new Hotel
                {
                    Id = 2,
                    Name = "Mandarin Oriental Tokyo",
                    Address = "2 Chome-1-1 Nihonbashimuromachi, Chuo City, Tokyo 103-8328, Japan",
                    CountryId = 2,
                    Rating = 4.5
                },
                new Hotel
                {
                    Id = 3,
                    Name = "DoubleTree by Hilton Vienna Schonbrunn",
                    Address = "Schloßallee 8, 1140 Wien, Austria",
                    CountryId = 3,
                    Rating = 4.2
                }
                );
        }
    }
}
