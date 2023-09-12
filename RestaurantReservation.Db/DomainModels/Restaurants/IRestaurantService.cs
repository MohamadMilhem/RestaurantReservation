namespace RestaurantReservation.Db.DomainModels.Restaurants
{
    public interface IRestaurantService
    {
        decimal GetTotalRevenue(int id);
    }
}