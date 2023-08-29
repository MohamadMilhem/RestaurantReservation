using Microsoft.EntityFrameworkCore;
using RestaurantReservation.Db.DomainModels.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReservation.Db.DomainModels.Reservations
{
    public class ReservationRepository
    {
        private RestaurantReservationDbContext _dbContext;

        public ReservationRepository()
        {
            _dbContext = new RestaurantReservationDbContext();
        }

        public int Create(Reservation reservation)
        {
            _dbContext.Reservations.Add(reservation);
            return _dbContext.SaveChanges();
        }

        public int Update(Reservation reservation)
        {
            _dbContext.Reservations.Update(reservation);
            return _dbContext.SaveChanges();
        }

        public int Delete(Reservation reservation)
        {
            var result = _dbContext.Reservations.Find(reservation);
            if (result != null)
            {
                _dbContext.Reservations.Remove(result);
            }
            return _dbContext.SaveChanges();
        }

        public Reservation GetOrdersWithItemsById(int id)
        {
            return _dbContext.Reservations.Include(reservation => reservation.Orders)
                    .ThenInclude(order => order.Items).ThenInclude(oi => oi.MenuItem).SingleOrDefault(res => res.ReservationId == id);
        }

    }
}
