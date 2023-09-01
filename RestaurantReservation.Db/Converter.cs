using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReservation.Db
{
    public static class Converter
    {
        public static MenuChoice FromNumericStringToMenuChoice(string choice)
        {
            int value = int.Parse(choice);
            return (MenuChoice)(value);
        }

        public static PartySize FromNumericStringToPartySize(string size)
        {
            int value = int.Parse(size);
            return (PartySize)(value);
        }
    }
}
