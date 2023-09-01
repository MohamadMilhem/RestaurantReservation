using RestaurantReservation.Db.DomainModels.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReservation.Db.Operations
{
    public class GetAllCustomersWithPartySizeGreaterOperation : IOperation
    {

        private readonly CustomerService _customerService;
        public GetAllCustomersWithPartySizeGreaterOperation()
        {
            _customerService = Factory.CreateCustomerService();
        }

        public void Execute()
        {
            ConsolePrinter.AskForPartySize();
            var size = Console.ReadLine();

            var isValid = InputValidation.ValidatePartySize(size);
            if (!isValid)
            {
                ConsolePrinter.InvalidOption();
                return;
            }

            var sizeParsed = Converter.FromNumericStringToPartySize(size);

            var result = _customerService.GetCustomersWithPartySizeGreaterThan(sizeParsed);
            if (!result.Any())
            {
                ConsolePrinter.NotFound();
                return;
            }

            ConsolePrinter.Print(result);
        }
    }
}
