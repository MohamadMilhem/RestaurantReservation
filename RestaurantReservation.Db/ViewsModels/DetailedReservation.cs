using Microsoft.EntityFrameworkCore;
using RestaurantReservation.Db.DomainModels.Customers;
using System;
using System.Collections.Generic;
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
        public string CustomerEmail;
        public string CustomerPhoneNumber;
        public int RestaurantId;
        public string RestaurantName;
        public string Address;
        public string RestaurantPhoneNumber;
        public TimeOnly OpenHour;
        public TimeOnly CloseHour;

        public static void ConfigureEntity(ModelBuilder modelBuilder)
        {
            modelBuilder
               .Entity<DetailedReservation>()
               .ToView("ReservationDetails")
               .HasKey(reservation => reservation.ReservationId);
        }
    }
}
