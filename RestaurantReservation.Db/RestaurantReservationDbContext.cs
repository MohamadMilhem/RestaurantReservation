using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Protocols;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System.Reflection.Metadata;
using System.Linq.Expressions;
using System;
using System.Linq;
using System.Reflection;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RestaurantReservation.Db.DomainModels.Customers;
using RestaurantReservation.Db.DomainModels.Employees;
using RestaurantReservation.Db.DomainModels.MenuItems;
using RestaurantReservation.Db.DomainModels.Orders;
using RestaurantReservation.Db.DomainModels.OrderItems;
using RestaurantReservation.Db.DomainModels.Reservations;
using RestaurantReservation.Db.DomainModels.Restaurants;
using RestaurantReservation.Db.DomainModels.Tables;
using RestaurantReservation.Db.ViewsModels;

namespace RestaurantReservation.Db
{
    public class RestaurantReservationDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<MenuItem> MenuItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> Items { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<Table> Tables { get; set; }
        public DbSet<DetailedReservation> DetailedReservations { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
  
            optionsBuilder.UseSqlServer(
                ConfigurationManager.ConnectionStrings["SSMSConnectionString"].ConnectionString
               );

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ValueConverter<TimeOnly, TimeSpan> timeOnlyConverter = TimeOnlyConverter();

            TimeMapper<Restaurant>(modelBuilder, timeOnlyConverter, r => r.OpenHour);
            TimeMapper<Restaurant>(modelBuilder, timeOnlyConverter, r => r.CloseHour);

            TimeMapper<DetailedReservation>(modelBuilder, timeOnlyConverter, dr => dr.OpenHour);
            TimeMapper<DetailedReservation>(modelBuilder, timeOnlyConverter, dr => dr.OpenHour);

            Customer.ConfigureEntity(modelBuilder);
            Restaurant.ConfigureEntity(modelBuilder);
            Employee.ConfigureEntity(modelBuilder);
            MenuItem.ConfigureEntity(modelBuilder);
            Table.ConfigureEntity(modelBuilder);
            Order.ConfigureEntity(modelBuilder);
            OrderItem.ConfigureEntity(modelBuilder);
            Reservation.ConfigureEntity(modelBuilder);
            DetailedReservation.ConfigureEntity(modelBuilder);

            SeedData(modelBuilder);
        }

