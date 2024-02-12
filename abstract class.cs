using System;

namespace Question
{
    internal abstract class Vehicles
    {
        public Vehicles()
        {
            Console.WriteLine("Vehicle Constructor");
        }

        public void Start()
        {
            Console.WriteLine("Vehicle Started");
        }
    } // End of Vehicles class

    internal class Car : Vehicles
    {
        public Car()
        {
            Console.WriteLine("Car Constructor");
        }
    }

    class VehiclesTester
    {
        public static void TestOne()
        {
            Vehicles tester = new Car();
            tester.Start();
        }
    }
}
