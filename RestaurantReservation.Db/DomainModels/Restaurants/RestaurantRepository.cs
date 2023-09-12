using Microsoft.EntityFrameworkCore;

namespace RestaurantReservation.Db.DomainModels.Restaurants
{
    public class RestaurantRepository : IRestaurantRepository
    {

        private RestaurantReservationDbContext _dbContext;

        public RestaurantRepository()
        {
            _dbContext = new RestaurantReservationDbContext();
        }

        public int Create(Restaurant restaurant)
        {
            _dbContext.Restaurants.Add(restaurant);
            return _dbContext.SaveChanges();
        }

        public int Update(Restaurant restaurant)
        {
            _dbContext.Restaurants.Update(restaurant);
            return _dbContext.SaveChanges();
        }

        public int Delete(Restaurant restaurant)
        {
            var result = _dbContext.Restaurants.Find(restaurant);
            if (result != null)
            {
                _dbContext.Restaurants.Remove(result);
            }
            return _dbContext.SaveChanges();
        }

        public Restaurant GetWithDetailedReservations(int id)
        {
            return _dbContext.Restaurants.Include(restaurant => restaurant.Reservations)
                        .ThenInclude(reservation => reservation.Orders)
                            .SingleOrDefault(restaurant => restaurant.RestaurantId == id);
        }
    }
}
