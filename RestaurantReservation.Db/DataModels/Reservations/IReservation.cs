using RestaurantReservation.Db.DataModels.Customers;
using RestaurantReservation.Db.DataModels.Restaurants;
using RestaurantReservation.Db.DataModels.Tables;

namespace RestaurantReservation.Db.DataModels.Reservations
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