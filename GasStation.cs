using System;
using System.Collections.Generic;

namespace refuel_garage {
    public class GasStation : IRefuel<GasVehicle>
    {
        public int Capacity { get; set; } = 10;

        public void Refuel(List<GasVehicle> GasVehicles)
        {
            foreach (var item in GasVehicles)
            {
                Console.WriteLine($"The {item.color} {item.name} has been refueled with {item.fuelCapacity} gallons of gas.");
            }
        }
    }

    public class GasVehicle
    {
        public string name {get; set;}

        public int fuelCapacity {get; set;}

        public string color {get; set;}
    }
}
   