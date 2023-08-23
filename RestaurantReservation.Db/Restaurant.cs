using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReservation.Db
{
    public class Restaurant
    {

        public int RestaurantId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public int OpeningHours { get; set; }

        public TimeOnly OpenHour { get; set; }
        public TimeOnly CloseHour { get; set; }
    }
}
