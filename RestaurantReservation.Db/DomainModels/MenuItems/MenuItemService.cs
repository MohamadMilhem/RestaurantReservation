namespace RestaurantReservation.Db.DomainModels.MenuItems
{
    public class MenuItemService
    {

        private readonly MenuItemRepository _menuItemRepository;

        public MenuItemService(MenuItemRepository menuRepository)
        {
            _menuItemRepository = menuRepository;
        }
    }
}
