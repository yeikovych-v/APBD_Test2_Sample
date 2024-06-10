using Microsoft.EntityFrameworkCore;
using s28201_Test2.Models;
using s28201_Test2.Service;

namespace s28201_Test2.Context;

public class ApiContext : DbContext
{

    public virtual DbSet<AppUser> Users { get; set; }

    public ApiContext()
    {
    }

    public ApiContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost;Database=Test2;User=sa;Password=fY0urP@sswor_Policy;TrustServerCertificate=True;");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AppUser>(e =>
        {
            e.HasKey(u => u.IdUser);
            e.Property(u => u.Username).IsRequired().HasMaxLength(100);
        });
    }
}