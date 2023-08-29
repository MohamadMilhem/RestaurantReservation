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


namespace RestaurantReservation.Db.ViewsModels
{
    public class DetailedReservation
    {
        public int ReservationId;
        public int TableId;
        public DateTime ReservationDate;
        public PartySize PartySize;
        public int CustomerId;
        public string FirstName;
        public string LastName;
        public string? CustomerEmail;
        public string? CustomerPhoneNumber;
        public int RestaurantId;
        public string? RestaurantName;
        public string? Address;
        public string? RestaurantPhoneNumber;
        public TimeOnly OpenHour;
        public TimeOnly CloseHour;

        public static void ConfigureEntity(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DetailedReservation>(entity =>
            {

                entity.Property(c => c.ReservationId).HasColumnName("ReservationId");
                entity.Property(c => c.TableId).HasColumnName("TableId");
                entity.Property(c => c.ReservationDate).HasColumnName("ReservationDate");
                entity.Property(c => c.PartySize).HasColumnName("PartySize");
                entity.Property(c => c.CustomerId).HasColumnName("CustomerId");
                entity.Property(c => c.FirstName).HasColumnName("FirstName");
                entity.Property(c => c.LastName).HasColumnName("LastName");
                entity.Property(c => c.CustomerEmail).HasColumnName("CustomerEmail");
                entity.Property(c => c.CustomerPhoneNumber).HasColumnName("CustomerPhoneNumber");
                entity.Property(c => c.RestaurantId).HasColumnName("RestaurantId");
                entity.Property(c => c.RestaurantName).HasColumnName("RestaurantName");
                entity.Property(c => c.Address).HasColumnName("Address");
                entity.Property(c => c.RestaurantPhoneNumber).HasColumnName("RestaurantPhoneNumber");
                entity.HasNoKey();
                entity.ToView("DetailedReservations");
            });
        }
    }
}
