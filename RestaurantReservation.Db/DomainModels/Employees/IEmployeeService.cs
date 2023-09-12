namespace RestaurantReservation.Db.DomainModels.Employees
{
    public interface IEmployeeService
    {
        decimal AverageOrderAmountById(int id);
        IEnumerable<Employee> GetManagers();
    }
}