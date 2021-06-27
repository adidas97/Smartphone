using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Smartphone.Data.Models;

namespace Smartphone.Data
{
    public class SmartphoneDbContext : IdentityDbContext<User>
    {
        public DbSet<Advertisement> Advertisements { get; set; }
        public DbSet<Make> Makes { get; set; }
        public DbSet<Model> Models { get; set; }

        public SmartphoneDbContext(DbContextOptions<SmartphoneDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Model>()
                .HasOne(e => e.Make)
                .WithMany(e => e.Models)
                .HasForeignKey(e => e.MakeId);

            builder.Entity<Advertisement>()
                .HasOne(e => e.User)
                .WithMany(e => e.Advertisements)
                .HasForeignKey(e => e.UserId);
        }
    }
}
