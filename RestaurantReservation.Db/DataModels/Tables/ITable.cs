using RestaurantReservation.Db.DataModels.Reservations;
using RestaurantReservation.Db.DataModels.Restaurants;

namespace RestaurantReservation.Db.DataModels.Tables
{
    public interface ITable
    {
        int Capacity { get; set; }
        List<Reservation> Reservations { get; set; }
        Restaurant Restaurant { get; set; }
        int TableId { get; set; }
    }
}