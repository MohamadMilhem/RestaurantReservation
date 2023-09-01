﻿using RestaurantReservation.Db.DomainModels.Customers;
using RestaurantReservation.Db.DomainModels.Employees;
using RestaurantReservation.Db.DomainModels.MenuItems;
using RestaurantReservation.Db.DomainModels.Orders;
using RestaurantReservation.Db.DomainModels.Reservations;
using RestaurantReservation.Db.ViewsModels.DetailedEmpolyees;
using RestaurantReservation.Db.ViewsModels.DetailedReservations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReservation.Db
{
    public class ConsolePrinter
    {
        public static void DisplayMenu()
        {
            Console.WriteLine("Please choose one of the following options:");
            Console.WriteLine("1. List all employees who hold the position of \"Manager\"");
            Console.WriteLine("2. Get a list of reservations made by a particular customer.");
            Console.WriteLine("3. List the orders placed on a specific reservation along with the associated menu items.");
            Console.WriteLine("4. Calculate the total revenue generated by a specific restaurant.");
            Console.WriteLine("5. Find the menu items ordered in a specific reservation.");
            Console.WriteLine("6. Calculate the average order amount for a specific employee.");
            Console.WriteLine("7. Find all customers who have made reservations with a party size greater than a certain value.");
            Console.WriteLine("8. List all the reservations with their associated customer and restaurant information.");
            Console.WriteLine("9. Retrieve employees with their respective restaurant details.");
            Console.WriteLine("10. Exit.");
        }

        public static void InvalidOption()
        {
            Console.WriteLine("Invalid Option.");
        }

        public static void AskForCustomerId()
        {
            Console.WriteLine("Please Enter the Customer ID:");
        }

        public static void AskForEmployeeId()
        {
            Console.WriteLine("Please Enter the Employee ID:");
        }

        public static void AskForPartySize()
        {
            Console.WriteLine("Please Enter the Party Size (0,1,2) for (small, meduim, large) respectively");
        }

        public static void AskForReservationId()
        {
            Console.WriteLine("Please Enter the Reservation ID:");
        }

        public static void AskForRestaurantId()
        {
            Console.WriteLine("Please Enter the Restaurant ID:");
        }

        public static void InvalidId()
        {
            Console.WriteLine("Sorry, the Id you entered is Invalid.");
        }

        public static void NotFound()
        {
            Console.WriteLine("Not Found 404.");
        }

        public static void Print(decimal result)
        {
            Console.WriteLine($"{result}$");
        }

        public static void Print(IEnumerable<Customer> result)
        {
            Console.WriteLine($"Found {result.Count()} Recordes.");
            foreach (var customer in result)
            {
                Console.WriteLine($"Customer ID: {customer.CustomerId}      Customer Name: {customer.FirstName} " +
                    $"{customer.LastName}       Customer Phone Number: {customer.PhoneNumber}       Customer Email: {customer.Email}");
            }
        }

        public static void Print(DetailedEmployee result)
        {
            Console.WriteLine("Result Found.");
            Console.WriteLine($"Employee ID: {result.EmployeeId}        Employee Name: {result.FirstName} {result.LastName}         Position: {result.Position}" +
                $"      Restaurant Name: {result.RestaurantName}      Restaurant Address:{result.Address}         Working Hours: {result.OpenHour}-{result.CloseHour}");
        }

        public static void Print(DetailedReservation result)
        {
            Console.WriteLine("Result Found.");
            Console.WriteLine($"Reservation ID: {result.ReservationId}      Customer Name: {result.FirstName} {result.LastName}         Date: {result.ReservationDate}" +
                $"      Restaurant Name: {result.RestaurantName}      Restaurant Address:{result.Address}      Working Hours: {result.OpenHour}-{result.CloseHour}");
        }

        public static void Print(IEnumerable<MenuItem> result)
        {
            Console.WriteLine($"Found {result.Count()} Recordes.");
            foreach (var item in result)
            {
                Console.WriteLine($"Item Name: {item.Name}      Item Price: {item.Price}        Item Description: {item.Description}");
            }
        }

        public static void Print(IEnumerable<Order> result)
        {
            Console.WriteLine($"Found {result.Count()} Recordes.");
            foreach (var order in result)
            {
                Console.WriteLine($"Order ID: {order.OrderId}        Order Date: {order.OrderDate}");
                foreach(var item in order.Items)
                {
                    Console.WriteLine($"Item Name: {item.MenuItem.Name}      Item Price: {item.MenuItem.Price}       Item Description: {item.MenuItem.Description}");
                }
            }
        }

        public static void Print(IEnumerable<Reservation> result)
        {
            Console.WriteLine($"Found {result.Count()} Recordes.");
            foreach (var reservation in result)
            {
                Console.WriteLine($"Reservation ID: {reservation.ReservationId}         Reservation Date: {reservation.ReservationDate}         Party Size: {reservation.PartySize}");
            }
        }

        public static void Print(IEnumerable<Employee> result)
        {
            Console.WriteLine($"Found {result.Count()} Recordes.");
            foreach (var employee in result)
            {
                Console.WriteLine($"Employee ID: {employee.EmployeeId}      Employee Name: {employee.FirstName} {employee.LastName}         Position: {employee.Position}");
            }
        }
    }
}
