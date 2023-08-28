using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantReservation.Db.DomainModels.Employees;
using RestaurantReservation.Db.DomainModels.MenuItems;
using RestaurantReservation.Db.DomainModels.Reservations;
using RestaurantReservation.Db.DomainModels.Tables;

namespace RestaurantReservation.Db.DomainModels.Restaurants
{
    public class Restaurant : IRestaurant
    {

        public int RestaurantId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string? PhoneNumber { get; set; }
        public List<Table> Tables { get; set; } = new List<Table>();
        public List<Employee> Employees { get; set; } = new List<Employee>();
        public List<Reservation> Reservations { get; set; } = new List<Reservation>();
        public List<MenuItem> MenuItems { get; set; } = new List<MenuItem>();
        public TimeOnly OpenHour { get; set; }
        public TimeOnly CloseHour { get; set; }

        public static void ConfigureEntity(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Restaurant>()
                .HasMany(r => r.Tables)
                .WithOne(t => t.Restaurant)
                .HasForeignKey("RestaurantId")
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Restaurant>()
                .HasMany(r => r.Employees)
                .WithOne(e => e.Restaurant)
                .HasForeignKey("RestaurantId")
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Restaurant>()
                .HasMany(r => r.Reservations)
                .WithOne(res => res.Restaurant)
                .HasForeignKey("RestaurantId")
                .OnDelete(DeleteBehavior.ClientCascade);

            modelBuilder.Entity<Restaurant>()
                .HasMany(r => r.MenuItems)
                .WithOne(mi => mi.Restaurant)
                .HasForeignKey("RestaurantId")
                .OnDelete(DeleteBehavior.ClientCascade);

        }
    }
}
