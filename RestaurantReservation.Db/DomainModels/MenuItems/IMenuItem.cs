using RestaurantReservation.Db.DomainModels.Restaurants;

namespace RestaurantReservation.Db.DomainModels.MenuItems
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