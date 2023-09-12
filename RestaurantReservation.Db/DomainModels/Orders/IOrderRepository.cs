namespace RestaurantReservation.Db.DomainModels.Orders
{
    public interface IOrderRepository
    {
        int Create(Order order);
        int Delete(Order order);
        int Update(Order order);
    }
}