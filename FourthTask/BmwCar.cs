using System;
using System.Diagnostics;

namespace FourthTask
{
    public class BmwCar : IVehicle
    {
        public static void Drive()
        {
            Console.WriteLine("Driving into the bus stop");
        }

        public static void Park()
        {
            Console.WriteLine("Parking on as many parking sports as possible at the same time");
        }

        public BmwCar()
        {
            new BmwCar();
        }
    }
}