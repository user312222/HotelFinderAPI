using HotelFinder.Entities;
using Microsoft.EntityFrameworkCore;

namespace HotelFinder.DataAccess
{
    internal class HotelDbContext : DbContext
    {
        override protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=W;Database=HotelDb;Integrated Security=True;TrustServerCertificate=True;");

        }


        public DbSet<Hotel> Hotels { get; set; }

    }
}
