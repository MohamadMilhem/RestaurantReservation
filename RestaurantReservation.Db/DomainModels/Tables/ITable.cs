using RestaurantReservation.Db.DomainModels.Reservations;
using RestaurantReservation.Db.DomainModels.Restaurants;

namespace RestaurantReservation.Db.DomainModels.Tables
{
    public interface ITable
    {
        int Capacity { get; set; }
        List<Reservation> Reservations { get; set; }
        Restaurant Restaurant { get; set; }
        int TableId { get; set; }
    }
}