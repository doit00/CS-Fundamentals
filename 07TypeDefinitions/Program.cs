using System;

namespace Demos
{
    class Program
    {
        static void Main(string[] args)
        {

            Car ferrari = new Car("Red") { Make = "Ferrari"};
            Car fiat = new Car();
            Console.WriteLine(ferrari.Color);

            CarsArray();

        }

        private static void CarsArray()
        {
            Car[] cars = { new Car() { Make = "Ferrari" }
                          ,new Car() { Make = "Fiat" }
                          ,new Car() { Make = "Fiat" }
                          };

            foreach (var c in cars)
            {
                Console.WriteLine(c.GetHashCode());
            }
        }
    }
    

    class Car
    {
        public string Make;
        public string Model;
        public string Color { get; }

        public Car():this("")
        {

        }
        public Car(string color)
        {
            this.Color = color;
        }


    }


}
