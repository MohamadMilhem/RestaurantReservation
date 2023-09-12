namespace RestaurantReservation.Db.DomainModels.MenuItems
{
    public class MenuItemRepository
    {

        private RestaurantReservationDbContext _dbContext;

        public MenuItemRepository()
        {
            _dbContext = new RestaurantReservationDbContext();
        }

        public int Create(MenuItem menuItem)
        {
            _dbContext.MenuItems.Add(menuItem);
            return _dbContext.SaveChanges();
        }

        public int Update(MenuItem menuItem)
        {
            _dbContext.MenuItems.Update(menuItem);
            return _dbContext.SaveChanges();
        }

        public int Delete(MenuItem menuItem)
        {
            var result = _dbContext.MenuItems.Find(menuItem);
            if (result != null)
            {
                _dbContext.MenuItems.Remove(result);
            }
            return _dbContext.SaveChanges();
        }
    }
}
