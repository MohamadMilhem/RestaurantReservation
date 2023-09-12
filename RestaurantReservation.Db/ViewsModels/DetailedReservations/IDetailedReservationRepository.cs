namespace RestaurantReservation.Db.ViewsModels.DetailedReservations
{
    public interface IDetailedReservationRepository
    {
        DetailedReservation GetDetailedReservationById(int Id);
    }
}