namespace RestaurantReservation.Db.DomainModels.Orders
{
    public class OrderService
    {

        private readonly OrderRepository _orderRepository;

        public OrderService(OrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }
        
        


    }
}