        private static void SeedData(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Customer>().HasData(
                new  { CustomerId = 1, FirstName = "John", LastName = "Doe" },
                new  { CustomerId = 2, FirstName = "Jane", LastName = "Smith" },
                new  { CustomerId = 3, FirstName = "Michael", LastName = "Johnson" },
                new  { CustomerId = 4, FirstName = "Emily", LastName = "Williams" },
                new  { CustomerId = 5, FirstName = "David", LastName = "Brown" }
                );

            modelBuilder.Entity<Restaurant>().HasData(
                new  { RestaurantId = 1, Name = "Restaurant A", Address = "123 Main St", OpenHour = new TimeOnly(8, 0), CloseHour = new TimeOnly(22, 0) },
                new  { RestaurantId = 2, Name = "Restaurant B", Address = "456 Elm St", OpenHour = new TimeOnly(9, 0), CloseHour = new TimeOnly(23, 0) },
                new  { RestaurantId = 3, Name = "Restaurant C", Address = "789 Oak St", OpenHour = new TimeOnly(7, 30), CloseHour = new TimeOnly(21, 30) },
                new  { RestaurantId = 4, Name = "Restaurant D", Address = "555 Maple St", OpenHour = new TimeOnly(8, 0), CloseHour = new TimeOnly(21, 0) },
                new  { RestaurantId = 5, Name = "Restaurant E", Address = "222 Pine St", OpenHour = new TimeOnly(10, 0), CloseHour = new TimeOnly(23, 0) }
                );

            modelBuilder.Entity<Employee>().HasData(
                new  { EmployeeId = 1, FirstName = "Alice", LastName = "Johnson", Position = "Manager", RestaurantId = 1 },
                new  { EmployeeId = 2, FirstName = "Bob", LastName = "Smith", Position = "Chef", RestaurantId = 3 },
                new  { EmployeeId = 3, FirstName = "Sarah", LastName = "Miller", Position = "Server", RestaurantId = 2 },
                new  { EmployeeId = 4, FirstName = "James", LastName = "Davis", Position = "Bartender", RestaurantId = 4 },
                new  { EmployeeId = 5, FirstName = "Laura", LastName = "Martinez", Position = "Manager", RestaurantId =4 }
                );

            modelBuilder.Entity<MenuItem>().HasData(
                new  { MenuItemId = 1, Name = "Burger", Description = "Delicious burger", Price = 10.99m, RestaurantId = 1},
                new  { MenuItemId = 2, Name = "Pizza", Description = "Tasty pizza", Price = 12.99m, RestaurantId = 2 },
                new  { MenuItemId = 3, Name = "Salad", Description = "Fresh salad", Price = 7.99m, RestaurantId = 1 },
                new  { MenuItemId = 4, Name = "Steak", Description = "Juicy steak", Price = 18.99m, RestaurantId = 3 },
                new  { MenuItemId = 5, Name = "Pasta", Description = "Homemade pasta", Price = 9.99m, RestaurantId = 5 }
                );

            modelBuilder.Entity<Table>().HasData(
                new  { TableId = 1, Capacity = 4, RestaurantId = 1 },
                new  { TableId = 2, Capacity = 6, RestaurantId = 2 },
                new  { TableId = 3, Capacity = 2, RestaurantId = 2 },
                new  { TableId = 4, Capacity = 8, RestaurantId = 3 },
                new  { TableId = 5, Capacity = 4, RestaurantId = 3 }
                );

            modelBuilder.Entity<Order>().HasData(
                new  { OrderId = 1, OrderDate = new DateTime(2023, 8, 29), TotalAmount = 23.98m, ReservationId = 1, EmployeeId = 4 },
                new  { OrderId = 2, OrderDate = new DateTime(2023, 8, 28), TotalAmount = 45.75m, ReservationId = 2, EmployeeId = 3 },
                new  { OrderId = 3, OrderDate = new DateTime(2023, 8, 27), TotalAmount = 32.50m, ReservationId = 3, EmployeeId = 3 },
                new  { OrderId = 4, OrderDate = new DateTime(2023, 8, 25), TotalAmount = 15.25m, ReservationId = 4, EmployeeId = 2 },
                new  { OrderId = 5, OrderDate = new DateTime(2023, 8, 26), TotalAmount = 28.90m, ReservationId = 5, EmployeeId = 2 }
                );

            modelBuilder.Entity<OrderItem>().HasData(
                new  { OrderItemId = 1, OrderId = 1, MenuItemId = 1, Quantity = 2 },
                new  { OrderItemId = 2, OrderId = 1, MenuItemId = 2, Quantity = 1 },
                new  { OrderItemId = 3, OrderId = 2, MenuItemId = 3, Quantity = 1 },
                new  { OrderItemId = 4, OrderId = 3, MenuItemId = 4, Quantity = 3 },
                new  { OrderItemId = 5, OrderId = 4, MenuItemId = 5, Quantity = 1 }
                );

            modelBuilder.Entity<Reservation>().HasData(
                new  { ReservationId = 1, ReservationDate = new DateTime(2023, 8, 29), PartySize = PartySize.Small, CustomerId = 3, TableId = 1, RestaurantId = 1 },
                new  { ReservationId = 2, ReservationDate = new DateTime(2023, 8, 28), PartySize = PartySize.Large, CustomerId = 3, TableId = 2, RestaurantId = 2 },
                new  { ReservationId = 3, ReservationDate = new DateTime(2023, 8, 27), PartySize = PartySize.Medium, CustomerId = 4, TableId = 3, RestaurantId = 3},
                new  { ReservationId = 4, ReservationDate = new DateTime(2023, 8, 26), PartySize = PartySize.Medium, CustomerId = 5, TableId = 4, RestaurantId = 4 },
                new  { ReservationId = 5, ReservationDate = new DateTime(2023, 8, 25), PartySize = PartySize.Small, CustomerId = 1, TableId = 5, RestaurantId = 4 }
                );

        }

        public static void TimeMapper<T>(ModelBuilder modelBuilder, ValueConverter<TimeOnly, TimeSpan> timeOnlyConverter, Expression<Func<T, TimeOnly>> propertyExpression) where T : class
        {
            modelBuilder
                .Entity<T>()
                .Property(propertyExpression)
                  .HasConversion(timeOnlyConverter);
        }

        public static ValueConverter<TimeOnly, TimeSpan> TimeOnlyConverter()
        {
            return new ValueConverter<TimeOnly, TimeSpan>(
                    timeOnly => timeOnly.ToTimeSpan(),
                    timeSpan => TimeOnly.FromTimeSpan(timeSpan));
        }


        
    }
}



