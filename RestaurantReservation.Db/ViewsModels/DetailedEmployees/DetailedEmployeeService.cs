using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReservation.Db.ViewsModels.DetailedEmpolyees
{
    public class DetailedEmployeeService : IDetailedEmployeeService
    {

        private readonly IDetailedEmployeeRepository _detailedEmployeeRepository;

        public DetailedEmployeeService(IDetailedEmployeeRepository detailedEmployeeRepository)
        {
            _detailedEmployeeRepository = detailedEmployeeRepository;
        }

        public DetailedEmployee GetDetailedEmployee(int id)
        {
            var employee = _detailedEmployeeRepository.GetDetailedEmployeeById(id);
            return employee;
        }
    }
}
