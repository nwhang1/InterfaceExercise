using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Car : IVehicle, ICompany
    {
        public int NumberOfWheels { get; set; }
        public string Color { get; set; }
        public string Model {  get; set; }
        public string Make { get; set; }
        public string Name { get; set; }
        public bool HasTrunk { get; set; }
        public bool IsDomestic { get; set; }
        public string Logo { get; set; }

        public void DetailDisplay()
        {
            Console.WriteLine($"Car: {Name} {Model} : {Color}, Wheels: {NumberOfWheels}, Domestic: {IsDomestic}, Logo: {Logo}");
        }

    }
}
