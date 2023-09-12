using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReservation.Db.ViewsModels.DetailedEmpolyees
{
    public class DetailedEmployee
    {

        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? Position { get; set; }
        public string? RestaurantName { get; set; }
        public string? Address { get; set; }
        public string? RestaurantPhoneNumber { get; set; }
        public TimeOnly OpenHour { get; set; }
        public TimeOnly CloseHour { get; set; }

        public static void ConfigureEntity(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DetailedEmployee>(entity =>
            {
                entity.HasNoKey();
                entity.ToView("DetailedEmployees");
            });
        }
    }
}
