using RestaurantReservation.Db.DomainModels.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
