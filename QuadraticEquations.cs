using System;

namespace EX2Apt4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This a rough calculator for quadratic equations.");
            Console.WriteLine("Please note: This is an imperfect calculator and many solutions will not compute properly.");
            Console.WriteLine("The formula formula for a quadratic formula is ax^2 + bx + c");
            
            //Value A
            Console.WriteLine("Give value for a");
            var a1 = Console.ReadLine();
            double a;
            double.TryParse(a1, out a);

            //Value B
            Console.WriteLine("Give value for b");
            var b1 = Console.ReadLine();
            double b;
            double.TryParse(b1, out b);

            //Value C
            Console.WriteLine("Give value for c");
            var c1 = Console.ReadLine();
            double c;
            double.TryParse(c1, out c);

            //Calulation

            var x = (((-b) + (Math.Sqrt((b * b)-(4 * a * c)))) / (2 * a));

            var x2 = (((-b) + (Math.Sqrt((b * b) - (4 * a * c)))) / (2 * a));

            Console.WriteLine($"x equals ({x},{x2})");

        }
    }
}
