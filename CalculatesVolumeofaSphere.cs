using System;

namespace EX2Apt2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Starting statements

            Console.WriteLine("This is a calculator for the volume of a hemisphere");
        A: Console.WriteLine("Please type the radius.");

            //declares variables

            var input = Console.ReadLine();
            double radius;

            //converts to double

            while (!double.TryParse(input, out radius))
            {
                Console.WriteLine("(¬_¬) Not a valid number, try again.");

                input = Console.ReadLine();
            }

            //checks if radius is negative

            do
            {

                if (radius < 0)
                {
                    Console.WriteLine("Number cannot be negative");

                    goto A;

                }

            } while (radius < 0);

            //Checks if zero

            do
            {
                if (radius == 0)
                {
                    Console.WriteLine("Number cannot be 0");

                    goto A;
                }

            } while (radius == 0);

            //calculates volume

            var volume = (((4 / 3) * Math.PI * (radius * radius * radius)) / 2);

            Console.WriteLine($"Volume = {volume}.");
        }
    }
}
