using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.DesignPatterns.Factory.Models
{
    internal class SUV : IVehicle
    {
        public int Id { get; set; } = 0;
        public string Name { get; set; } = nameof(SUV);
        public string Year { get; set; } = "1900";
        public string Make { get; set; } = "Not Available";
        public string Model { get; set; } = "Not Available";

        public int PassengerCapacity { get; set; } = 8;

        public string GetInfo()
        {
            return $"Name: {this.Name}, Type: {typeof(SUV)}, Year: {this.Year}, Make: {this.Make}, Model: {this.Model}";
        }
    }
}
