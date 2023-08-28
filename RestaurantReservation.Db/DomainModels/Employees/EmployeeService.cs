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

        private readonly IGenericRepository<Employee> _employeeRepository;
        public EmployeeService(IGenericRepository<Employee> employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public IEnumerable<Employee> GetManagers()
        {
            return _employeeRepository.GetAllByWithRelated(emp => emp.Position.Equals("Manager"));
        }

        public decimal AverageOrderAmount(Func<Employee, bool> predicate)
        {
            return _employeeRepository.GetFirstByWithRelated(predicate, emp => emp.Orders).Orders.Average(o => o.TotalAmount);
        }

    }
}
