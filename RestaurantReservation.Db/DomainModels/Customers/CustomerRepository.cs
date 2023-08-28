using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReservation.Db.DomainModels.Customers
{
    public class CustomerRepository
    {
        private RestaurantReservationDbContext _dbContext;

        public CustomerRepository()
        {
            _dbContext = new RestaurantReservationDbContext();
        }

        public int Create(Customer customer)
        {
            _dbContext.Customers.Add(customer);
            return _dbContext.SaveChanges();
        }

        public int Update(Customer customer)
        {
            _dbContext.Customers.Update(customer);
            return _dbContext.SaveChanges();
        }

        public int Delete(Customer customer)
        {
            var result = _dbContext.Customers.Find(customer);
            
            if (result != null)
            {
                _dbContext.Customers.Remove(result);
            }
            return _dbContext.SaveChanges();
        }

        public Customer GetByIdWithReservations(int id)
        {
            return _dbContext.Customers.Include(customer => customer.Reservations).SingleOrDefault(customer => customer.CustomerId == id);
        }

        public IEnumerable<Customer> GetCustomersWithPartySizeGreaterThan(PartySize partySize)
        {
            return _dbContext.Customers.Include(customer => customer.Reservations)
                    .Where(customer => customer.Reservations.Any(res => res.PartySize > partySize));
        }

    }
}
