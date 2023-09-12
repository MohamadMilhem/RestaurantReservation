namespace RestaurantReservation.Db.DomainModels.OrderItems
{
    public interface IOrderItemRepository
    {
        int Create(OrderItem orderItem);
        int Delete(OrderItem orderItem);
        int Update(OrderItem orderItem);
    }
}