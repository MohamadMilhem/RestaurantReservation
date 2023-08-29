using RestaurantReservation.Db.DomainModels.MenuItems;
using RestaurantReservation.Db.DomainModels.OrderItems;
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
        
        public ReservationService(ReservationRepository reservationRepository)
        {
            _reservationRepository = reservationRepository;
        }

        public IEnumerable<Order> GetDetailedOrders(int id)
        {
            var reservation = _reservationRepository.GetOrdersWithItemsById(id);
            if (reservation == null)
                return Enumerable.Empty<Order>();

            return reservation.Orders;
        }

        public IEnumerable<MenuItem> GetMenuItems(int id)
        {
            var reservation = _reservationRepository.GetOrdersWithItemsById(id);

            if (reservation == null)
                return Enumerable.Empty<MenuItem>();

            return reservation.Orders.SelectMany(order => order.Items).Select(oi => oi.MenuItem).ToList();
        }
    

    }
}
