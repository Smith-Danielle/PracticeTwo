using System;
namespace PracticeTwo
{
    public class Car
    {
        public Car()
        {
        }
        public Car(string make, string model, int year)
        {
            Make = make;
            Model = model;
            Year = year;
        }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public void StateCar()
        {
            Console.WriteLine($"Hello, Im a {Make} {Model} from {Year}.");
        }
        public void CarAge(int x)
        {
            Console.WriteLine($"This car is {x - Year} years old.");
        }

    }


}
