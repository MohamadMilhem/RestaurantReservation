using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RestaurantReservation.Db.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservation_Customers_CustomerId1",
                table: "Reservation");

            migrationBuilder.DropIndex(
                name: "IX_Reservation_CustomerId1",
                table: "Reservation");

            migrationBuilder.DropColumn(
                name: "CustomerId1",
                table: "Reservation");

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, null, "John", "Doe", null },
                    { 2, null, "Jane", "Smith", null },
                    { 3, null, "Michael", "Johnson", null },
                    { 4, null, "Emily", "Williams", null },
                    { 5, null, "David", "Brown", null }
                });

            migrationBuilder.InsertData(
                table: "Restaurants",
                columns: new[] { "RestaurantId", "Address", "CloseHour", "Name", "OpenHour", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, "123 Main St", new TimeSpan(0, 22, 0, 0, 0), "Restaurant A", new TimeSpan(0, 8, 0, 0, 0), null },
                    { 2, "456 Elm St", new TimeSpan(0, 23, 0, 0, 0), "Restaurant B", new TimeSpan(0, 9, 0, 0, 0), null },
                    { 3, "789 Oak St", new TimeSpan(0, 21, 30, 0, 0), "Restaurant C", new TimeSpan(0, 7, 30, 0, 0), null },
                    { 4, "555 Maple St", new TimeSpan(0, 21, 0, 0, 0), "Restaurant D", new TimeSpan(0, 8, 0, 0, 0), null },
                    { 5, "222 Pine St", new TimeSpan(0, 23, 0, 0, 0), "Restaurant E", new TimeSpan(0, 10, 0, 0, 0), null }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "FirstName", "LastName", "Position", "RestaurantId" },
                values: new object[,]
                {
                    { 1, "Alice", "Johnson", "Manager", 1 },
                    { 2, "Bob", "Smith", "Chef", 3 },
                    { 3, "Sarah", "Miller", "Server", 2 },
                    { 4, "James", "Davis", "Bartender", 4 },
                    { 5, "Laura", "Martinez", "Manager", 4 }
                });

            migrationBuilder.InsertData(
                table: "MenuItems",
                columns: new[] { "MenuItemId", "Description", "Name", "Price", "RestaurantId" },
                values: new object[,]
                {
                    { 1, "Delicious burger", "Burger", 10.99m, 1 },
                    { 2, "Tasty pizza", "Pizza", 12.99m, 2 },
                    { 3, "Fresh salad", "Salad", 7.99m, 1 },
                    { 4, "Juicy steak", "Steak", 18.99m, 3 },
                    { 5, "Homemade pasta", "Pasta", 9.99m, 5 }
                });

            migrationBuilder.InsertData(
                table: "Tables",
                columns: new[] { "TableId", "Capacity", "RestaurantId" },
                values: new object[,]
                {
                    { 1, 4, 1 },
                    { 2, 6, 2 },
                    { 3, 2, 2 },
                    { 4, 8, 3 },
                    { 5, 4, 3 }
                });

            migrationBuilder.InsertData(
                table: "Reservation",
                columns: new[] { "ReservationId", "CustomerId", "PartySize", "ReservationDate", "RestaurantId", "TableId" },
                values: new object[,]
                {
                    { 1, 3, 0, new DateTime(2023, 8, 28, 15, 25, 18, 374, DateTimeKind.Local).AddTicks(4039), 1, 1 },
                    { 2, 3, 2, new DateTime(2023, 8, 29, 15, 25, 18, 374, DateTimeKind.Local).AddTicks(4042), 2, 2 },
                    { 3, 4, 1, new DateTime(2023, 8, 30, 15, 25, 18, 374, DateTimeKind.Local).AddTicks(4043), 3, 3 },
                    { 4, 5, 1, new DateTime(2023, 8, 31, 15, 25, 18, 374, DateTimeKind.Local).AddTicks(4045), 4, 4 },
                    { 5, 1, 0, new DateTime(2023, 9, 1, 15, 25, 18, 374, DateTimeKind.Local).AddTicks(4047), 4, 5 }
                });

            migrationBuilder.InsertData(
                table: "Order",
                columns: new[] { "OrderId", "EmployeeId", "OrderDate", "TotalAmount" },
                values: new object[,]
                {
                    { 1, 4, new DateTime(2023, 8, 27, 15, 25, 18, 374, DateTimeKind.Local).AddTicks(3972), 23.98m },
                    { 2, 3, new DateTime(2023, 8, 26, 15, 25, 18, 374, DateTimeKind.Local).AddTicks(4005), 45.75m },
                    { 3, 3, new DateTime(2023, 8, 25, 15, 25, 18, 374, DateTimeKind.Local).AddTicks(4008), 32.50m },
                    { 4, 2, new DateTime(2023, 8, 24, 15, 25, 18, 374, DateTimeKind.Local).AddTicks(4009), 15.25m },
                    { 5, 2, new DateTime(2023, 8, 23, 15, 25, 18, 374, DateTimeKind.Local).AddTicks(4011), 28.90m }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "OrderItemId", "MenuItemId", "OrderId", "Quantity" },
                values: new object[,]
                {
                    { 1, 1, 1, 2 },
                    { 2, 2, 1, 1 },
                    { 3, 3, 2, 1 },
                    { 4, 4, 3, 3 },
                    { 5, 5, 4, 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "OrderItemId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "OrderItemId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "OrderItemId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "OrderItemId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "OrderItemId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "MenuItems",
                keyColumn: "MenuItemId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Order",
                keyColumn: "OrderId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Reservation",
                keyColumn: "ReservationId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reservation",
                keyColumn: "ReservationId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Reservation",
                keyColumn: "ReservationId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Reservation",
                keyColumn: "ReservationId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Reservation",
                keyColumn: "ReservationId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "RestaurantId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "RestaurantId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "RestaurantId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "RestaurantId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "RestaurantId",
                keyValue: 3);

            migrationBuilder.AddColumn<int>(
                name: "CustomerId1",
                table: "Reservation",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Reservation_CustomerId1",
                table: "Reservation",
                column: "CustomerId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservation_Customers_CustomerId1",
                table: "Reservation",
                column: "CustomerId1",
                principalTable: "Customers",
                principalColumn: "CustomerId");
        }
    }
}
