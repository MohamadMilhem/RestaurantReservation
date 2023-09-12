namespace RestaurantReservation.Db.ViewsModels.DetailedReservations
{
    public interface IDetailedReservation
    {
        string? Address { get; set; }
        TimeOnly CloseHour { get; set; }
        string? CustomerEmail { get; set; }
        int CustomerId { get; set; }
        string? CustomerPhoneNumber { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        TimeOnly OpenHour { get; set; }
        PartySize PartySize { get; set; }
        DateTime ReservationDate { get; set; }
        int ReservationId { get; set; }
        int RestaurantId { get; set; }
        string? RestaurantName { get; set; }
        string? RestaurantPhoneNumber { get; set; }
        int TableId { get; set; }
    }
}