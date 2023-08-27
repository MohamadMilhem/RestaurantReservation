using RestaurantReservation.Db.DataModels.MenuItems;
using RestaurantReservation.Db.DataModels.Orders;

namespace RestaurantReservation.Db.DataModels.OrderItems
{
    public interface IOrderItem
    {
        MenuItem MenuItem { get; set; }
        Order Order { get; set; }
        int OrderItemId { get; set; }
        int Quantity { get; set; }
    }
}