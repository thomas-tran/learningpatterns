using System;

namespace BuilderPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ICarBuilder carBuilder = null;
            CarFactory carFactory = null;

            Console.WriteLine("Ready to make a car!");
            Console.WriteLine("Enter 'S' for Sedan and 'C' for Coupe");
            while (true)
            {
                string input = Console.ReadLine();
                

                switch (input)
                {
                    case "S":
                        Console.WriteLine("Sedan car is selected");
                        carBuilder = new SedanCarBuilder();

                        break;
                    case "C":
                        Console.WriteLine("Coupe car is selected");
                        carBuilder = new CoupeCarBuilder();
                        break;
                    default:
                        Environment.Exit(0);
                        break;
                }

                if (carBuilder != null)
                {
                    Console.WriteLine("Please wait while we are making your car...");
                    carFactory = new CarFactory(carBuilder);
                    carFactory.MakeCar();
                    Console.WriteLine("Your car is ready");
                    Console.WriteLine(carFactory.GetCar().ToString());
                    
                }

                Console.ReadLine();
            }

         

        }
    }
}
