using System;
using System.Collections.Generic;

namespace refuel_garage {
    public class BatteryStation : IRefuel<BatteryVehicle>
    {
        public int Capacity { get; set; } = 5;

        public void Refuel(List<BatteryVehicle> BatteryVehicles)
        {
            foreach (var item in BatteryVehicles)
            {
                Console.WriteLine($"The {item.color} {item.name} has been recharged with {item.batteryCapacity} kilowatts of electricity.");
            }
            
        }
    }

    public class BatteryVehicle
    {
        public string name {get; set;}

        public int batteryCapacity {get; set;}

        public string color {get; set;}
    }
}