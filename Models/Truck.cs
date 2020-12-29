using System;

namespace Demo.DesignPatterns.Factory.Models
{
    internal class Truck : IVehicle
    {
        public int Id { get; set; }
        public string Name { get; set; } = nameof(Truck);
        public string Year { get; set; } = "1900";
        public string Make { get; set; } = "Not Available";
        public string Model { get; set; } = "Not Available";

        public int PassengerCapacity { get; set; } = 2;

        public string GetInfo()
        {
            return $"Name: {this.Name}, Type: {typeof(Truck)}, Year: {this.Year}, Make: {this.Make}, Model: {this.Model}";
        }
    }
}
