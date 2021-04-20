using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Smartphone.Data.Models;

namespace Smartphone.Data
{
    public class SmartphoneDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Telephone> Telephones { get; set; }
        public DbSet<Make> Makes { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<Charachteristic> Charachteristics { get; set; }

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

            builder.Entity<Telephone>()
                .HasOne(e => e.User)
                .WithMany(e => e.Telephones)
                .HasForeignKey(e => e.UserId);
        }
    }
}
