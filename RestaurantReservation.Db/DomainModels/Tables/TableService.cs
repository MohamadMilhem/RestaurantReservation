namespace RestaurantReservation.Db.DomainModels.Tables
{
    public class TableService
    {

        private readonly ITableRepository _tableRepository;

        public TableService(ITableRepository tableRepository)
        {
            _tableRepository = tableRepository;
        }
    }
}
