using Microsoft.EntityFrameworkCore;
using ServisProgrami.Core.Models;
using ServisProgrami.Data.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServisProgrami.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }

        public DbSet<Customer> Customers  { get; set; }

        public DbSet<Vehicle> Vehicles { get; set; }

        public DbSet<Iscilik> ısciliks { get; set; }

        public DbSet<Product> products { get; set; }

        public DbSet<VehicleRegistry> vehicleRegistries  { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CustomerConfiguration());
            modelBuilder.ApplyConfiguration(new IscilikConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new VehicleConfiguration());
            modelBuilder.ApplyConfiguration(new VehicleRegistryConfiguration());
        }
    }
}
