using RestaurantReservation.Db.DomainModels.Orders;
using RestaurantReservation.Db.DomainModels.Restaurants;

namespace RestaurantReservation.Db.DomainModels.Employees
{
    public interface IEmployee
    {
        int EmployeeId { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        List<Order> Orders { get; set; }
        string Position { get; set; }
        Restaurant Restaurant { get; set; }
    }
}