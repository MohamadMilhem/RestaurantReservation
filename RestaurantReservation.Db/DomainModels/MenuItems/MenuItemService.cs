using RestaurantReservation.Db.DomainModels.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
