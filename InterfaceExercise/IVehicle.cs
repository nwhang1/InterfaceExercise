using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal interface IVehicle
    {
        int NumberOfWheels { get; set; }
        string Color { get; set; }
        string Model { get; set; }
        string Make { get; set; }

        void DetailDisplay();
    }
}
