namespace RestaurantReservation.Db.ViewsModels.DetailedEmpolyees
{
    public interface IDetailedEmployeeRepository
    {
        DetailedEmployee GetDetailedEmployeeById(int Id);
    }
}