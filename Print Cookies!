using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("How many Cookies (one minimum)?");

            var howManyCookies = Console.ReadLine();

            int n;

            while (!Int32.TryParse(howManyCookies, out n))
            {
                Console.WriteLine("Not a valid number, try again.");

                howManyCookies = Console.ReadLine();
            }

            int count = 0;
            
            while (count++ < n)

            Console.WriteLine("Cookie");
