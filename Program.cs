using System;
using System.Collections.Generic;

namespace refuel_garage
{
    class Program
    {
        static void Main(string[] args)
        {
            GasVehicle ram = new GasVehicle()
            {
                name = "Ram",
                fuelCapacity = 20,
                color = "red"
            };
            GasVehicle cessna = new GasVehicle()
            {
                name = "Cessna",
                fuelCapacity = 150,
                color = "white"
            };
            BatteryVehicle tesla = new BatteryVehicle()
            {
                name = "Tesla",
                batteryCapacity = 300,
                color = "silver"
            };
            BatteryVehicle zero = new BatteryVehicle()
            {
                name = "Zero",
                batteryCapacity = 80,
                color = "black"
            };

            List<GasVehicle> GasVehicles = new List<GasVehicle>();
            GasVehicles.Add(ram);
            GasVehicles.Add(cessna);
            
            List<BatteryVehicle> BatteryVehicles = new List<BatteryVehicle>();
            BatteryVehicles.Add(tesla);
            BatteryVehicles.Add(zero);

            GasStation hess = new GasStation();
            BatteryStation recharge = new BatteryStation();

            hess.Refuel(GasVehicles);
            recharge.Refuel(BatteryVehicles);

        }
    }
}
