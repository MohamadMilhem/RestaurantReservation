using RestaurantReservation.Db.DomainModels.Employees;
using RestaurantReservation.Db.DomainModels.OrderItems;
using RestaurantReservation.Db.DomainModels.Reservations;

namespace RestaurantReservation.Db.DomainModels.Orders
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