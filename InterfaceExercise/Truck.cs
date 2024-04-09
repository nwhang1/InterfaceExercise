using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Truck : IVehicle, ICompany
    {
        public int NumberOfWheels { get; set; }
        public string Color { get; set; }
        public string Model { get; set; }
        public string Make {  get; set; }
        public int TowingCapacity { get; set; }
        public string Logo { get; set; }
        public bool IsDomestic { get; set; }
        public void DetailDisplay()
        {
            Console.WriteLine($"Truck - {Make} {Model}, {Color}, Wheels: {NumberOfWheels}, Towing Capacity: {TowingCapacity}lbs, Domestic: {IsDomestic}, Logo: {Logo}");
        }
    }
}
