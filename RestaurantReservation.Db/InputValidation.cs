using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReservation.Db
{
    public class InputValidation
    {

        public static bool ValidateMenuOption(string? option)
        {
            var canBeParsed = int.TryParse(option, out _);

            if (!canBeParsed) 
            {
                return false;
            }

            return Enum.IsDefined(typeof(MenuChoice), int.Parse(option));
        }

        public static bool ValidateId(string? id)
        {
            var canBeParsed = int.TryParse(id, out _);
            return canBeParsed;
        }

        public static bool ValidatePartySize(string? id)
        {
            var canBeParsed = int.TryParse(id, out _);

            if (!canBeParsed)
            {
                return false;
            }
            return Enum.IsDefined(typeof(PartySize), int.Parse(id));
        }
    }
}
