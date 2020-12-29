namespace Demo.DesignPatterns.Factory.Models
{
    public interface IVehicle
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Year { get; set; }

        public string Make { get; set; }

        public string Model { get; set; }

        public int PassengerCapacity { get; set; }

        public string GetInfo();
    }
}
