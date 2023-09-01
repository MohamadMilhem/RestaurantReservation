using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RestaurantReservation.Db.DomainModels.Customers;
using RestaurantReservation.Db.DomainModels.Restaurants;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RestaurantReservation.Db.ViewsModels.DetailedReservations
{
    public class DetailedReservation
    {
        public int ReservationId { get; set; }
        public int TableId { get; set; }
        public DateTime ReservationDate { get; set; }
        public PartySize PartySize { get; set; }
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? CustomerEmail { get; set; }
        public string? CustomerPhoneNumber { get; set; }
        public int RestaurantId { get; set; }
        public string? RestaurantName { get; set; }
        public string? Address { get; set; }
        public string? RestaurantPhoneNumber { get; set; }
        public TimeOnly OpenHour { get; set; }
        public TimeOnly CloseHour { get; set; }

        public static void ConfigureEntity(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DetailedReservation>(entity =>
            {
                entity.HasNoKey();
                entity.ToView("DetailedReservations");
            });
        }
    }
}
