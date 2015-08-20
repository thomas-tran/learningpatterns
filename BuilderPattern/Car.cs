using System;

namespace BuilderPattern
{
    /// <summary>
    /// Product class
    /// </summary>
    public class Car : ICar
    {
        public string Name { get; private set; }

        public string Body { get; private set; }
        public string Transmission { get; private set; }
        public string Engine { get; private set; }
        public string Color { get; private set; }

        public Car(string name) {
            Name = name;
        }


        public void AddBody(string body)
        {
            Body = body;
        }

        public void AddTransmission(string transmission)
        {
            Transmission = transmission;
        }

        public void AddEngine(string engine)
        {
            Engine = engine;
        }

        public void PaintColor(string color)
        {
            Color = color;
        }

        public override string ToString()
        {
            return string.Format("Name: {0}\r\nBody: {1}\r\nTransmission: {2}\r\nEngine: {3}",Name,Body,Transmission,Engine);
        }

       
    }
}