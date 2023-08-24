
using Microsoft.IdentityModel.Protocols;
using System.Configuration;

namespace RestaurantReservation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Hello World!");

            TimeOnly timeOnly = new TimeOnly(13, 23);
        
            Console.WriteLine(timeOnly.ToString());
            var stringTime = timeOnly.ToString();

            TimeOnly timeOnly2 = TimeOnly.Parse(stringTime);
            TimeOnly timeOnly3 = timeOnly2.AddHours(1);
            
            Console.WriteLine(timeOnly3.ToString());

        }
    }
}
