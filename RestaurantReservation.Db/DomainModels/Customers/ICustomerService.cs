using RestaurantReservation.Db.DomainModels.Reservations;

namespace RestaurantReservation.Db.DomainModels.Customers
{
    public interface ICustomerService
    {
        IEnumerable<Customer> GetCustomersWithPartySizeGreaterThan(PartySize partySize);
        IEnumerable<Reservation> GetReservationsById(int id);
    }
}