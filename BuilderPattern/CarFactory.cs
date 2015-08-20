using System;
using System.Collections.Generic;
namespace BuilderPattern
{
    /// <summary>
    /// Director class
    /// </summary>
    public class CarFactory
    {
        private ICarBuilder CarBuilder;

        public CarFactory(ICarBuilder carBuilder)
        {
            CarBuilder = carBuilder;
        }

        public Car GetCar()
        {
            return CarBuilder.GetCar();
        }

        public void MakeCar()
        {
            CarBuilder.BuildBody();
            CarBuilder.BuildTransmission();
            CarBuilder.BuildEngine();
        }
    }
}
