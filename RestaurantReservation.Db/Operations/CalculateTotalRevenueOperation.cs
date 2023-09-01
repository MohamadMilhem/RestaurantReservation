using RestaurantReservation.Db.DomainModels.Restaurants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReservation.Db.Operations
{
    public class CalculateTotalRevenueOperation : IOperation
    {

        private readonly RestaurantService _restaurantService;

        public CalculateTotalRevenueOperation()
        {
            _restaurantService = Factory.CreateRestaurantService();
        }

        public void Execute()
        {
            ConsolePrinter.AskForRestaurantId();
            var id = Console.ReadLine();

            var validId = InputValidation.ValidateId(id);
            if (!validId)
            {
                ConsolePrinter.InvalidId();
                return;
            }

            var idParsed = int.Parse(id);

            var result = _restaurantService.GetTotalRevenue(idParsed);
            if (result == 0)
            {
                ConsolePrinter.NotFound();
                return;
            }

            ConsolePrinter.Print(result);
        }
    }
}
