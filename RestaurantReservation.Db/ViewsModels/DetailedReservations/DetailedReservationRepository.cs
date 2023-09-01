using RestaurantReservation.Db.ViewsModels.DetailedEmpolyees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReservation.Db.ViewsModels.DetailedReservations
{
    public class DetailedReservationRepository
    {
        private readonly RestaurantReservationDbContext _dbContext;

        public DetailedReservationRepository()
        {
            _dbContext = new RestaurantReservationDbContext();
        }

        public DetailedReservation GetDetailedReservationById(int Id)
        {
            return _dbContext.DetailedReservations.SingleOrDefault(res => res.ReservationId == Id);
        }
    }
}
