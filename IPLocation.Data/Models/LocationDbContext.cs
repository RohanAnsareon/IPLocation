using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace IPLocation.Data.Models {
   public class LocationDbContext : DbContext {
      public LocationDbContext(DbContextOptions<LocationDbContext> options) : base(options) { }

      public DbSet<Location> Locations { get; set; }

      protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
         // Configure DB
         base.OnConfiguring(optionsBuilder);
      }

      protected override void OnModelCreating(ModelBuilder modelBuilder) {
         Database.EnsureCreated();
         base.OnModelCreating(modelBuilder);
      }
   }
}
