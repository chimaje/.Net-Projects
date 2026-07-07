using System;
using System.Collections.Generic;

namespace ToDoList
{
    internal class Program
    {
        static List<string> tasks = new List<string>();
        static void Main(string[] args)
        {
            bool exitApp = false;

            while (!exitApp) //allows the program to continously run and show the menu constantly until exited 
            {
                Console.Clear();
                Console.WriteLine("TO DO APP");
                Console.WriteLine("1. Add a Task");
                Console.WriteLine("2. View All Task");
                Console.WriteLine("3. Remove a Task");
                Console.WriteLine("4. Exit");
                Console.Write("\nChoose an Option ");

                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        AddTask();
                        break;
                    case "2":
                        ViewTasks();
                        break;
                    case "3":
                        RemoveTask();
                        break;
                    case "4":
                        exitApp = true;
                        Console.WriteLine(".......Exiting Application");
                        break;
                    default:
                        Console.WriteLine("Invalid Option.");
                        Console.Write("/nChoose an Option");
                        Console.ReadLine();
                        break;
                }
            }
        }
        static void AddTask()
        {
            Console.Clear();
            Console.WriteLine("Enter a new task : ");
            string newTask = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(newTask))
            {
                tasks.Add(newTask);
                Console.WriteLine($"Task \"{newTask}\"added successfully.");

            }
            else
            {
                Console.WriteLine("Please Enter a Task");
            }
            Console.WriteLine("Press Enter to return to the menu. ");
            Console.ReadLine();
        }
        static void ViewTasks()
        {
            Console.Clear();
            if (tasks.Count == 0)
            {
                Console.WriteLine("No tasks found.");
                Console.WriteLine(" Enter 1 to Add a task");
                string input = Console.ReadLine();
                if (input == "1")
                {
                    AddTask();
                }
                else
                {
                    Console.WriteLine("Press Enter to return to the menu. ");
                    Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("Your Tasks for Today : ");
                for (int i = 0; i < tasks.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {tasks[i]}");
                }
            }
            Console.WriteLine("Press Enter to return to the menu. ");
            Console.ReadLine();
        }
        static void RemoveTask()
        {
            Console.Clear();
            if (tasks.Count == 0)
            {
                Console.WriteLine("No tasks to remove");
                Console.WriteLine("Press Enter to return to the menu. ");
                Console.ReadLine();
            }
            ViewTasks();
            Console.WriteLine("\nWhich task do you want to remove : ");
            if (int.TryParse(Console.ReadLine(), out int taskIndex))
            {
                if (taskIndex >= 1 && taskIndex <= tasks.Count)
                {
                    Console.WriteLine($"Task \"{tasks[taskIndex - 1]} \" removed.");
                    tasks.RemoveAt(taskIndex - 1);
                }
                else
                {
                    Console.WriteLine("Invalis task number. ");
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid number.");
            }
            Console.WriteLine("Press Enter to return to the menu. ");
            Console.ReadLine();
        }
    }
}