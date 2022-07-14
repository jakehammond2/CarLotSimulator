using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            var thisIsCarLot = new CarLot();


            var Car1 = new Car();
            var Car2 = new Car();
            var Car3 = new Car();


            Car1.Year = 1998;
            Car1.Make = "Ford";
            Car1.Model = "Bronco";
            Car1.EngineNoise = "loud";
            Car1.MakeEngineNoise();
            Car1.HonkNoise = "loud";
            Car1.MakeHonkNoise();
            Car1.IsDriveable = true; 

            Car2.Year = 2017;
            Car2.Make = "Honda";
            Car2.Model = "Accord";
            Car2.EngineNoise = "quiet";
            Car2.MakeEngineNoise();
            Car2.HonkNoise = "quiet";
            Car2.MakeHonkNoise();
            Car2.IsDriveable = true;

            Car3.Year = 2020;
            Car3.Make = "Jeep";
            Car3.Model = "Grand Cherokee";
            Car3.EngineNoise = "loud";
            Car3.MakeEngineNoise();
            Car3.HonkNoise = "quiet";
            Car3.MakeHonkNoise();
            Car3.IsDriveable = true;

            Console.WriteLine(Car3.Make = "Jeep");

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            var Car4 = new Car()
            {
                Model = "Honda",
                Year = 2004,
                Make = "Civic",
                EngineNoise = "loud",
                HonkNoise = "loud",
                IsDriveable = true
            };


            var Car5 = new Car("Mercedes", "C Class");




            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

            thisIsCarLot.ListOfCars.Add(Car1);
            thisIsCarLot.ListOfCars.Add(Car2);
            thisIsCarLot.ListOfCars.Add(Car3);



            foreach (var car in thisIsCarLot.ListOfCars)
            {
                Console.WriteLine(car.Year);
                Console.WriteLine(car.Make);
                Console.WriteLine(car.Model);
            }


        }
    }
}
