using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantReservation.Db.DataModels.Restaurants;
using RestaurantReservation.Db.DataModels.Customers;
using RestaurantReservation.Db.DataModels.Tables;


namespace RestaurantReservation.Db.DataModels.Reservations
{
    public class Reservation : IReservation
    {
        public int ReservationId { get; set; }
        public Customer Customer { get; set; }
        public Restaurant Restaurant { get; set; }
        public Table Table { get; set; }
        public DateTime ReservationDate { get; set; }
        public PartySize PartySize { get; set; }

        public static void ConfigureEntity(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Reservation>()
                .HasOne<Customer>(r => r.Customer)
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
        }
    }
}
