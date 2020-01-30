using System;

namespace Lab3A
{
    class Program
    {
        static void Main(string[] args)
        {
            // Random number generator for the coordinates of positive quarter of a circle. Think of a graph.
            Random rnd = new Random();

            Console.Write("How many iterations?");

            // Converting the input to int and setting up the Iterations method
            long input;
            long.TryParse(Console.ReadLine(), out input);
            long iter = input;
            long count;
            long i;

            // Iteration Method takes in a random and the iterations and outputs a tuple of iterations and count
            // Count is the number of coordinates inside our radius of 1
            (i, count) = Iterations(rnd, iter);

            // Displays the Results of Iterations
            Console.WriteLine($"Total Coordinates inside of Radius: {count}");
            Console.WriteLine($"Total Iterations: {i}");


            // Final Calculations
            {
                decimal function = Convert.ToDecimal(count) / Convert.ToDecimal(i);
                Console.WriteLine($"Overlaps / Iterations: {function}");

                decimal product = function * Convert.ToDecimal(4);
                Console.WriteLine($"Multiplied by 4: {product}");

                decimal answer = Math.Abs(product - Convert.ToDecimal(Math.PI));
                Console.WriteLine($"Difference is: {answer}");
            }



        }

        private static (long, long) Iterations(Random rnd, long iter)
        {
            long i;
            long count = 0;

            // Makes a loop so the iterations count up
            for (i = 0; i < iter; ++i)
            {
                // Calls both Methods to allow the output of the RandomNumber to input into Hypotenuse
                var (x, y) = RandomNumber(rnd);
                double hyp = Hypotenuse(x, y);
                
                // Counts number of Hypotenuses that are <= 1
                if (hyp <= 1)
                {
                    ++(count);
                }

            }

            return (i, count);
        }

        private static double Hypotenuse(double x, double y)
        {
            // Calculates the value of the Hypotenuse given the (x, y) coordinates
            double hyp;

            hyp = Math.Sqrt((x * x) + (y * y));
            
            return hyp;
        }

        private static (double, double) RandomNumber(Random rnd)
        {
            // Generates random (x, y) coordinates

            double x = rnd.NextDouble();  // creates a number between 0 and 1
            double y = rnd.NextDouble();

            return (x, y);

        }

    }
}
