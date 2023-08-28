using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using RestaurantReservation.Db.DomainModels.Reservations;


namespace RestaurantReservation.Db.DomainModels.Customers
{
    public class CustomerService
    {

        private readonly CustomerRepository _customerRepository;
        public CustomerService(CustomerRepository customerRepository) 
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
