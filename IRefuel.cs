using System.Collections.Generic;

namespace refuel_garage {
    public interface IRefuel<T>
    {
        int Capacity {get; set;}
        void Refuel(List<T> vehicles);
    }
}