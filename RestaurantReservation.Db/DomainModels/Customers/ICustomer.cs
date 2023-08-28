using RestaurantReservation.Db.DomainModels.Reservations;

namespace RestaurantReservation.Db.DomainModels.Customers
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