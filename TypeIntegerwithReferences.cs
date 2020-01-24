using System;

namespace _23Jan
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type an Integer.");

            var userInput = Console.ReadLine();

            int n;
           
            n = IllicitInput(ref userInput);
            
            returnTexts(n);

        }

        
        
        
        private static void returnTexts(int n)
        {
            if (n > 0)
            {
                Console.WriteLine("(~˘▾˘)~ YAYYYYYYYYY!!!!");
            }
            else if (n < 0)
            {
                Console.WriteLine("(>_>) What's wrong with you??");
            }
            else
            {
                Console.WriteLine("(-_-) Not cool, man. Not cool.");
            }
        }

       
       
       
       private static int IllicitInput(ref string userInput)
        {
            int n;
            while (!Int32.TryParse(userInput, out n))
            {
                Console.WriteLine("(¬_¬) Not a valid number, try again.");

                userInput = Console.ReadLine();
            }

            return n;
        }
    }
}
