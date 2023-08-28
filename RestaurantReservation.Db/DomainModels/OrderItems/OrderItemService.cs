namespace RestaurantReservation.Db.DomainModels.OrderItems
{
    public class OrderItemService
    {

        private readonly IGenericRepository<OrderItem> _orderItemRepository;

        public OrderItemService(IGenericRepository<OrderItem> orderItemRepository)
        {
            _orderItemRepository = orderItemRepository;
        }


    }
}
