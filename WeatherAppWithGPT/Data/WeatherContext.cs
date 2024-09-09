using Microsoft.EntityFrameworkCore;
using WeatherAppWithGPT.Models;

namespace WeatherAppWithGPT.Data
{
    public class WeatherContext : DbContext
    {
        public WeatherContext(DbContextOptions<WeatherContext> options) : base(options) { }

        public DbSet<Location> Locations { get; set; }
        public DbSet<Condition> Conditions { get; set; }
        public DbSet<Current> Currents { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure relationships
            modelBuilder.Entity<Current>()
                .HasOne(c => c.Location)
                .WithOne(l => l.Current)
                .HasForeignKey<Current>(c => c.LocationId);

            modelBuilder.Entity<Current>()
                .HasOne(c => c.Condition)
                .WithMany()
                .HasForeignKey(c => c.ConditionId);
        }
    }
}
