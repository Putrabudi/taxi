using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi
{
    static class Program
    {
        private static void Main(string[] args)
        {
            Taxi taxi = new Taxi ();
            taxi.DriverName = "Putera";
            taxi.OnDuty = true;
            taxi.NumPassenger = 4;
            taxi.TaxiInfo();
            Console.WriteLine();
            taxi.PickupPassenger();
            taxi.DropOffPassenger();
            Console.ReadKey();
        }
    }
}