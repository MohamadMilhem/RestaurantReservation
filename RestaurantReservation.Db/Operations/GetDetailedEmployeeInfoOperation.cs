using RestaurantReservation.Db.ViewsModels.DetailedEmpolyees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReservation.Db.Operations
{
    public class GetDetailedEmployeeInfoOperation : IOperation
    {

        private readonly DetailedEmployeeService _detailedEmployeeService;
        public GetDetailedEmployeeInfoOperation()
        {
            _detailedEmployeeService = Factory.CreateDetailedEmployeeService();
        }

        public void Execute()
        {
            ConsolePrinter.AskForEmployeeId();
            var id = Console.ReadLine();

            var isValid = InputValidation.ValidateId(id);
            if (!isValid)
            {
                ConsolePrinter.InvalidId();
                return;
            }

            var idParsed = int.Parse(id);

            var result = _detailedEmployeeService.GetDetailedEmployee(idParsed);

            if (result == null)
            {
                ConsolePrinter.NotFound();
                return;
            }

            ConsolePrinter.Print(result);
        }

    }
}
