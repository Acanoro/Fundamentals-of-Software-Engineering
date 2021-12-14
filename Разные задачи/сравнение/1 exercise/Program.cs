using System;

namespace _1_exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program where the user enters three real numbers. And the program compares them, and displays the maximum of them.

            while (true)
            {
                Console.Clear();

                Console.Write("Enter the first number: ");

                double first_number = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter the second number: ");

                double second_number = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter the third number: ");

                double third_number = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine($"Maximum number: {Math.MaxMagnitude((Math.MaxMagnitude(first_number, second_number)), third_number)}");

                Console.ReadLine();

            }
        }
    }
}
