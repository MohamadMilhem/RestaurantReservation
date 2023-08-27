using RestaurantReservation.Db.DataModels.OrderItems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReservation.Db.DataModels.Orders
{
    public class OrderRepository
    {
        private RestaurantReservationDbContext _dbContext;

        public OrderRepository()
        {
            _dbContext = new RestaurantReservationDbContext();
        }

        public int Create(Order order)
        {
            _dbContext.Orders.Add(order);
            return _dbContext.SaveChanges();
        }

        public int Update(Order order)
        {
            _dbContext.Orders.Update(order);
            return _dbContext.SaveChanges();
        }

        public int Delete(Order order)
        {
            var result = _dbContext.Orders.Find(order);
            if (result != null)
            {
                _dbContext.Orders.Remove(result);
            }
            return _dbContext.SaveChanges();
        }
    }
}
