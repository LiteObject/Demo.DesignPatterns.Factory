using System;
using System.Reflection;

namespace Demo.DesignPatterns.Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            var factory = new VehicleFactory();
            factory.ScanForVehicle(Assembly.GetExecutingAssembly());

            var myCar = factory.Build("Sedan");
            Console.WriteLine(myCar.GetInfo());
        }
    }
}
