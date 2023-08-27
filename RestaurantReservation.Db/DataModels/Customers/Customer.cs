using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantReservation.Db.DataModels.Reservations;

namespace RestaurantReservation.Db.DataModels.Customers
{
    public class Customer : ICustomer
    {

        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public List<Reservation> Reservations { get; set; } = new List<Reservation>();

        public static void ConfigureEntity(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                .HasMany(c => c.Reservations)
                .WithOne(r => r.Customer)
                .HasForeignKey("CustomerId")
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
