using RestaurantReservation.Db.DataModels.Orders;
using RestaurantReservation.Db.DataModels.Restaurants;

namespace RestaurantReservation.Db.DataModels.Employees
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