using RestaurantReservation.Db.DomainModels.Reservations;


namespace RestaurantReservation.Db.DomainModels.Customers
{
    public class CustomerService : ICustomerService
    {

        private readonly ICustomerRepository _customerRepository;
        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public IEnumerable<Reservation> GetReservationsById(int id)
        {
            var customer = _customerRepository.GetByIdWithReservations(id);

            if (customer == null)
            {
                return Enumerable.Empty<Reservation>();
            }

            return customer.Reservations;
        }

        public IEnumerable<Customer> GetCustomersWithPartySizeGreaterThan(PartySize partySize)
        {
            return _customerRepository.GetCustomersWithPartySizeGreaterThan(partySize);
        }
    }
}
