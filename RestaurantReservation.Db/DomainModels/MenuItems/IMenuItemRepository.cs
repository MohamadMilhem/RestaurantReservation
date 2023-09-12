namespace RestaurantReservation.Db.DomainModels.MenuItems
{
    public interface IMenuItemRepository
    {
        int Create(MenuItem menuItem);
        int Delete(MenuItem menuItem);
        int Update(MenuItem menuItem);
    }
}