using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReservation.Db
{
    public class Order
    {
        public int OrderId { get; set; } 
        public Reservation Reservation { get; set; }
        public Employee Employee { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; set; }    

    }
}
