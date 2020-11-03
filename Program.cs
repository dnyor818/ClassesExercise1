using System;

namespace ClassesExercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            var myCar = new Car();
            myCar.Make = "Ford";
            myCar.Model = "Mustang";
            myCar.Year = 1985;

            Console.WriteLine($"{myCar.Make} {myCar.Model} {myCar.Year}");
        }
    }
}
