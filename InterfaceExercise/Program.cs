using System;
using System.Xml.Schema;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car()
            {
                NumberOfWheels = 4,
                Color = "Red",
                Model = "Model S",
                Make = "Tesla",
                HasTrunk = true,
                Name = "Tesla",
                Logo = "T",
                IsDomestic = true,
            };
            Truck truck = new Truck
            {
                NumberOfWheels = 6,
                Color = "Blue",
                Model = "F-150",
                Make = "Ford",
                TowingCapacity = 10000,
                Logo = "F",
                IsDomestic = true,
            };
            SUV suv = new SUV()
            {
                NumberOfWheels = 4,
                Color = "Red",
                Model = "RAV4",
                Make = "Toyota",
                Logo = "T",
                IsDomestic = false,
                NumberOfSeats = 5,
                hasSportMode = true,
            };

            car.DetailDisplay();
            truck.DetailDisplay();
            suv.DetailDisplay();
        }
    }
}