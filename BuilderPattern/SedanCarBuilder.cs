
namespace BuilderPattern
{
    /// <summary>
    /// Concrete builder class
    /// </summary>
    public class SedanCarBuilder : ICarBuilder
    {
        private Car Car;

        public SedanCarBuilder()
        {
           Car = new Car("Sedan");
        }

        public void BuildBody()
        {
            Car.AddBody("4 doors, 5 seats");
        }

        public void BuildTransmission()
        {
            Car.AddTransmission("Automatic");
        }

        public void BuildEngine()
        {
            Car.AddEngine("4 cyl, 1.5 L");
        }

        public void PaintColor()
        {
            Car.PaintColor("Silver");
        }

        public Car GetCar()
        {
            return Car;
        }
    }
}
