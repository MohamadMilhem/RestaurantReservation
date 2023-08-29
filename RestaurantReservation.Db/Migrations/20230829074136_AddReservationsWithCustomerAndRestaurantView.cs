using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestaurantReservation.Db.Migrations
{
    /// <inheritdoc />
    public partial class AddReservationsWithCustomerAndRestaurantView : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@" CREATE VIEW dbo.ReservationDetails
                                    AS
                                    SELECT Res.ReservationId, Res.TableId, Res.ReservationDate, Res.PartySize,
                                    C.CustomerId, C.FirstName, C.LastName, C.Email As 'CustomerEmail', C.PhoneNumber As 'CustomerPhoneNumber',
                                    Rest.RestaurantId, Rest.Name As 'RestaurantName', Rest.Address, Rest.PhoneNumber As 'RestaurantPhoneNumber', Rest.OpenHour, Rest.CloseHour
                                    FROM Reservations AS Res
                                    JOIN Customers AS C ON C.CustomerId = Res.CustomerId
                                    JOIN Restaurants AS Rest ON Rest.RestaurantId = Res.RestaurantId;
                                    ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"DROP VIEW IF EXISTS dbo.ReservationDetails;");
        }
    }
}
