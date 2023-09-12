namespace RestaurantReservation.Db.DomainModels.MenuItems
{
    public class MenuItemService
    {

        private readonly IMenuItemRepository _menuItemRepository;

        public MenuItemService(IMenuItemRepository menuRepository)
        {
            _menuItemRepository = menuRepository;
        }
    }
}
