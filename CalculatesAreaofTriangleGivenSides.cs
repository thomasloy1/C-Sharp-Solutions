using System;

namespace EX2Apt3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Starting statements

            Console.WriteLine("This is a calculator that calculates the area of triangle given the length of the sides");

            //Side 1

        A:  Console.WriteLine("Type side 1");

            var inputA = Console.ReadLine();

            //converts to double

            double sideA;

            while (!double.TryParse(inputA, out sideA))
            {
                Console.WriteLine("(¬_¬) Not a valid number, try again. Type Side 1");

                inputA = Console.ReadLine();
            }

            //checks if radius is negative

            do
            {

                if (sideA < 0)
                {
                    Console.WriteLine("Number cannot be negative");

                    goto A;

                }

            } while (sideA < 0);

            //Checks if zero

            do
            {
                if (sideA == 0)
                {
                    Console.WriteLine("Number cannot be 0");

                    goto A;
                }

            } while (sideA == 0);

            //Side 2

        B:  Console.WriteLine("Type side 2");
            var inputB = Console.ReadLine();

            double sideB;

            while (!double.TryParse(inputB, out sideB))
            {
                Console.WriteLine("(¬_¬) Not a valid number, try again. Type side 2.");

                inputB = Console.ReadLine();
            }

            //checks if radius is negative

            do
            {

                if (sideB < 0)
                {
                    Console.WriteLine("Number cannot be negative");

                    goto B;

                }

            } while (sideB < 0);

            //Checks if zero

            do
            {
                if (sideB == 0)
                {
                    Console.WriteLine("Number cannot be 0");

                    goto B;
                }

            } while (sideB == 0);

            //Side 3

        C:    Console.WriteLine("Type side 3");
            var inputC = Console.ReadLine();

            double sideC;

            while (!double.TryParse(inputC, out sideC))
            {
                Console.WriteLine("(¬_¬) Not a valid number, try again. Type Side 3.");

                inputC = Console.ReadLine();
            }

            //checks if radius is negative

            do
            {

                if (sideC < 0)
                {
                    Console.WriteLine("Number cannot be negative");

                    goto C;

                }

            } while (sideC < 0);

            //Checks if zero

            do
            {
                if (sideC == 0)
                {
                    Console.WriteLine("Number cannot be 0");

                    goto C;
                }

            } while (sideC == 0);


            //Calculation of P

            var p = ((sideA + sideB + sideC) / 2);

            var area = Math.Sqrt((p * (p-sideA) * (p-sideB) * (p-sideC)));

            Console.WriteLine($"Area = {area}.");


        }
    }
}
