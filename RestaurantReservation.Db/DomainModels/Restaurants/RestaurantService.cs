namespace RestaurantReservation.Db.DomainModels.Restaurants
{
    public class RestaurantService : IRestaurantService
    {

        private readonly IRestaurantRepository _restaurantRepository;

        public RestaurantService(IRestaurantRepository restaurantRepository)
        {
            _restaurantRepository = restaurantRepository;
        }

        public decimal GetTotalRevenue(int id)
        {
            var restaurant = _restaurantRepository.GetWithDetailedReservations(id);
            if (restaurant == null)
            {
                return 0;
            }
            var TotalRevenue = restaurant.Reservations.Sum(res => res.Orders.Sum(o => o.TotalAmount));
            return TotalRevenue;
        }
    }
}
