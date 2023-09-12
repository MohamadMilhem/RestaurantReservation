namespace RestaurantReservation.Db.DomainModels.Employees
{
    public class EmployeeService : IEmployeeService
    {

        private readonly IEmployeeRepository _employeeRepository;
        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public IEnumerable<Employee> GetManagers()
        {
            return _employeeRepository.GetAllEmployeesWithTitle("Manager");
        }

        public decimal AverageOrderAmountById(int id)
        {
            var employee = _employeeRepository.GetWithOrders(id);
            if (employee == null || !employee.Orders.Any())
            {
                return 0;
            }
            return employee.Orders.Average(order => order.TotalAmount);
        }
    }
}
