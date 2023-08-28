using RestaurantReservation.Db.DomainModels.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReservation.Db.DomainModels.Reservations
{
    public class ReservationService
    {

        private readonly ReservationRepository _reservationRepository;
        private readonly OrderRepository _orderRepository;
        
        public ReservationService(ReservationRepository reservationRepository, OrderRepository orderRepository)
        {
            _reservationRepository = reservationRepository;
            _orderRepository = orderRepository;
        }

    

    }
}
