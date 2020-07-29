using System;

namespace IntroStringInterpolation
{
    class Program
    {
        static void Main(string[] args)
        {
            var point = new { x = 1, y = 2 };
            //concat exercise
            //each time we concatenate a string into another
            //it creates a new string object
            //If done in a loop, it would provide a lot of
            //unnecessary work for the garbage collector

            Console.WriteLine("x" + point.x + "y" + point.y);

            //string interpolation doesn't have the same memory issues as
            //string concatenation
            //best way to get expressions into our strings
            //It's optimized and provides clean syntax
            Console.WriteLine($" x{point.x} y{point.y}"); 
        }
    }
}
