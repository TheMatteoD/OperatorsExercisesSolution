using System;

namespace OperatorsExercises
{
    internal class Program
    {
        public static double AreaOfCircle(double r)
        {
            return Math.PI * (r * r);
        }
        static void Main(string[] args)
        {

            // Exercise 1
            var a = 17;
            var b = 4;


            var div = a / b;
            var remainder = a % b;

            Console.WriteLine($"{a} divided by {b} = {div} with remainder {remainder}");

            //Exercise 2
            Console.WriteLine("What is the radius of your circle:");
            var r = double.Parse(Console.ReadLine());
            var areaOfCircle = AreaOfCircle(r);

            Console.WriteLine($"A circle with a radius of {r} has an area of {areaOfCircle}");


        }
    }
}
