using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            var lot = new CarLot();
            
           
            
            
            // instantation 1
            var johnsCar = new Car();
            johnsCar.Make = "Ferrari";
            johnsCar.Model = "SuperFast";
            johnsCar.Year = 2017;
            johnsCar.EngineNoise = "Loud";
            johnsCar.HonkNoise = "beep";
            johnsCar.IsDrivable = true;
            lot.Cars.Add(johnsCar);

            // instantation 2 (object initializer Syntax)
            var chrisCar = new Car()
            {
                    Year = 2017,
                    Make = "Ford",
                    Model = "Shelby",
                    EngineNoise ="Loud",
                    HonkNoise = "Wonk",
                    IsDrivable = true
            };
            // instantation 3 (Using constructor to allow parameter values to be placed inside properties)
            lot.Cars.Add(chrisCar);
            var autumnsCar = new Car(2002, "Ford", "EconoLine", "quiet", "toot", false);
            lot.Cars.Add(autumnsCar);

            // Call methods
            chrisCar.MakeEngineNoise(chrisCar.EngineNoise);
            johnsCar.MakeEngineNoise(johnsCar.EngineNoise);
            autumnsCar.MakeEngineNoise(autumnsCar.EngineNoise);

            


            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
            foreach(var car in lot.Cars)
            {
                Console.WriteLine($"Year; {car.Year} Make:{car.Make} Model: {car.Model} ");
            }
        }
    }
}
