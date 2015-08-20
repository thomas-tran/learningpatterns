using System;


namespace SingletonPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Earth e1 = Earth.Instance;
            Earth e2 = Earth.Instance;

            if (e1 == e2)
                Console.WriteLine("Only one earth available");

            Console.ReadLine();
        }


    }

    /// <summary>
    /// Thread safe without using locks - not quite lazy
    /// </summary>
    public sealed class Earth
    {
        private static readonly Earth instance = new Earth();

        static Earth() { }

        private Earth() { }

        public static Earth Instance
        {
            get
            {
                return instance;
            }
        }
    }
}
