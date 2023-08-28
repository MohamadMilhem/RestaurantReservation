
using Microsoft.IdentityModel.Protocols;
using System.Configuration;
using System;
using System.Linq;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RestaurantReservation.Db;
using RestaurantReservation.Db.DataModels;
using RestaurantReservation.Db.DataModels.Customers;
using RestaurantReservation.Db.DataModels.Reservations;
using System.Security.Cryptography;

namespace RestaurantReservation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var repo = new CustomerRepository();
            var service = new CustomerService(repo);

            //repo.GetCustomer(3);

            var context = new RestaurantReservationDbContext();

            var customer = context.Customers
            .Include(c => c.Reservations) // Include the reservations
            .SingleOrDefault(c => c.CustomerId == 3);







        }
    }
}
