using RestaurantReservation.Db.DataModels.Reservations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReservation.Db.DataModels.Restaurants
{
    public class RestaurantRepository
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
    }
}
