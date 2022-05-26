using System;

namespace OperatorExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;
            int quotient = a / b;
            int remainder = a % b;

            Console.WriteLine($"{a} + {b} = {a + b}");
            Console.WriteLine($"{a} - {b} = {a - b}");
            Console.WriteLine($"{a} x {b} = {a * b}");
            Console.WriteLine($"{a} / {b} = {quotient} (remainder of {remainder})");

            Console.WriteLine("We are going to find the area of a circle. Enter a number for the radius for our circle.");
            var radius = double.Parse(Console.ReadLine());
            var area = AreaOfCircle(radius);
            Console.WriteLine($"A circle with a radius of {radius} units has an area of {area} square units!");
        }
    
        public static double AreaOfCircle(double r)
        {
            return Math.PI * r * r;
        }
    
    
    }
}
