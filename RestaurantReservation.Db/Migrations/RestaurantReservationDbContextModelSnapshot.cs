﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RestaurantReservation.Db;

#nullable disable

namespace RestaurantReservation.Db.Migrations
{
    [DbContext(typeof(RestaurantReservationDbContext))]
    partial class RestaurantReservationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("RestaurantReservation.Db.DomainModels.Customers.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerId"));

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            CustomerId = 1,
                            FirstName = "John",
                            LastName = "Doe"
                        },
                        new
                        {
                            CustomerId = 2,
                            FirstName = "Jane",
                            LastName = "Smith"
                        },
                        new
                        {
                            CustomerId = 3,
                            FirstName = "Michael",
                            LastName = "Johnson"
                        },
                        new
                        {
                            CustomerId = 4,
                            FirstName = "Emily",
                            LastName = "Williams"
                        },
                        new
                        {
                            CustomerId = 5,
                            FirstName = "David",
                            LastName = "Brown"
                        });
                });

            modelBuilder.Entity("RestaurantReservation.Db.DomainModels.Employees.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeId"));

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RestaurantId")
                        .HasColumnType("int");

                    b.HasKey("EmployeeId");

                    b.HasIndex("RestaurantId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            EmployeeId = 1,
                            FirstName = "Alice",
                            LastName = "Johnson",
                            Position = "Manager",
                            RestaurantId = 1
                        },
                        new
                        {
                            EmployeeId = 2,
                            FirstName = "Bob",
                            LastName = "Smith",
                            Position = "Chef",
                            RestaurantId = 3
                        },
                        new
                        {
                            EmployeeId = 3,
                            FirstName = "Sarah",
                            LastName = "Miller",
                            Position = "Server",
                            RestaurantId = 2
                        },
                        new
                        {
                            EmployeeId = 4,
                            FirstName = "James",
                            LastName = "Davis",
                            Position = "Bartender",
                            RestaurantId = 4
                        },
                        new
                        {
                            EmployeeId = 5,
                            FirstName = "Laura",
                            LastName = "Martinez",
                            Position = "Manager",
                            RestaurantId = 4
                        });
                });

            modelBuilder.Entity("RestaurantReservation.Db.DomainModels.MenuItems.MenuItem", b =>
                {
                    b.Property<int>("MenuItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MenuItemId"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("RestaurantId")
                        .HasColumnType("int");

                    b.HasKey("MenuItemId");

                    b.HasIndex("RestaurantId");

                    b.ToTable("MenuItems");

                    b.HasData(
                        new
                        {
                            MenuItemId = 1,
                            Description = "Delicious burger",
                            Name = "Burger",
                            Price = 10.99m,
                            RestaurantId = 1
                        },
                        new
                        {
                            MenuItemId = 2,
                            Description = "Tasty pizza",
                            Name = "Pizza",
                            Price = 12.99m,
                            RestaurantId = 2
                        },
                        new
                        {
                            MenuItemId = 3,
                            Description = "Fresh salad",
                            Name = "Salad",
                            Price = 7.99m,
                            RestaurantId = 1
                        },
                        new
                        {
                            MenuItemId = 4,
                            Description = "Juicy steak",
                            Name = "Steak",
                            Price = 18.99m,
                            RestaurantId = 3
                        },
                        new
                        {
                            MenuItemId = 5,
                            Description = "Homemade pasta",
                            Name = "Pasta",
                            Price = 9.99m,
                            RestaurantId = 5
                        });
                });

            modelBuilder.Entity("RestaurantReservation.Db.DomainModels.OrderItems.OrderItem", b =>
                {
                    b.Property<int>("OrderItemId")
                        .HasColumnType("int");

                    b.Property<int>("MenuItemId")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("OrderItemId");

                    b.HasIndex("MenuItemId");

                    b.ToTable("Items");

                    b.HasData(
                        new
                        {
                            OrderItemId = 1,
                            MenuItemId = 1,
                            OrderId = 1,
                            Quantity = 2
                        },
                        new
                        {
                            OrderItemId = 2,
                            MenuItemId = 2,
                            OrderId = 1,
                            Quantity = 1
                        },
                        new
                        {
                            OrderItemId = 3,
                            MenuItemId = 3,
                            OrderId = 2,
                            Quantity = 1
                        },
                        new
                        {
                            OrderItemId = 4,
                            MenuItemId = 4,
                            OrderId = 3,
                            Quantity = 3
                        },
                        new
                        {
                            OrderItemId = 5,
                            MenuItemId = 5,
                            OrderId = 4,
                            Quantity = 1
                        });
                });

            modelBuilder.Entity("RestaurantReservation.Db.DomainModels.Orders.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int?>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("TotalAmount")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("OrderId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            OrderId = 1,
                            EmployeeId = 4,
                            OrderDate = new DateTime(2023, 8, 28, 10, 53, 29, 238, DateTimeKind.Local).AddTicks(5548),
                            TotalAmount = 23.98m
                        },
                        new
                        {
                            OrderId = 2,
                            EmployeeId = 3,
                            OrderDate = new DateTime(2023, 8, 27, 10, 53, 29, 238, DateTimeKind.Local).AddTicks(5576),
                            TotalAmount = 45.75m
                        },
                        new
                        {
                            OrderId = 3,
                            EmployeeId = 3,
                            OrderDate = new DateTime(2023, 8, 26, 10, 53, 29, 238, DateTimeKind.Local).AddTicks(5579),
                            TotalAmount = 32.50m
                        },
                        new
                        {
                            OrderId = 4,
                            EmployeeId = 2,
                            OrderDate = new DateTime(2023, 8, 25, 10, 53, 29, 238, DateTimeKind.Local).AddTicks(5581),
                            TotalAmount = 15.25m
                        },
                        new
                        {
                            OrderId = 5,
                            EmployeeId = 2,
                            OrderDate = new DateTime(2023, 8, 24, 10, 53, 29, 238, DateTimeKind.Local).AddTicks(5582),
                            TotalAmount = 28.90m
                        });
                });

            modelBuilder.Entity("RestaurantReservation.Db.DomainModels.Reservations.Reservation", b =>
                {
                    b.Property<int>("ReservationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReservationId"));

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int>("PartySize")
                        .HasColumnType("int");

                    b.Property<DateTime>("ReservationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("RestaurantId")
                        .HasColumnType("int");

                    b.Property<int>("TableId")
                        .HasColumnType("int");

                    b.HasKey("ReservationId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("RestaurantId");

                    b.HasIndex("TableId");

                    b.ToTable("Reservations");

                    b.HasData(
                        new
                        {
                            ReservationId = 1,
                            CustomerId = 3,
                            PartySize = 0,
                            ReservationDate = new DateTime(2023, 8, 29, 10, 53, 29, 238, DateTimeKind.Local).AddTicks(5604),
                            RestaurantId = 1,
                            TableId = 1
                        },
                        new
                        {
                            ReservationId = 2,
                            CustomerId = 3,
                            PartySize = 2,
                            ReservationDate = new DateTime(2023, 8, 30, 10, 53, 29, 238, DateTimeKind.Local).AddTicks(5606),
                            RestaurantId = 2,
                            TableId = 2
                        },
                        new
                        {
                            ReservationId = 3,
                            CustomerId = 4,
                            PartySize = 1,
                            ReservationDate = new DateTime(2023, 8, 31, 10, 53, 29, 238, DateTimeKind.Local).AddTicks(5608),
                            RestaurantId = 3,
                            TableId = 3
                        },
                        new
                        {
                            ReservationId = 4,
                            CustomerId = 5,
                            PartySize = 1,
                            ReservationDate = new DateTime(2023, 9, 1, 10, 53, 29, 238, DateTimeKind.Local).AddTicks(5610),
                            RestaurantId = 4,
                            TableId = 4
                        },
                        new
                        {
                            ReservationId = 5,
                            CustomerId = 1,
                            PartySize = 0,
                            ReservationDate = new DateTime(2023, 9, 2, 10, 53, 29, 238, DateTimeKind.Local).AddTicks(5611),
                            RestaurantId = 4,
                            TableId = 5
                        });
                });

            modelBuilder.Entity("RestaurantReservation.Db.DomainModels.Restaurants.Restaurant", b =>
                {
                    b.Property<int>("RestaurantId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RestaurantId"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<TimeSpan>("CloseHour")
                        .HasColumnType("time");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<TimeSpan>("OpenHour")
                        .HasColumnType("time");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RestaurantId");

                    b.ToTable("Restaurants");

                    b.HasData(
                        new
                        {
                            RestaurantId = 1,
                            Address = "123 Main St",
                            CloseHour = new TimeSpan(0, 22, 0, 0, 0),
                            Name = "Restaurant A",
                            OpenHour = new TimeSpan(0, 8, 0, 0, 0)
                        },
                        new
                        {
                            RestaurantId = 2,
                            Address = "456 Elm St",
                            CloseHour = new TimeSpan(0, 23, 0, 0, 0),
                            Name = "Restaurant B",
                            OpenHour = new TimeSpan(0, 9, 0, 0, 0)
                        },
                        new
                        {
                            RestaurantId = 3,
                            Address = "789 Oak St",
                            CloseHour = new TimeSpan(0, 21, 30, 0, 0),
                            Name = "Restaurant C",
                            OpenHour = new TimeSpan(0, 7, 30, 0, 0)
                        },
                        new
                        {
                            RestaurantId = 4,
                            Address = "555 Maple St",
                            CloseHour = new TimeSpan(0, 21, 0, 0, 0),
                            Name = "Restaurant D",
                            OpenHour = new TimeSpan(0, 8, 0, 0, 0)
                        },
                        new
                        {
                            RestaurantId = 5,
                            Address = "222 Pine St",
                            CloseHour = new TimeSpan(0, 23, 0, 0, 0),
                            Name = "Restaurant E",
                            OpenHour = new TimeSpan(0, 10, 0, 0, 0)
                        });
                });

            modelBuilder.Entity("RestaurantReservation.Db.DomainModels.Tables.Table", b =>
                {
                    b.Property<int>("TableId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TableId"));

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<int>("RestaurantId")
                        .HasColumnType("int");

                    b.HasKey("TableId");

                    b.HasIndex("RestaurantId");

                    b.ToTable("Tables");

                    b.HasData(
                        new
                        {
                            TableId = 1,
                            Capacity = 4,
                            RestaurantId = 1
                        },
                        new
                        {
                            TableId = 2,
                            Capacity = 6,
                            RestaurantId = 2
                        },
                        new
                        {
                            TableId = 3,
                            Capacity = 2,
                            RestaurantId = 2
                        },
                        new
                        {
                            TableId = 4,
                            Capacity = 8,
                            RestaurantId = 3
                        },
                        new
                        {
                            TableId = 5,
                            Capacity = 4,
                            RestaurantId = 3
                        });
                });

            modelBuilder.Entity("RestaurantReservation.Db.DomainModels.Employees.Employee", b =>
                {
                    b.HasOne("RestaurantReservation.Db.DomainModels.Restaurants.Restaurant", "Restaurant")
                        .WithMany("Employees")
                        .HasForeignKey("RestaurantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Restaurant");
                });

            modelBuilder.Entity("RestaurantReservation.Db.DomainModels.MenuItems.MenuItem", b =>
                {
                    b.HasOne("RestaurantReservation.Db.DomainModels.Restaurants.Restaurant", "Restaurant")
                        .WithMany("MenuItems")
                        .HasForeignKey("RestaurantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Restaurant");
                });

            modelBuilder.Entity("RestaurantReservation.Db.DomainModels.OrderItems.OrderItem", b =>
                {
                    b.HasOne("RestaurantReservation.Db.DomainModels.MenuItems.MenuItem", "MenuItem")
                        .WithMany()
                        .HasForeignKey("MenuItemId")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.HasOne("RestaurantReservation.Db.DomainModels.Orders.Order", "Order")
                        .WithMany("Items")
                        .HasForeignKey("OrderItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MenuItem");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("RestaurantReservation.Db.DomainModels.Orders.Order", b =>
                {
                    b.HasOne("RestaurantReservation.Db.DomainModels.Employees.Employee", null)
                        .WithMany("Orders")
                        .HasForeignKey("EmployeeId");

                    b.HasOne("RestaurantReservation.Db.DomainModels.Employees.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.HasOne("RestaurantReservation.Db.DomainModels.Reservations.Reservation", "Reservation")
                        .WithMany()
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");

                    b.Navigation("Reservation");
                });

            modelBuilder.Entity("RestaurantReservation.Db.DomainModels.Reservations.Reservation", b =>
                {
                    b.HasOne("RestaurantReservation.Db.DomainModels.Customers.Customer", "Customer")
                        .WithMany("Reservations")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RestaurantReservation.Db.DomainModels.Restaurants.Restaurant", "Restaurant")
                        .WithMany("Reservations")
                        .HasForeignKey("RestaurantId")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();

                    b.HasOne("RestaurantReservation.Db.DomainModels.Tables.Table", "Table")
                        .WithMany("Reservations")
                        .HasForeignKey("TableId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Restaurant");

                    b.Navigation("Table");
                });

            modelBuilder.Entity("RestaurantReservation.Db.DomainModels.Tables.Table", b =>
                {
                    b.HasOne("RestaurantReservation.Db.DomainModels.Restaurants.Restaurant", "Restaurant")
                        .WithMany("Tables")
                        .HasForeignKey("RestaurantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Restaurant");
                });

            modelBuilder.Entity("RestaurantReservation.Db.DomainModels.Customers.Customer", b =>
                {
                    b.Navigation("Reservations");
                });

            modelBuilder.Entity("RestaurantReservation.Db.DomainModels.Employees.Employee", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("RestaurantReservation.Db.DomainModels.Orders.Order", b =>
                {
                    b.Navigation("Items");
                });

            modelBuilder.Entity("RestaurantReservation.Db.DomainModels.Restaurants.Restaurant", b =>
                {
                    b.Navigation("Employees");

                    b.Navigation("MenuItems");

                    b.Navigation("Reservations");

                    b.Navigation("Tables");
                });

            modelBuilder.Entity("RestaurantReservation.Db.DomainModels.Tables.Table", b =>
                {
                    b.Navigation("Reservations");
                });
#pragma warning restore 612, 618
        }
    }
}
