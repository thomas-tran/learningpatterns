
namespace BuilderPattern
{
    /// <summary>
    /// Concrete builder class
    /// </summary>
    public class CoupeCarBuilder : ICarBuilder
    {
        private Car Car;

        public CoupeCarBuilder()
        {
           Car = new Car("Coupe");
        }

        public void BuildBody()
        {
            Car.AddBody("2 doors, 4 seats");
        }

        public void BuildTransmission()
        {
            Car.AddTransmission("Automatic");
        }

        public void BuildEngine()
        {
            Car.AddEngine("4 cyl, 2.0 L");
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
