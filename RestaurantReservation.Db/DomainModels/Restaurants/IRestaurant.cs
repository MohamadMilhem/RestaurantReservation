using RestaurantReservation.Db.DomainModels.Employees;
using RestaurantReservation.Db.DomainModels.MenuItems;
using RestaurantReservation.Db.DomainModels.Reservations;
using RestaurantReservation.Db.DomainModels.Tables;

namespace RestaurantReservation.Db.DomainModels.Restaurants
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