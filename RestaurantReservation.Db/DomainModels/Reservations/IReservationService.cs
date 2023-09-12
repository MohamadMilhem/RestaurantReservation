using RestaurantReservation.Db.DomainModels.MenuItems;
using RestaurantReservation.Db.DomainModels.Orders;

namespace RestaurantReservation.Db.DomainModels.Reservations
{
    public interface IReservationService
    {
        IEnumerable<Order> GetDetailedOrders(int id);
        IEnumerable<MenuItem> GetMenuItems(int id);
    }
}