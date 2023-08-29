using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestaurantReservation.Db.Migrations
{
    /// <inheritdoc />
    public partial class AddDetailedEmployeesView : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@" CREATE VIEW dbo.DetailedEmployees
                                    AS
                                    SELECT  emp.EmployeeId, emp.FirstName, emp.LastName, emp.Position,
                                    res.Name AS 'RestaurantName', res.Address, res.PhoneNumber AS 'RestaurantPhoneNumber', res.OpenHour, res.CloseHour
                                    FROM Employees AS emp
                                    JOIN Restaurants AS res
                                    ON emp.RestaurantId = res.RestaurantId;"
                                    );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"DROP VIEW IF EXISTS dbo.DetailedEmployees;");
        }
    }
}
