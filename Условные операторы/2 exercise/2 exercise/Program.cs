using System;

namespace _2_exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // User enters an integer, convert the value of the day of the week to a text name.
            // If the entered value does not correspond to the day of the week, print an error message.

            //first code
            while (true)
            {
                Console.Clear();

                Console.Write("Enter the day of the week numbers: ");

                string a = Console.ReadLine();

                switch (a)
                {
                    case "1":
                        Console.WriteLine("Monday");
                        break;
                    case "2":
                        Console.WriteLine("Tuesday ");
                        break;
                    case "3":
                        Console.WriteLine("Wednesday ");
                        break;
                    case "4":
                        Console.WriteLine("Thursday  ");
                        break;
                    case "5":
                        Console.WriteLine("Friday ");
                        break;
                    case "6":
                        Console.WriteLine("Saturday  ");
                        break;
                    case "7":
                        Console.WriteLine("Sunday ");
                        break;
                    default:
                        Console.WriteLine("ERROR");
                        break;
                }

                Console.ReadLine();

            }
        }
    }
}
