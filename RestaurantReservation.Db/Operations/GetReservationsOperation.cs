using RestaurantReservation.Db.DomainModels.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReservation.Db.Operations
{
    public class GetReservationsOperation : IOperation
    {

        private readonly CustomerService _customerService;

        public GetReservationsOperation()
        {
            _customerService = Factory.CreateCustomerService();
        }

        public void Execute() 
        {
            ConsolePrinter.AskForCustomerId();
            var id = Console.ReadLine();

            var validId = InputValidation.ValidateId(id);
            if (!validId)
            {
                ConsolePrinter.InvalidId();
                return;
            }

            var idParsed = int.Parse(id);

            var result = _customerService.GetReservationsById(idParsed);

            if (!result.Any())
            {
                ConsolePrinter.NotFound();
                return;
            }

            ConsolePrinter.Print(result);
        }
    }
}
