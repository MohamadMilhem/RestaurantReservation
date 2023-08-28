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


        public void GetCustomer(int id)
        {
            var result = _dbContext.Customers.ToList();

            foreach(var item in result) {
                Console.WriteLine(item.FirstName + " " + item.LastName + " " + item.CustomerId + " " + item.Reservations.Count);
            }

            
        }

        public IQueryable<Customer> Query()
        {
            return _dbContext.Set<Customer>().AsQueryable();
        }

    }
}
