using RestaurantReservation.Db.DataModels.Employees;
using RestaurantReservation.Db.DataModels.OrderItems;
using RestaurantReservation.Db.DataModels.Reservations;

namespace RestaurantReservation.Db.DataModels.Orders
{
    public interface IOrder
    {
        Employee Employee { get; set; }
        List<OrderItem> Items { get; set; }
        DateTime OrderDate { get; set; }
        int OrderId { get; set; }
        Reservation Reservation { get; set; }
        decimal TotalAmount { get; set; }
    }
}