namespace RestaurantReservation.Db.DomainModels.Tables
{
    public interface ITableRepository
    {
        int Create(Table table);
        int Delete(Table table);
        int Update(Table table);
    }
}