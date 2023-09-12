namespace RestaurantReservation.Db.DomainModels.Reservations
{
    public interface IReservationRepository
    {
        int Create(Reservation reservation);
        int Delete(Reservation reservation);
        Reservation GetOrdersWithItemsById(int id);
        int Update(Reservation reservation);
    }
}