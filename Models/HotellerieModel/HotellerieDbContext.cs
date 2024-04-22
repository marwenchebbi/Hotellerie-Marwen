using VotreApplication.Models.HotellerieModel;
using Microsoft.EntityFrameworkCore;

namespace VotreApplication.Models
{
    public class HotellerieDbContext : DbContext
    {
        public HotellerieDbContext(DbContextOptions<HotellerieDbContext> options) : base(options)
        {
        }

        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Appreciation> Appreciations { get; set; }


    }
}
