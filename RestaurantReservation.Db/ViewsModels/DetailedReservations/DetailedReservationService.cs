using RestaurantReservation.Db.ViewsModels.DetailedEmpolyees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReservation.Db.ViewsModels.DetailedReservations
{
    public class DetailedReservationService : IDetailedReservationService
    {

        private readonly IDetailedReservationRepository _detailedReservationRepository;

        public DetailedReservationService(IDetailedReservationRepository detailedReservationRepository)
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
