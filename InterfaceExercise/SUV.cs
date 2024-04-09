using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class SUV : IVehicle, ICompany
    {
        public int NumberOfWheels { get; set; }
        public string Color { get; set; }
        public string Model { get; set; }
        public string Make { get; set; }
        public string Logo { get; set; }
        public bool IsDomestic { get; set; }
        public int NumberOfSeats { get; set; }
        public bool hasSportMode { get; set; }

        public void DetailDisplay () 
        {
            Console.WriteLine($"SUV - {Make} {Model}: {Color}, Wheels: {NumberOfWheels}, Seats: {NumberOfSeats}, Has Sport Mode: {hasSportMode}, Domestic: {IsDomestic}, Logo: {Logo}");  
        }
    }
}
