namespace RestaurantReservation.Db.DomainModels.Restaurants
{
    public interface IRestaurantRepository
    {
        int Create(Restaurant restaurant);
        int Delete(Restaurant restaurant);
        Restaurant GetWithDetailedReservations(int id);
        int Update(Restaurant restaurant);
    }
}