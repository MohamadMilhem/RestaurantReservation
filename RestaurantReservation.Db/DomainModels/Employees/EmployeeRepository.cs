using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReservation.Db.DomainModels.Employees
{
    public class EmployeeRepository
    {
        private RestaurantReservationDbContext _dbContext;

        public EmployeeRepository()
        {
            _dbContext = new RestaurantReservationDbContext();
        }

        public int Create(Employee employee)
        {
            _dbContext.Employees.Add(employee);
            return _dbContext.SaveChanges();
        }

        public int Update(Employee employee)
        {
            _dbContext.Employees.Update(employee);
            return _dbContext.SaveChanges();
        }

        public int Delete(Employee employee)
        {
            var result = _dbContext.Employees.Find(employee);
            if (result != null)
            {
                _dbContext.Employees.Remove(result);
            }
            return _dbContext.SaveChanges();
        }

        public Employee GetWithOrders(int id)
        {
            return _dbContext.Employees.Include(emp => emp.Orders)
                    .SingleOrDefault(emp => emp.EmployeeId == id);
        }


        public IEnumerable<Employee> GetAllEmployeesWithTitle(string title)
        {
            return _dbContext.Employees.Where(employee => employee.Position.Equals(title));
        }

      

    }
}
