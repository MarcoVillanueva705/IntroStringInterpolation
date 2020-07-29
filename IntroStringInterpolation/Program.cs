using System;

namespace IntroStringInterpolation
{
    class Program
    {
        static void Main(string[] args)
        {
            var point = new { x = 1, y = 2 };
            //concat exercise

            //string interpolation doesn't have the same memory issues as
            //string concatenation
            Console.WriteLine($" x{point.x} y{point.y}"); 
        }
    }
}
