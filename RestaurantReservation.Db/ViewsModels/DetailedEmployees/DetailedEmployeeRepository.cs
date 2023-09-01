using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReservation.Db.ViewsModels.DetailedEmpolyees
{
    public class DetailedEmployeeRepository
    {
        private readonly RestaurantReservationDbContext _dbContext;

        public DetailedEmployeeRepository()
        {
            _dbContext = new RestaurantReservationDbContext();
        }

        public DetailedEmployee GetDetailedEmployeeById(int Id)
        {
            return _dbContext.DetailedEmployees.SingleOrDefault(emp => emp.EmployeeId == Id);
        }


    }
}
