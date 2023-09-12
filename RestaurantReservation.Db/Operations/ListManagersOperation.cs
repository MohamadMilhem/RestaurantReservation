using RestaurantReservation.Db.DomainModels.Employees;

namespace RestaurantReservation.Db.Operations
{
    public class ListManagersOperation : IOperation
    {

        private readonly EmployeeService _employeeService;

        public ListManagersOperation()
        {
            _employeeService = Factory.CreateEmployeeService();
        }

        public void Execute() 
        {
            var result = _employeeService.GetManagers();

            if (!result.Any())
            {
                ConsolePrinter.NotFound();
                return;
            }

            ConsolePrinter.Print(result);
        }
    }
}
