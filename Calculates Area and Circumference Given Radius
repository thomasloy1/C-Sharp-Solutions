using System;

namespace EX_2A_Calculating_Area_and_Circumference
{
    class Program
    {
        static void Main(string[] args)
        {
            //Starting statements

           Console.WriteLine("This is a calculator for the Area and Circumference of a circle.");
        A: Console.WriteLine("Please type the radius.");

            //declares variables

            var input = Console.ReadLine();
            double radius;

            //converts to double

            radius = convertToDouble(ref input);

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

            //calculates area

            var area = (Math.PI * (radius * radius));

            //calculates circumference

            var circum = (2 * Math.PI * radius);

            //displays results

            Console.WriteLine("The Circumference is, " + circum);
            Console.WriteLine("The Area is, " + area);

        }

        private static double convertToDouble(ref string input)
        {
            double radius;
            while (!double.TryParse(input, out radius))
            {
                Console.WriteLine("(¬_¬) Not a valid number, try again.");

                input = Console.ReadLine();
            }

            return radius;
        }
    }
}
