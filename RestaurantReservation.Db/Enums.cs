using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReservation.Db
{
    public enum PartySize
    {
        Small = 0,
        Medium = 1,
        Large = 2
    }

    public enum MenuChoice
    {
        ListManagers = 1,
        GetRreservations = 2,
        GetOrdersWithMenuItems = 3,
        CalculateTotalRevenue = 4,
        GetOrderItems = 5,
        GetAverageAmount = 6,
        GetAllCustomersWithPartySizeGreater = 7,
        GetDetailedReservation = 8,
        GetDetailedEmployeeInfo = 9,
        Exit = 10,
    }

}
