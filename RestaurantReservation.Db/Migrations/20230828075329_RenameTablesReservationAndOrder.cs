using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RestaurantReservation.Db.Migrations
{
    /// <inheritdoc />
    public partial class RenameTablesReservationAndOrder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_MenuItems_MenuItemId",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_Order_OrderItemId",
                table: "Items");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "Reservation");

            migrationBuilder.CreateTable(
                name: "Reservations",
                columns: table => new
                {
                    ReservationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    RestaurantId = table.Column<int>(type: "int", nullable: false),
                    TableId = table.Column<int>(type: "int", nullable: false),
                    ReservationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PartySize = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservations", x => x.ReservationId);
                    table.ForeignKey(
                        name: "FK_Reservations_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reservations_Restaurants_RestaurantId",
                        column: x => x.RestaurantId,
                        principalTable: "Restaurants",
                        principalColumn: "RestaurantId");
                    table.ForeignKey(
                        name: "FK_Reservations_Tables_TableId",
                        column: x => x.TableId,
                        principalTable: "Tables",
                        principalColumn: "TableId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                    table.ForeignKey(
                        name: "FK_Orders_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId");
                    table.ForeignKey(
                        name: "FK_Orders_Employees_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId");
                    table.ForeignKey(
                        name: "FK_Orders_Reservations_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Reservations",
                        principalColumn: "ReservationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "ReservationId", "CustomerId", "PartySize", "ReservationDate", "RestaurantId", "TableId" },
                values: new object[,]
                {
                    { 1, 3, 0, new DateTime(2023, 8, 29, 10, 53, 29, 238, DateTimeKind.Local).AddTicks(5604), 1, 1 },
                    { 2, 3, 2, new DateTime(2023, 8, 30, 10, 53, 29, 238, DateTimeKind.Local).AddTicks(5606), 2, 2 },
                    { 3, 4, 1, new DateTime(2023, 8, 31, 10, 53, 29, 238, DateTimeKind.Local).AddTicks(5608), 3, 3 },
                    { 4, 5, 1, new DateTime(2023, 9, 1, 10, 53, 29, 238, DateTimeKind.Local).AddTicks(5610), 4, 4 },
                    { 5, 1, 0, new DateTime(2023, 9, 2, 10, 53, 29, 238, DateTimeKind.Local).AddTicks(5611), 4, 5 }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderId", "EmployeeId", "OrderDate", "TotalAmount" },
                values: new object[,]
                {
                    { 1, 4, new DateTime(2023, 8, 28, 10, 53, 29, 238, DateTimeKind.Local).AddTicks(5548), 23.98m },
                    { 2, 3, new DateTime(2023, 8, 27, 10, 53, 29, 238, DateTimeKind.Local).AddTicks(5576), 45.75m },
                    { 3, 3, new DateTime(2023, 8, 26, 10, 53, 29, 238, DateTimeKind.Local).AddTicks(5579), 32.50m },
                    { 4, 2, new DateTime(2023, 8, 25, 10, 53, 29, 238, DateTimeKind.Local).AddTicks(5581), 15.25m },
                    { 5, 2, new DateTime(2023, 8, 24, 10, 53, 29, 238, DateTimeKind.Local).AddTicks(5582), 28.90m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_EmployeeId",
                table: "Orders",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_CustomerId",
                table: "Reservations",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_RestaurantId",
                table: "Reservations",
                column: "RestaurantId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservations_TableId",
                table: "Reservations",
                column: "TableId");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_MenuItems_MenuItemId",
                table: "Items",
                column: "MenuItemId",
                principalTable: "MenuItems",
                principalColumn: "MenuItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Orders_OrderItemId",
                table: "Items",
                column: "OrderItemId",
                principalTable: "Orders",
                principalColumn: "OrderId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_MenuItems_MenuItemId",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_Orders_OrderItemId",
                table: "Items");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Reservations");

            migrationBuilder.CreateTable(
                name: "Reservation",
                columns: table => new
                {
                    ReservationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    RestaurantId = table.Column<int>(type: "int", nullable: false),
                    TableId = table.Column<int>(type: "int", nullable: false),
                    PartySize = table.Column<int>(type: "int", nullable: false),
                    ReservationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservation", x => x.ReservationId);
                    table.ForeignKey(
                        name: "FK_Reservation_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reservation_Restaurants_RestaurantId",
                        column: x => x.RestaurantId,
                        principalTable: "Restaurants",
                        principalColumn: "RestaurantId");
                    table.ForeignKey(
                        name: "FK_Reservation_Tables_TableId",
                        column: x => x.TableId,
                        principalTable: "Tables",
                        principalColumn: "TableId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: true),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.OrderId);
                    table.ForeignKey(
                        name: "FK_Order_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId");
                    table.ForeignKey(
                        name: "FK_Order_Employees_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId");
                    table.ForeignKey(
                        name: "FK_Order_Reservation_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Reservation",
                        principalColumn: "ReservationId",
                        onDelete: ReferentialAction.Cascade);
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

            migrationBuilder.CreateIndex(
                name: "IX_Order_EmployeeId",
                table: "Order",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservation_CustomerId",
                table: "Reservation",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservation_RestaurantId",
                table: "Reservation",
                column: "RestaurantId");

            migrationBuilder.CreateIndex(
                name: "IX_Reservation_TableId",
                table: "Reservation",
                column: "TableId");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_MenuItems_MenuItemId",
                table: "Items",
                column: "MenuItemId",
                principalTable: "MenuItems",
                principalColumn: "MenuItemId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Order_OrderItemId",
                table: "Items",
                column: "OrderItemId",
                principalTable: "Order",
                principalColumn: "OrderId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
