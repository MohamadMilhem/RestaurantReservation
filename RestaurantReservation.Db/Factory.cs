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

        public static CustomerService CreateCustomerService(ICustomerRepository customerRepository)
        {
            return new CustomerService(customerRepository);
        }

        public static ICustomerRepository CreateCustomerRepository()
        {
            return new CustomerRepository();
        }

        public static EmployeeService CreateEmployeeService(IEmployeeRepository employeeRepository)
        {
            return new EmployeeService(employeeRepository);
        }

        public static IEmployeeRepository CreateEmployeeRepository()
        {
            return new EmployeeRepository();
        }

        public static MenuItemService CreateMenuItemService(IMenuItemRepository menuItemRepository) 
        {
            return new MenuItemService(menuItemRepository);
        }

        public static IMenuItemRepository CreateMenuItemRepository()
        {
            return new MenuItemRepository();
        }

        public static OrderItemService CreateOrderItemService(IOrderItemRepository orderItemRepository)
        {
            return new OrderItemService(orderItemRepository);
        }

        public static IOrderItemRepository CreateOrderItemRepository()
        {
            return new OrderItemRepository();
        }
        public static OrderService CreateOrderService(IOrderRepository orderRepository)
        {
            return new OrderService(orderRepository);
        }

        public static IOrderRepository CreateOrderRepository()
        {
            return new OrderRepository();
        }

        public static ReservationService CreateReservationService(IReservationRepository reservationRepository)
        {
            return new ReservationService(reservationRepository);
        }

        public static IReservationRepository CreateReservationRepository()
        {
            return new ReservationRepository();
        }

        public static RestaurantService CreateRestaurantService(IRestaurantRepository restaurantRepository)
        {
            return new RestaurantService(restaurantRepository);
        }

        public static IRestaurantRepository CreateRestaurantRepository()
        {
            return new RestaurantRepository();
        }

        public static TableService CreateTableService(ITableRepository tableRepository)
        {
            return new TableService(tableRepository);
        }

        public static ITableRepository CreateTableRepository()
        {
            return new TableRepository();
        }

        public static DetailedEmployeeService CreateDetailedEmployeeService(IDetailedEmployeeRepository detailedEmployeeRepository)
        {
            return new DetailedEmployeeService(detailedEmployeeRepository);
        }

        public static IDetailedEmployeeRepository CreateDetailedEmployeeRepository()
        {
            return new DetailedEmployeeRepository();
        }

        public static DetailedReservationService CreateDetailedReservationService(IDetailedReservationRepository detailedReservationRepository)
        {
            return new DetailedReservationService(detailedReservationRepository);
        }

        public static IDetailedReservationRepository CreateDetailedReservationRepository()
        {
            return new DetailedReservationRepository();
        }
    }
}
