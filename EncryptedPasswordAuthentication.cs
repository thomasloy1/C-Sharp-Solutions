using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace MD5Sample
{
    class Program
    {
        public static List<string> users = new List<string>();

        public static List<string> hashes = new List<string>();


        static void Main(string[] args)
        {
            //Runs Program
            Menu();

        }

        private static void Menu()
        {
            //Menu Options
            Console.WriteLine("-Menu-");
            Console.WriteLine();
            Console.WriteLine("1. Create new user/password");
            Console.WriteLine("2. Login");
            Console.WriteLine("3. Exit");

            //Input
            string input = Console.ReadLine();

            //for validation
            int menuselect;

            do
            {
                //Input validation
                while (!(int.TryParse(input, out menuselect)))
                {
                    Console.WriteLine("Invalid Input. Try again");
                    input = Console.ReadLine();
                }

            } while (menuselect != 1 && menuselect != 2 && menuselect != 3);

            if (menuselect == 1)
            {
                //Gives option to go back
                Console.Clear();
                Console.WriteLine("Press Esc to go back or any key to continue");
                var input3 = Console.ReadKey();
                GoBack(input3);

                //Gets new username
                Console.Clear();
                Console.WriteLine("Enter New Username");
                string username = Console.ReadLine();

                //Checks to see if Username is unique
                while (users.Contains(username))
                {
                    Console.WriteLine("Username is unavailable. Enter a different username.");
                    username = Console.ReadLine();
                }

                //adds it to user list
                users.Add(username);

                //gets new password
                Console.WriteLine("Enter New Password");
                string password = Console.ReadLine();

                //encodes the password
                string hash = HashedPassword(password);

                //stores encoded password
                hashes.Add(hash);

                //returns to main menu
                Console.Clear();
                Menu();
            }
            else if (menuselect == 2)
            {
                //Gives option to go back
                Console.Clear();
                Console.WriteLine("Press Esc to go back or any key to continue");
                var input3 = Console.ReadKey();
                GoBack(input3);

                //Gets Username
                Console.Clear();
                Console.WriteLine("Enter Username");
                string input2 = Console.ReadLine();

                //Checks for user
                while (!(users.Contains(input2)))
                {
                    Console.WriteLine("User not found. Try again");
                    input2 = Console.ReadLine();
                }

                //Gets index to get appropriate value
                int index = users.IndexOf(input2);

                //Password enter
                Console.WriteLine("Enter password");
                string password = Console.ReadLine();

                //creates hash of the password
                string hash = HashedPassword(password);

                //checks if the hash at the user index is the same as the hash entered
                while (hash != hashes[index])
                {
                    Console.WriteLine("Invalid Password. Try again.");
                    password = Console.ReadLine();

                    hash = HashedPassword(password);
                }

                //Logged in Successfully
                Console.Clear();
                Console.WriteLine("LOGGED IN SUCCESSFULLY!");

                //returns to main menu
                Menu();


            }

            //Exit Program
            else
            {
                Environment.Exit(0);
            }
        }

        public static string HashedPassword(string password)
        {
            var hash = "";

            //uses MD5 to encode the password
            using (var md5 = MD5.Create())
            {
                var hashedBytes = md5.ComputeHash(Encoding.UTF8.GetBytes(password));

                //converts the byte[] to string
                hash = BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
            }

            return hash;
        }

        public static void GoBack(ConsoleKeyInfo input3)
        {
            if (input3.Key == ConsoleKey.Escape)
            {
                Console.Clear();
                Menu();
            }
            
        }


    }
}
