namespace RestaurantReservation.Db.DomainModels.Employees
{
    public interface IEmployeeRepository
    {
        int Create(Employee employee);
        int Delete(Employee employee);
        IEnumerable<Employee> GetAllEmployeesWithTitle(string title);
        Employee GetWithOrders(int id);
        int Update(Employee employee);
    }
}