namespace RestaurantReservation.Db.ViewsModels.DetailedEmpolyees
{
    public interface IDetailedEmployee
    {
        string? Address { get; set; }
        TimeOnly CloseHour { get; set; }
        int EmployeeId { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        TimeOnly OpenHour { get; set; }
        string? Position { get; set; }
        string? RestaurantName { get; set; }
        string? RestaurantPhoneNumber { get; set; }
    }
}