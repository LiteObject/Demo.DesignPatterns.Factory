using System;

namespace Demo.DesignPatterns.Factory.Models
{
    internal class Sedan : IVehicle
    {
        public int Id { get; set; }
        public string Name { get; set; } = nameof(Sedan);
        public string Year { get; set; } = "1900";
        public string Make { get; set; } = "Not Available";
        public string Model { get; set; } = "Not Available";

        public int PassengerCapacity { get; set; } = 5;

        public string GetInfo()
        {
            return $"Name: {this.Name}, Type: {typeof(Sedan)}, Year: {this.Year}, Make: {this.Make}, Model: {this.Model}";
        }
    }
}
