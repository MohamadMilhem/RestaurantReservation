namespace RestaurantReservation.Db.DomainModels.OrderItems
{
    public class OrderItemService
    {

        private readonly IOrderItemRepository _orderItemRepository;

        public OrderItemService(IOrderItemRepository orderItemRepository)
        {
            _orderItemRepository = orderItemRepository;
        }
    }
}
