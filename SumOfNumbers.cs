using System;
using System.Linq;


namespace EX3A
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program will calculate the sum of 10 numbers.");

            double[] array1 =
            { Number1(), Number2(), Number3(), Number4(), Number5(),
              Number6(), Number7(), Number8(), Number9(), Number10()
            };

            double sum1 = array1.Sum();

            Console.WriteLine($"The sum of all elements is {sum1}.");


        }

        private static double Number10()
        {
            Console.WriteLine("Type number 10");
            var inputTen = Console.ReadLine();
            double numTen;

            while (!double.TryParse(inputTen, out numTen))
            {
                Console.WriteLine("(¬_¬) Not a valid number, try again.");

                inputTen = Console.ReadLine();
            }

            for (; numTen < 0;)
            {
                Console.WriteLine("(¬_¬) Number cannot be negative, try again.");

                inputTen = Console.ReadLine();

                while (!double.TryParse(inputTen, out numTen))
                {
                    Console.WriteLine("(¬_¬) Not a valid number, try again.");

                    inputTen = Console.ReadLine();
                }
            }

            for (; numTen > 100;)
            {
                Console.WriteLine("Number cannot exceed 100, Try again.");

                inputTen = Console.ReadLine();

                while (!double.TryParse(inputTen, out numTen))
                {
                    Console.WriteLine("(¬_¬) Not a valid number, try again.");

                    inputTen = Console.ReadLine();
                }
            }

            return numTen;
        }

        private static double Number9()
        {
            Console.WriteLine("Type number 9");
            var inputNine = Console.ReadLine();
            double numNine;

            while (!double.TryParse(inputNine, out numNine))
            {
                Console.WriteLine("(¬_¬) Not a valid number, try again.");

                inputNine = Console.ReadLine();
            }

            for (; numNine < 0;)
            {
                Console.WriteLine("(¬_¬) Number cannot be negative, try again.");

                inputNine = Console.ReadLine();

                while (!double.TryParse(inputNine, out numNine))
                {
                    Console.WriteLine("(¬_¬) Not a valid number, try again.");

                    inputNine = Console.ReadLine();
                }
            }

            for (; numNine > 100;)
            {
                Console.WriteLine("Number cannot exceed 100, Try again.");

                inputNine = Console.ReadLine();

                while (!double.TryParse(inputNine, out numNine))
                {
                    Console.WriteLine("(¬_¬) Not a valid number, try again.");

                    inputNine = Console.ReadLine();
                }
            }


            return numNine;
        }

        private static double Number8()
        {
            Console.WriteLine("Type number 8");
            var inputEight = Console.ReadLine();
            double numEight;

            while (!double.TryParse(inputEight, out numEight))
            {
                Console.WriteLine("(¬_¬) Not a valid number, try again.");

                inputEight = Console.ReadLine();
            }

            for (; numEight < 0;)
            {
                Console.WriteLine("(¬_¬) Number cannot be negative, try again.");

                inputEight = Console.ReadLine();

                while (!double.TryParse(inputEight, out numEight))
                {
                    Console.WriteLine("(¬_¬) Not a valid number, try again.");

                    inputEight = Console.ReadLine();
                }
            }


            for (; numEight > 100;)
            {
                Console.WriteLine("Number cannot exceed 100, Try again.");

                inputEight = Console.ReadLine();

                while (!double.TryParse(inputEight, out numEight))
                {
                    Console.WriteLine("(¬_¬) Not a valid number, try again.");

                    inputEight = Console.ReadLine();
                }
            }

            return numEight;
        }

        private static double Number7()
        {
            Console.WriteLine("Type number 7");
            var inputSeven = Console.ReadLine();
            double numSeven;

            while (!double.TryParse(inputSeven, out numSeven))
            {
                Console.WriteLine("(¬_¬) Not a valid number, try again.");

                inputSeven = Console.ReadLine();
            }

            for (; numSeven < 0;)
            {
                Console.WriteLine("(¬_¬) Number cannot be negative, try again.");

                inputSeven = Console.ReadLine();

                while (!double.TryParse(inputSeven, out numSeven))
                {
                    Console.WriteLine("(¬_¬) Not a valid number, try again.");

                    inputSeven = Console.ReadLine();
                }
            }

            for (; numSeven > 100;)
            {
                Console.WriteLine("Number cannot exceed 100, Try again.");

                inputSeven = Console.ReadLine();

                while (!double.TryParse(inputSeven, out numSeven))
                {
                    Console.WriteLine("(¬_¬) Not a valid number, try again.");

                    inputSeven = Console.ReadLine();
                }
            }

            return numSeven;
        }

        private static double Number6()
        {
            Console.WriteLine("Type number 6");
            var inputSix = Console.ReadLine();
            double numSix;

            while (!double.TryParse(inputSix, out numSix))
            {
                Console.WriteLine("(¬_¬) Not a valid number, try again.");

                inputSix = Console.ReadLine();
            }

            for (; numSix < 0;)
            {
                Console.WriteLine("(¬_¬) Number cannot be negative, try again.");

                inputSix = Console.ReadLine();

                while (!double.TryParse(inputSix, out numSix))
                {
                    Console.WriteLine("(¬_¬) Not a valid number, try again.");

                    inputSix = Console.ReadLine();
                }
            }

            for (; numSix > 100;)
            {
                Console.WriteLine("Number cannot exceed 100, Try again.");

                inputSix = Console.ReadLine();

                while (!double.TryParse(inputSix, out numSix))
                {
                    Console.WriteLine("(¬_¬) Not a valid number, try again.");

                    inputSix = Console.ReadLine();
                }
            }

            return numSix;
        }

        private static double Number5()
        {
            Console.WriteLine("Type number 5");
            var inputFive = Console.ReadLine();
            double numFive;

            while (!double.TryParse(inputFive, out numFive))
            {
                Console.WriteLine("(¬_¬) Not a valid number, try again.");

                inputFive = Console.ReadLine();
            }

            for (; numFive < 0;)
            {
                Console.WriteLine("(¬_¬) Number cannot be negative, try again.");

                inputFive = Console.ReadLine();

                while (!double.TryParse(inputFive, out numFive))
                {
                    Console.WriteLine("(¬_¬) Not a valid number, try again.");

                    inputFive = Console.ReadLine();
                }
            }

            for (; numFive > 100;)
            {
                Console.WriteLine("Number cannot exceed 100, Try again.");

                inputFive = Console.ReadLine();

                while (!double.TryParse(inputFive, out numFive))
                {
                    Console.WriteLine("(¬_¬) Not a valid number, try again.");

                    inputFive = Console.ReadLine();
                }
            }

            return numFive;
        }

        private static double Number4()
        {
            Console.WriteLine("Type number 4");
            var inputFour = Console.ReadLine();
            double numFour;

            while (!double.TryParse(inputFour, out numFour))
            {
                Console.WriteLine("(¬_¬) Not a valid number, try again.");

                inputFour = Console.ReadLine();
            }

            for (; numFour < 0;)
            {
                Console.WriteLine("(¬_¬) Number cannot be negative, try again.");

                inputFour = Console.ReadLine();

                while (!double.TryParse(inputFour, out numFour))
                {
                    Console.WriteLine("(¬_¬) Not a valid number, try again.");

                    inputFour = Console.ReadLine();
                }
            }

            for (; numFour > 100;)
            {
                Console.WriteLine("Number cannot exceed 100, Try again.");

                inputFour = Console.ReadLine();

                while (!double.TryParse(inputFour, out numFour))
                {
                    Console.WriteLine("(¬_¬) Not a valid number, try again.");

                    inputFour = Console.ReadLine();
                }
            }

            return numFour;
        }

        private static double Number3()
        {
            Console.WriteLine("Type number 3");
            var inputThree = Console.ReadLine();
            double numThree;

            while (!double.TryParse(inputThree, out numThree))
            {
                Console.WriteLine("(¬_¬) Not a valid number, try again.");

                inputThree = Console.ReadLine();
            }

            for (; numThree < 0;)
            {
                Console.WriteLine("(¬_¬) Number cannot be negative, try again.");

                inputThree = Console.ReadLine();

                while (!double.TryParse(inputThree, out numThree))
                {
                    Console.WriteLine("(¬_¬) Not a valid number, try again.");

                    inputThree = Console.ReadLine();
                }
            }

            for (; numThree > 100;)
            {
                Console.WriteLine("Number cannot exceed 100, Try again.");

                inputThree = Console.ReadLine();

                while (!double.TryParse(inputThree, out numThree))
                {
                    Console.WriteLine("(¬_¬) Not a valid number, try again.");

                    inputThree = Console.ReadLine();
                }
            }

            return numThree;
        }

        private static double Number2()
        {
            Console.WriteLine("Type number 2");
            var inputTwo = Console.ReadLine();
            double numTwo;

            while (!double.TryParse(inputTwo, out numTwo))
            {
                Console.WriteLine("(¬_¬) Not a valid number, try again.");

                inputTwo = Console.ReadLine();
            }

            for (; numTwo < 0;)
            {
                Console.WriteLine("(¬_¬) Number cannot be negative, try again.");

                inputTwo = Console.ReadLine();

                while (!double.TryParse(inputTwo, out numTwo))
                {
                    Console.WriteLine("(¬_¬) Not a valid number, try again.");

                    inputTwo = Console.ReadLine();
                }
            }

            for (; numTwo > 100;)
            {
                Console.WriteLine("Number cannot exceed 100, Try again.");

                inputTwo = Console.ReadLine();

                while (!double.TryParse(inputTwo, out numTwo))
                {
                    Console.WriteLine("(¬_¬) Not a valid number, try again.");

                    inputTwo = Console.ReadLine();
                }
            }

            return numTwo;
        }

        private static double Number1()
        {
            Console.WriteLine("Type number 1");
            var inputOne = Console.ReadLine();
            double numOne;

            while (!double.TryParse(inputOne, out numOne))
            {
                Console.WriteLine("(¬_¬) Not a valid number, try again.");

                inputOne = Console.ReadLine();
            }

            for (; numOne < 0;)
            {
                Console.WriteLine("(¬_¬) Number cannot be negative, try again.");

                inputOne = Console.ReadLine();

                while (!double.TryParse(inputOne, out numOne))
                {
                    Console.WriteLine("(¬_¬) Not a valid number, try again.");

                    inputOne = Console.ReadLine();
                }
            }

            for (; numOne > 100;)
            {
                Console.WriteLine("Number cannot exceed 100, Try again.");

                inputOne = Console.ReadLine();

                while (!double.TryParse(inputOne, out numOne))
                {
                    Console.WriteLine("(¬_¬) Not a valid number, try again.");

                    inputOne = Console.ReadLine();
                }
            }

            return numOne;
        }
    }
}
