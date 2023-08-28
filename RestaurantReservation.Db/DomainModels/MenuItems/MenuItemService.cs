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

        private readonly IGenericRepository<MenuItem> _menuItemRepository;
        public MenuItemService(IGenericRepository<MenuItem> menuRepository)
        {
            _menuItemRepository = menuRepository;
        }

        
    }
}
