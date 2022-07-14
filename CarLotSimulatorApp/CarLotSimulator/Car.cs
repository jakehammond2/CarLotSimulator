using System;
namespace CarLotSimulator
{
    public class Car
    {
        public Car()
        {
    
        }

        public Car(string make, string model)
        {
            Make = make;
            Model = model; 
        }

        //Properties
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDriveable { get; set; }

        // Methods MakeEngineNoise() MakeHonkNoise()

        public void MakeEngineNoise()
        {
            

            Console.WriteLine($"The Engine Noise: {EngineNoise}");

        }


        public void MakeHonkNoise()
        {

            
            
                Console.WriteLine($"The Honk Noise: {HonkNoise}");
            
            
        }

    }
}

