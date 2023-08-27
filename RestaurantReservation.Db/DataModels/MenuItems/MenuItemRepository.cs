using RestaurantReservation.Db.DataModels.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReservation.Db.DataModels.MenuItems
{
    public class MenuItemRepository
    {
        private RestaurantReservationDbContext _dbContext;

        public MenuItemRepository()
        {
            _dbContext = new RestaurantReservationDbContext();
        }

        public int Create(MenuItem menuItem)
        {
            _dbContext.MenuItems.Add(menuItem);
            return _dbContext.SaveChanges();
        }

        public int Update(MenuItem menuItem)
        {
            _dbContext.MenuItems.Update(menuItem);
            return _dbContext.SaveChanges();
        }

        public int Delete(MenuItem menuItem)
        {
            var result = _dbContext.MenuItems.Find(menuItem);
            if (result != null)
            {
                _dbContext.MenuItems.Remove(result);
            }
            return _dbContext.SaveChanges();
        }
    }
}
