using Microsoft.EntityFrameworkCore;
using Travel_Logger_API_api_tvrdna.Models;

namespace TravelLogger;

public class TravelLoggerDbContext : DbContext
{

    public DbSet<City> Cities { get; set; }
    public DbSet<Log> Logs { get; set; }
    public DbSet<Recommendation> Recommendations { get; set; }
    public DbSet<Upvote> Upvotes { get; set; }
    public DbSet<User> Users { get; set; }

    public TravelLoggerDbContext(DbContextOptions<TravelLoggerDbContext> context) : base(context)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Seed data here

    }
}