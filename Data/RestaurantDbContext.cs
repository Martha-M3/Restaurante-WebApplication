using Microsoft.EntityFrameworkCore;
using Restaurante_WebApplication.Models; // Adjust namespace as needed

namespace Restaurante_WebApplication.Data
{
    public class RestaurantDbContext : DbContext
    {
        public RestaurantDbContext(DbContextOptions<RestaurantDbContext> options)
            : base(options)
        {
        }

        // Add DbSets for your tables here
        // We'll add these after scaffolding the database
        //public DbSet<User> Users { get; set; }
        // ... other DbSets will be added automatically when you scaffold
    }
}