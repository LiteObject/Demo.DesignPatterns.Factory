using Demo.DesignPatterns.Factory.Models;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace Demo.DesignPatterns.Factory
{
    public class VehicleFactory
    {
        // ToDo: Maybe static to avoid re-scanning? But, static collection might be a bad idea?
        private Dictionary<string, Type> _foundVehicleTypes = new Dictionary<string, Type>(StringComparer.OrdinalIgnoreCase);

        public VehicleFactory() 
        {
            // ScanForVehicle(Assembly.GetCallingAssembly());
        }
                
        public void ScanForVehicle(params Assembly[] assemblies)
        {
            var vehicleType = typeof(IVehicle);

            foreach (var assembly in assemblies) 
            {
                foreach (var type in assembly.GetTypes()) 
                {
                    if (!vehicleType.IsAssignableFrom(type) || type.IsAbstract || type.IsInterface)
                    {
                        continue;
                    }

                    _foundVehicleTypes.Add(type.Name, type);
                }
            }
        }

        public IVehicle Build(string typeName)
        {
            Type type;

            if (!_foundVehicleTypes.TryGetValue(typeName, out type))
            {
                throw new ArgumentException($"Failed to find vehicle type: {typeName}.");
            }

            return (IVehicle)Activator.CreateInstance(type);
        }
    }
}
