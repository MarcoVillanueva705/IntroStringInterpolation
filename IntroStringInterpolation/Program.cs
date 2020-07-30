using System;

namespace IntroStringInterpolation
{
    class Program
    {
        static void Main(string[] args)
        {
            //var point = new { x = 1, y = 2 };
            //concat exercise
            //each time we concatenate a string into another
            //it creates a new string object
            //If done in a loop, it would provide a lot of
            //unnecessary work for the garbage collector

            //Console.WriteLine("x" + point.x + "y" + point.y);

            //string interpolation doesn't have the same memory issues as
            //string concatenation
            //best way to get expressions into our strings
            //It's optimized and provides clean syntax

            //working with formatters
            //to limit the amt of decimals in a float
            //use N1 after semicolon in var obj
            var point = new {x = 1.1234, y = 2.1254 };

            //Console.WriteLine($" x{point.x} y{point.y:N1}");
            //adding margin or space between margin or string literal
            //place number value in front of colon to indicate the amt
            Console.WriteLine($" x{point.x} y{point.y,10:N1}");

        }
    }
}
