namespace RestaurantReservation.Db.DomainModels.Tables
{
    public class TableService
    {

        private readonly TableRepository _tableRepository;

        public TableService(TableRepository tableRepository)
        {
            _tableRepository = tableRepository;
        }
    }
}
