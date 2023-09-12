using RestaurantReservation.Db.DomainModels.MenuItems;
using RestaurantReservation.Db.DomainModels.Orders;

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
