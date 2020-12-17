using System;

namespace FourthTask
{
    public class AnyOtherCar : IVehicle
    {
        public static void Drive()
        {
            Console.WriteLine("Driving to the destination");
        }

        public static void Park()
        {
            Console.WriteLine("Parking on a single parking spot");
        }

        public AnyOtherCar ()
        {
            new AnyOtherCar();
        }
    }
}