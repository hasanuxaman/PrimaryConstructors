using Microsoft.EntityFrameworkCore;

namespace PrimaryConstructors.Models
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
     : DbContext(options)
    {

        public DbSet<Product> Products => Set<Product>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Name).IsRequired().HasMaxLength(100);
                entity.Property(e => e.Description).HasMaxLength(500);
                entity.Property(e => e.Price).HasColumnType("decimal(18,2)");
            });
        }
    }
}
