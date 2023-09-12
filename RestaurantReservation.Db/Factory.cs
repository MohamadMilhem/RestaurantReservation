using RestaurantReservation.Db.DomainModels.Customers;
using RestaurantReservation.Db.DomainModels.Employees;
using RestaurantReservation.Db.DomainModels.MenuItems;
using RestaurantReservation.Db.DomainModels.OrderItems;
using RestaurantReservation.Db.DomainModels.Orders;
using RestaurantReservation.Db.DomainModels.Reservations;
using RestaurantReservation.Db.DomainModels.Restaurants;
using RestaurantReservation.Db.DomainModels.Tables;
using RestaurantReservation.Db.ViewsModels.DetailedEmpolyees;
using RestaurantReservation.Db.ViewsModels.DetailedReservations;

namespace RestaurantReservation.Db
{
    public static class Factory
    {

        public static CustomerService CreateCustomerService()
        {
            var customerRepository = new CustomerRepository();
            return new CustomerService(customerRepository);
        }

        public static EmployeeService CreateEmployeeService()
        {
            var employeeRepository = new EmployeeRepository();
            return new EmployeeService(employeeRepository);
        }

        public static MenuItemService CreateMenuItemService() 
        {
            var menuItemRepository = new MenuItemRepository();  
            return new MenuItemService(menuItemRepository);
        }

        public static OrderItemService CreateOrderItemService()
        {
            var orderItemRepository = new OrderItemRepository();
            return new OrderItemService(orderItemRepository);
        }

        public static OrderService CreateOrderService()
        {
            var ordersRepository = new OrderRepository();
            return new OrderService(ordersRepository);
        }

        public static ReservationService CreateReservationService()
        {
            var reservationRepository = new ReservationRepository();
            return new ReservationService(reservationRepository);
        }

        public static RestaurantService CreateRestaurantService()
        {
            var restaurantRepository = new RestaurantRepository();
            return new RestaurantService(restaurantRepository);
        }

        public static TableService CreateTableService()
        {
            var tableRepository = new TableRepository();
            return new TableService(tableRepository);
        }

        public static DetailedEmployeeService CreateDetailedEmployeeService()
        {
            var detailedEmployeeRepository = new DetailedEmployeeRepository();
            return new DetailedEmployeeService(detailedEmployeeRepository);
        }

        public static DetailedReservationService CreateDetailedReservationService()
        {
            var detailedReservationRepository = new DetailedReservationRepository();
            return new DetailedReservationService(detailedReservationRepository);
        }
    }
}
