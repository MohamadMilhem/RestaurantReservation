using RestaurantReservation.Db.DataModels.Restaurants;

namespace RestaurantReservation.Db.DataModels.MenuItems
{
    public interface IMenuItem
    {
        string Description { get; set; }
        int MenuItemId { get; set; }
        string Name { get; set; }
        decimal Price { get; set; }
        Restaurant Restaurant { get; set; }
    }
}