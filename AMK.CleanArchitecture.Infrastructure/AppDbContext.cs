using AMK.CleanArchitecture.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace AMK.CleanArchitecture.Infrastructure;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Order> Orders { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Order>().HasKey(o => o.Id);
    }
}
