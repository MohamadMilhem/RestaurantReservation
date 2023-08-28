using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using RestaurantReservation.Db.DataModels.Reservations;


namespace RestaurantReservation.Db.DataModels.Customers
{
    public class CustomerService
    {

        private readonly CustomerRepository _customerRepository;
        public CustomerService(CustomerRepository customerRepository) 
        {
            _customerRepository = customerRepository;
        }

        //public List<Reservation> GetReservations(int id)
        //{
        //    return _customerRepository.GetCustomer(id).Reservations;
        //}



    }
}
