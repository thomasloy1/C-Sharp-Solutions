using System;
using System.Collections.Generic;
using System.Linq;

namespace EX3B
{
    class Program
    {
        static void Main(string[] args)
        {
            //Generates List
            List<double> grades = new List<double>();
            
            Console.WriteLine("This program will calculate grade averages. When complete, Type 'DONE' to calculate score.");

            //Takes in grades, uses the ValidateInput() Method and the GradeAverage() Method
            InputGrades(grades);

            //Math portion
            double sum = grades.Aggregate((a, b) => a + b) ;
            double total = grades.Count;
            double av1 = sum / total;

            //Display portion
            Console.WriteLine($"Total Number of Grades: {total}");
            Console.WriteLine($"The sum of the grades: {sum}");
            Console.WriteLine($"The Average is: {av1}");
            CalculatingAverage(av1);
        }
        public static void CalculatingAverage(double av1)
        {
            //Finds and Displays the letter grade given the average
            Console.WriteLine("Calculating Average...");

            if (av1 < 60)
            {
                Console.WriteLine($"Student Grade is {av1} which is an F.");
            }
            else if (av1 >= 60 && av1 < 70)
            {
                Console.WriteLine($"Student Grade is {av1} which is a D.");
            }
            
            else if (av1 >= 70 && av1 < 80)
            {
                Console.WriteLine($"Student Grade is {av1} which is a C.");
            }
            
            else if (av1 >= 80 && av1 < 90)
            { 
                Console.WriteLine($"Student Grade is {av1} which is a B");
            }
            
            else if (av1 >= 90)
            {
                Console.WriteLine($"Student Grade is {av1} which is an A.");
            }
            
        }

        public static double ValidateInput(string input)
        {
            //Input validation method
            double grade;

            while (!double.TryParse(input, out grade))
            {
                Console.Write("Invalid input. Type another grade___");

                input = Console.ReadLine();

            }

            for (; grade < 0;)
            {
                Console.Write("Number cannot be negative. Type another grade___");

                input = Console.ReadLine();

                while (!double.TryParse(input, out grade))
                {
                    Console.Write("Not a valid number. Type another grade___");

                    input = Console.ReadLine();
                }
            }

            for (; grade > 100;)
            {
                Console.Write("Number cannot exceed 100. Type another grade___");

                input = Console.ReadLine();

                while (!double.TryParse(input, out grade))
                {
                    Console.Write("Not a valid number. Type another grade___");

                    input = Console.ReadLine();
                }
            }

            return grade;
        }

        private static void InputGrades(List<double> grades)
        {
            //Uses recursive method to loop
            //Takes in grades, calls ValidateInput, and adds to list

            Console.Write("Type a grade___");
            string input = Console.ReadLine();

            if (input != "DONE")
            {
                double grade = ValidateInput(input);

                grades.Add(grade);

                InputGrades(grades);

            }
        }
    }
}
