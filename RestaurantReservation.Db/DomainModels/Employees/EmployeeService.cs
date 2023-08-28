using RestaurantReservation.Db.DomainModels.Customers;
using RestaurantReservation.Db.DomainModels.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReservation.Db.DomainModels.Employees
{
    public class EmployeeService
    {

        private readonly EmployeeRepository _employeeRepository;
        public EmployeeService(EmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public IEnumerable<Employee> GetManagers()
        {
            return _employeeRepository.GetAllEmployeesWithTitle("Manager");
        }

        public decimal AverageOrderAmountById(int id)
        {
            Employee employee = _employeeRepository.GetWithOrders(id);
            if (employee == null)
            {
                return 0;
            }
            return employee.Orders.Average(order => order.TotalAmount);
        }

    }
}
