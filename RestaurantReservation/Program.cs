
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
using RestaurantReservation.Db.DomainModels.Restaurants;
using RestaurantReservation.Db.ViewsModels;
using System.Reflection.Metadata.Ecma335;
using RestaurantReservation.Db.Operations;

namespace RestaurantReservation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var operations = AddOperations();
            var program = new Driver(operations);

            while (program.ProcessOption()) ;
            
        }

        static List<IOperation> AddOperations()
        {
            var operations = new List<IOperation>();

            operations.Add(new ListManagersOperation());
            operations.Add(new GetReservationsOperation());
            operations.Add(new GetOrdersWithMenuItemsOperation());
            operations.Add(new CalculateTotalRevenueOperation());
            operations.Add(new GetOrderItemsOperation());
            operations.Add(new GetAverageAmountOperation());
            operations.Add(new GetAllCustomersWithPartySizeGreaterOperation());
            operations.Add(new GetDetailedReservationOperation());
            operations.Add(new GetDetailedEmployeeInfoOperation());

            return operations;
        }
    }
   
    
}
