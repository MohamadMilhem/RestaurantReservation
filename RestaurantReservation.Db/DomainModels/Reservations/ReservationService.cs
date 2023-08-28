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

        private readonly IGenericRepository<Reservation> _reservationRepository;
        private readonly IGenericRepository<Order> _orderRepository;
        
        public ReservationService(IGenericRepository<Reservation> reservationRepository, IGenericRepository<Order> orderRepository)
        {
            _reservationRepository = reservationRepository;
            _orderRepository = orderRepository;
        }

        public IEnumerable<Reservation> GetOrdersWithItems(Func<Reservation, bool> predicate)
        {
            var reservations = _reservationRepository
                .GetAllByWithRelated(predicate, 
                res => res.Orders.Select(o => _orderRepository.GetAllByWithRelated(null, order => order.Items)));

            return reservations; 
        }


    }
}
