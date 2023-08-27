using RestaurantReservation.Db.DataModels.Restaurants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReservation.Db.DataModels.Tables
{
    public class TableRepository
    {
        private RestaurantReservationDbContext _dbContext;

        public TableRepository()
        {
            _dbContext = new RestaurantReservationDbContext();
        }

        public int Create(Table table)
        {
            _dbContext.Tables.Add(table);
            return _dbContext.SaveChanges();
        }

        public int Update(Table table)
        {
            _dbContext.Tables.Update(table);
            return _dbContext.SaveChanges();
        }

        public int Delete(Table table)
        {
            var result = _dbContext.Tables.Find(table);
            if (result != null)
            {
                _dbContext.Tables.Remove(result);
            }
            return _dbContext.SaveChanges();
        }
    }
}
