using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Protocols;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System.Reflection.Metadata;

namespace RestaurantReservation.Db
{
    public class RestaurantReservationDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<MenuItem> MenuItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> Items { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<Table> Tables { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer(
                 "Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = PubDatabase"
               );
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            var timeOnlyConverter = new ValueConverter<TimeOnly, TimeSpan>(
                    timeOnly => timeOnly.ToTimeSpan(),
                    timeSpan => TimeOnly.FromTimeSpan(timeSpan));

            modelBuilder
                .Entity<Restaurant>()
                .Property(r => r.OpenHour)
                  .HasConversion(timeOnlyConverter);

            modelBuilder
                .Entity<Restaurant>()
                .Property(r => r.CloseHour)
                  .HasConversion(timeOnlyConverter);

            modelBuilder.Entity<Reservation>()
                .HasOne(r => r.Table)
                .WithOne()
                .OnDelete(DeleteBehavior.ClientCascade);

            modelBuilder.Entity<Order>()
                .HasOne(o => o.Reservation)
                .WithMany()
                .OnDelete(DeleteBehavior.ClientCascade);
           
            modelBuilder.Entity<OrderItem>()
                .HasOne(oi =>  oi.Order)
                .WithMany()
                .OnDelete(DeleteBehavior.ClientCascade);

        }

    }
}



