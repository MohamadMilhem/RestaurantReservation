
using Microsoft.IdentityModel.Protocols;
using System.Configuration;
using System;
using System.Linq;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RestaurantReservation.Db;
using RestaurantReservation.Db.DomainModels;
using RestaurantReservation.Db.DomainModels.Customers;
using RestaurantReservation.Db.DomainModels.Reservations;
using System.Security.Cryptography;
using RestaurantReservation.Db.DomainModels.Employees;
using RestaurantReservation.Db.DomainModels.Orders;

namespace RestaurantReservation
{
    public class Program
    {
        static void Main(string[] args)
        {

            var repo = new EmployeeRepository();
            var service = new EmployeeService(repo);

            var manager = service.AverageOrderAmountById(3);
            

            

            


        }
    }
}
