using RestaurantReservation.Db;
using RestaurantReservation.Db.DomainModels.Customers;
using RestaurantReservation.Db.DomainModels.Employees;
using RestaurantReservation.Db.DomainModels.MenuItems;
using RestaurantReservation.Db.DomainModels.OrderItems;
using RestaurantReservation.Db.DomainModels.Orders;
using RestaurantReservation.Db.DomainModels.Reservations;
using RestaurantReservation.Db.DomainModels.Restaurants;
using RestaurantReservation.Db.DomainModels.Tables;
using RestaurantReservation.Db.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReservation
{
    public class Driver
    {
        private readonly List<IOperation> _operations;
        public Driver(List<IOperation> operations)
        {
            _operations = operations;
        }


        public bool ProcessOption()
        {
            ConsolePrinter.DisplayMenu();

            var option = Console.ReadLine();

            var isValid = InputValidation.ValidateMenuOption(option);
            if (!isValid)
            {
                ConsolePrinter.InvalidOption();
                return true;
            }

            var choice = Converter.FromNumericStringToMenuChoice(option);

            if (choice.Equals(MenuChoice.Exit))
            {
                return false;
            }

            var operation = GetOperation(choice);

            operation.Execute();
            return true;

        }

        public IOperation GetOperation(MenuChoice choice)
        {
            int index = (int)(choice);
            return _operations.ElementAt(index - 1);
        }




    }
}
