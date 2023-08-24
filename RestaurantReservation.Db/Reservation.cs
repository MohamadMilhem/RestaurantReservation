using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReservation.Db
{
    public class Reservation
    {
        public int ReservationId { get; set; } 
        public Customer Customer { get; set; }
        public Restaurant Restaurant { get; set; }
        public int TableId { get; set; }
        public Table Table { get; set; }
        public DateTime ReservationDate { get; set; }
        public PartySize PartySize { get; set; }
    }
}
