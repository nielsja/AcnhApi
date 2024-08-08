using AcnhApi.DataAccessors.Entities;
using Microsoft.EntityFrameworkCore;

namespace AcnhApi.DataAccessors.AcnhDbContext
{
    public class AcnhDbContext : DbContext
    {
        /**
         * To add a migration - terminal command: `dotnet ef migrations add <migration_name>`
         * Then to apply migration - run command: `dotnet ef database update`
         * 
         */
        public AcnhDbContext(DbContextOptions<AcnhDbContext> options)
            : base(options)
        {
        }

        public DbSet<Fish> Fishes { get; set; } = default!;
        public DbSet<User> Users { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Fish>().ToTable("Fishes").HasKey(c => new { c.FishId });
            modelBuilder.Entity<User>().ToTable("Users").HasKey(c => new { c.UserId });

            base.OnModelCreating(modelBuilder);
        }
    }
}

