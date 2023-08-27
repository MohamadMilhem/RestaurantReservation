using RestaurantReservation.Db.DataModels.MenuItems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReservation.Db.DataModels.OrderItems
{
    public class OrderItemRepository
    {
        private RestaurantReservationDbContext _dbContext;

        public OrderItemRepository()
        {
            _dbContext = new RestaurantReservationDbContext();
        }

        public int Create(OrderItem orderItem)
        {
            _dbContext.Items.Add(orderItem);
            return _dbContext.SaveChanges();
        }

        public int Update(OrderItem orderItem)
        {
            _dbContext.Items.Update(orderItem);
            return _dbContext.SaveChanges();
        }

        public int Delete(OrderItem orderItem)
        {
            var result = _dbContext.Items.Find(orderItem);
            if (result != null)
            {
                _dbContext.Items.Remove(result);
            }
            return _dbContext.SaveChanges();
        }
    }
}
