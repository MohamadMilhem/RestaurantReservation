using RestaurantReservation.Db.DomainModels.MenuItems;
using RestaurantReservation.Db.DomainModels.Orders;

namespace RestaurantReservation.Db.DomainModels.OrderItems
{
    public interface IOrderItem
    {
        MenuItem MenuItem { get; set; }
        Order Order { get; set; }
        int OrderItemId { get; set; }
        int Quantity { get; set; }
    }
}