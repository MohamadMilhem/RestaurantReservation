using RestaurantReservation.Db.ViewsModels.DetailedEmpolyees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReservation.Db.ViewsModels.DetailedReservations
{
    public class DetailedReservationService
    {

        private readonly DetailedReservationRepository _detailedReservationRepository;

        public DetailedReservationService(DetailedReservationRepository detailedReservationRepository)
        {
            _detailedReservationRepository = detailedReservationRepository;
        }

        public DetailedReservation GetDetailedReservation(int id)
        {
            var reservation = _detailedReservationRepository.GetDetailedReservationById(id);
            return reservation;
        }
    }
}
