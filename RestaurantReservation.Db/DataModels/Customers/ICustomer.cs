using RestaurantReservation.Db.DataModels.Reservations;

namespace RestaurantReservation.Db.DataModels.Customers
{
    public interface ICustomer
    {
        int CustomerId { get; set; }
        string? Email { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string? PhoneNumber { get; set; }
        List<Reservation> Reservations { get; set; }
    }
}