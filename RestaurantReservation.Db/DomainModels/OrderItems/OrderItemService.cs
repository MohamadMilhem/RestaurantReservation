namespace RestaurantReservation.Db.DomainModels.OrderItems
{
    public class OrderItemService
    {

        private readonly OrderItemRepository _orderItemRepository;

        public OrderItemService(OrderItemRepository orderItemRepository)
        {
            _orderItemRepository = orderItemRepository;
        }


    }
}
