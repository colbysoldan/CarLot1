using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            var car1 = new Car();
            car1.Make = "Hyundai";
            car1.Model = "Sonata";
            car1.Year = 2003;
            car1.Color = "maroon";

            var car2 = new Car();
            car2.Make = "Ram";
            car2.Model = "1500";
            car2.Year = 2018;
            car2.Color = "Hydro Blue";

            Console.WriteLine($"I have a {car1.Year} {car1.Color} {car1.Make} {car1.Model}.");
            Console.WriteLine($"My husband drives a {car2.Year} {car2.Color} {car2.Make} {car2.Model}.");
        }
    }
}

