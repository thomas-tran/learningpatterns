namespace BuilderPattern
{
    public interface ICarBuilder
    {
        void BuildBody();

        void BuildTransmission();

        void BuildEngine();

        void PaintColor();

        Car GetCar();
    }
}
