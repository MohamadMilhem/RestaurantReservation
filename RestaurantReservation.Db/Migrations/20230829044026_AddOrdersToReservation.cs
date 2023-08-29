using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestaurantReservation.Db.Migrations
{
    /// <inheritdoc />
    public partial class AddOrdersToReservation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2023, 8, 29, 7, 40, 26, 645, DateTimeKind.Local).AddTicks(3223));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 2,
                column: "OrderDate",
                value: new DateTime(2023, 8, 28, 7, 40, 26, 645, DateTimeKind.Local).AddTicks(3256));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 3,
                column: "OrderDate",
                value: new DateTime(2023, 8, 27, 7, 40, 26, 645, DateTimeKind.Local).AddTicks(3258));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 4,
                column: "OrderDate",
                value: new DateTime(2023, 8, 26, 7, 40, 26, 645, DateTimeKind.Local).AddTicks(3260));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 5,
                column: "OrderDate",
                value: new DateTime(2023, 8, 25, 7, 40, 26, 645, DateTimeKind.Local).AddTicks(3262));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 1,
                column: "ReservationDate",
                value: new DateTime(2023, 8, 30, 7, 40, 26, 645, DateTimeKind.Local).AddTicks(3285));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 2,
                column: "ReservationDate",
                value: new DateTime(2023, 8, 31, 7, 40, 26, 645, DateTimeKind.Local).AddTicks(3288));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 3,
                column: "ReservationDate",
                value: new DateTime(2023, 9, 1, 7, 40, 26, 645, DateTimeKind.Local).AddTicks(3294));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 4,
                column: "ReservationDate",
                value: new DateTime(2023, 9, 2, 7, 40, 26, 645, DateTimeKind.Local).AddTicks(3295));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 5,
                column: "ReservationDate",
                value: new DateTime(2023, 9, 3, 7, 40, 26, 645, DateTimeKind.Local).AddTicks(3297));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2023, 8, 28, 19, 16, 5, 353, DateTimeKind.Local).AddTicks(2192));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 2,
                column: "OrderDate",
                value: new DateTime(2023, 8, 27, 19, 16, 5, 353, DateTimeKind.Local).AddTicks(2230));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 3,
                column: "OrderDate",
                value: new DateTime(2023, 8, 26, 19, 16, 5, 353, DateTimeKind.Local).AddTicks(2233));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 4,
                column: "OrderDate",
                value: new DateTime(2023, 8, 25, 19, 16, 5, 353, DateTimeKind.Local).AddTicks(2234));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 5,
                column: "OrderDate",
                value: new DateTime(2023, 8, 24, 19, 16, 5, 353, DateTimeKind.Local).AddTicks(2236));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 1,
                column: "ReservationDate",
                value: new DateTime(2023, 8, 29, 19, 16, 5, 353, DateTimeKind.Local).AddTicks(2260));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 2,
                column: "ReservationDate",
                value: new DateTime(2023, 8, 30, 19, 16, 5, 353, DateTimeKind.Local).AddTicks(2262));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 3,
                column: "ReservationDate",
                value: new DateTime(2023, 8, 31, 19, 16, 5, 353, DateTimeKind.Local).AddTicks(2264));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 4,
                column: "ReservationDate",
                value: new DateTime(2023, 9, 1, 19, 16, 5, 353, DateTimeKind.Local).AddTicks(2266));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 5,
                column: "ReservationDate",
                value: new DateTime(2023, 9, 2, 19, 16, 5, 353, DateTimeKind.Local).AddTicks(2268));
        }
    }
}
