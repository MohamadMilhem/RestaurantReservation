using RestaurantReservation.Db.DomainModels.Employees;

namespace RestaurantReservation.Db.Operations
{
    public class GetAverageAmountOperation : IOperation
    {
        private readonly EmployeeService _employeeService;

        public GetAverageAmountOperation()
        {
            _employeeService = Factory.CreateEmployeeService();
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

            var result = _employeeService.AverageOrderAmountById(idParsed);

            if(result == 0)
            {
                ConsolePrinter.NotFound();
                return;
            }

            ConsolePrinter.Print(result);
        }
    }
}
