using RestaurantReservation.Db.DomainModels.Customers;
using RestaurantReservation.Db.DomainModels.Restaurants;
using RestaurantReservation.Db.DomainModels.Tables;

namespace RestaurantReservation.Db.DomainModels.Reservations
{
    public interface IReservation
    {
        Customer Customer { get; set; }
        PartySize PartySize { get; set; }
        DateTime ReservationDate { get; set; }
        int ReservationId { get; set; }
        Restaurant Restaurant { get; set; }
        Table Table { get; set; }
    }
}