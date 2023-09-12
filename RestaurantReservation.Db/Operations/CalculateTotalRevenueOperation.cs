using RestaurantReservation.Db.DomainModels.Restaurants;

namespace RestaurantReservation.Db.Operations
{
    public class CalculateTotalRevenueOperation : IOperation
    {

        private readonly RestaurantService _restaurantService;

        public CalculateTotalRevenueOperation()
        {
            _restaurantService = Factory.CreateRestaurantService(Factory.CreateRestaurantRepository());
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
