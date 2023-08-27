using RestaurantReservation.Db.DataModels.Employees;
using RestaurantReservation.Db.DataModels.MenuItems;
using RestaurantReservation.Db.DataModels.Reservations;
using RestaurantReservation.Db.DataModels.Tables;

namespace RestaurantReservation.Db.DataModels.Restaurants
{
    public interface IRestaurant
    {
        string Address { get; set; }
        TimeOnly CloseHour { get; set; }
        List<Employee> Employees { get; set; }
        List<MenuItem> MenuItems { get; set; }
        string Name { get; set; }
        TimeOnly OpenHour { get; set; }
        string? PhoneNumber { get; set; }
        List<Reservation> Reservations { get; set; }
        int RestaurantId { get; set; }
        List<Table> Tables { get; set; }
    }
}