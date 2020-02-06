using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TaskManagerProject
{
    class Program
    {
        //Constant that tells how many items per page
        const int itemsPerPage = 20;

        //This allows us to reference the currentIndex of the list from anywhere.
        private static int currentIndex = 0;

        static void Main(string[] args)
        {
            //Initiates the list.
            List<string> TaskList = new List<string>();
            List<bool> StatusOfTask = new List<bool>();

            //Initiates the place to save a Text file
            string FilePath = @"D:/Documents/Microsoft Class/ToDo.txt";
            string FilePath2 = @"D:/Documents/Microsoft Class/ToDoBool.txt";

            //Looks to the files to see if there is an existing list.
            TaskList.AddRange(File.ReadAllLines(FilePath));
            StatusOfTask.AddRange(File.ReadAllLines(FilePath2).Select(s => bool.Parse(s)));

            //Initiates the Page number
            int pagenum = PageNum(currentIndex);

            //Displays Current List if any and the menu.
            DisplayTasks(TaskList, StatusOfTask, pagenum);

            //Takes in the next key press.
            var input = Console.ReadKey();

            //This loop goes through all the program functions
            do
            {
                //Clear console to keep the display readable.
                Console.Clear();

                //Determines the menu item selected and performs the functions therein.
                MenuInput(TaskList, input, StatusOfTask);

                //Calculates page number.
                pagenum = PageNum(currentIndex);

                //Displays the result of the Menu Function selected.
                DisplayTasks(TaskList, StatusOfTask, pagenum);

                //Takes in another key press the determine the next function.
                input = Console.ReadKey();

                //Autosaves entry
                AutoSave(FilePath, TaskList, FilePath2, StatusOfTask);

            } while (input.Key != ConsoleKey.X);

        }

        private static void MenuInput(List<string> TaskList, ConsoleKeyInfo input, List<bool> StatusOfTask)
        {
            // These if/ else if /else statements determine which menu item selected and performs the desired function.
            if (input.Key == ConsoleKey.A)
            {
                //Adds the task to list.

                Console.WriteLine("Add a Task.");
                string task = Console.ReadLine();

                TaskList.Add(task);
                StatusOfTask.Add(true);

            }

            else if (TaskList.Count != 0)
            {
                
                if (input.Key == ConsoleKey.S)
                {
                    //Scrolls through the list.

                    NextOf(TaskList);

                }

                else if (input.Key == ConsoleKey.F)
                {
                    //Does something to indicate it needs to be darkened

                    StatusOfTask[currentIndex] = false;

                    NextOf(TaskList);

                }

                else if (input.Key == ConsoleKey.R)
                {
                    string task = TaskList[currentIndex];
                    StatusOfTask[currentIndex] = false;
                    TaskList.Add(task);
                    StatusOfTask.Add(true);

                    NextOf(TaskList);
                }

                else if (input.Key == ConsoleKey.X)
                {
                    Environment.Exit(0);

                }

                else
                {
                    Console.WriteLine("Invalid Input. Try again.");

                }
            }
            else
            {
                Console.WriteLine("Invalid Input. Try again.");

            }
        }

        private static void DisplayTasks(List<string> TaskList, List<bool> StatusOfTask, int pagenum)
        {
            //The for loop here displays the total number of elements in the list. i represents the individual elements.
            int i;
            for (i = FirstOfPage(pagenum); (i < TaskList.Count) && (i < FirstOfPage(pagenum + 1)); ++i)
            {
                //Removes the top entry if greyed out.
                if (!StatusOfTask[i] && i == 0)
                {
                   
                    TaskList.RemoveAt(0);
                    StatusOfTask.RemoveAt(0);

                    //Resets i.
                    currentIndex = 0;
                    i = currentIndex - 1;
                    
                }

                //If the element that i represents at the current time = the currentIndex, (which is increased/reset by the NextOf method)
                //the display will change the background and foreground to Green and black respectively.
                else if (i == currentIndex)
                {
                    if (StatusOfTask[i])
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine($"Tasks: {TaskList[i]}");


                        //Reset color after its displayed so that the others aren't colored.
                        Console.ResetColor();
                    }

                    else
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGray;

                        NextOf(TaskList);

                        Console.WriteLine($"Tasks: {TaskList[i]}");
                    }
                }

                else if (!StatusOfTask[i])
                {
                    Console.ForegroundColor = ConsoleColor.DarkGray;

                    Console.WriteLine($"Tasks: {TaskList[i]}");

                    Console.ResetColor();
                }


                //If i does not equal the currentIndex at this point in the loop, display the basic text color.
                else
                {
                    Console.WriteLine($"Tasks: {TaskList[i]}");
                }
            }

            //Display the spaces and menu options after the list is displayed.
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("a : Add || s: Skip || f: Finished || r: Re-Enter || x: Exit");
        }

        public static void NextOf(List<string> TaskList)
        {
            //Iterates through the task list without going over the total number of task items.
            currentIndex += 1;
            currentIndex %= TaskList.Count;

        }

        private static void AutoSave(string FilePath, List<string> TaskList, string FilePath2, List<bool> StatusOfTask)
        {
            //Writes the list items to the text file.
            File.WriteAllLines(FilePath, TaskList);

            File.WriteAllLines(FilePath2, StatusOfTask.Select(b => b.ToString()));
        }

        private static int PageNum(int currentIndex)
        {
            //Calculates the page number.
            int pagenum = currentIndex / itemsPerPage;

            return pagenum;
        }

        private static int FirstOfPage(int pagenum)
        {
            //Calculates the page to display.
            int start = itemsPerPage * pagenum;

            return start;

        }

    }

}
