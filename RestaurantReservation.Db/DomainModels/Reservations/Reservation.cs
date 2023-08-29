using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantReservation.Db.DomainModels.Restaurants;
using RestaurantReservation.Db.DomainModels.Customers;
using RestaurantReservation.Db.DomainModels.Tables;
using RestaurantReservation.Db.DomainModels.Orders;

namespace RestaurantReservation.Db.DomainModels.Reservations
{
    public class Reservation : IReservation
    {
        public int ReservationId { get; set; }
        public Customer Customer { get; set; }
        public Restaurant Restaurant { get; set; }
        public Table Table { get; set; }
        public List<Order> Orders { get; set; } = new List<Order>();
        public DateTime ReservationDate { get; set; }
        public PartySize PartySize { get; set; }

        public static void ConfigureEntity(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Reservation>()
                .HasOne(r => r.Customer)
                .WithMany(c => c.Reservations)
                .HasForeignKey("CustomerId")
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Reservation>()
                .HasOne(r => r.Restaurant)
                .WithMany(r => r.Reservations)
                .HasForeignKey("RestaurantId")
                .OnDelete(DeleteBehavior.ClientCascade);

            modelBuilder.Entity<Reservation>()
                .HasOne(r => r.Table)
                .WithMany(t => t.Reservations)
                .HasForeignKey("TableId")
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Reservation>()
                .HasMany(r => r.Orders)
                .WithOne(o => o.Reservation)
                .HasForeignKey("ReservationId")
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
