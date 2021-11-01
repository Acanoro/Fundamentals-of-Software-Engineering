using System;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Given a one-dimensional array consisting of N integer elements. Enter the array from the keyboard.
            // Find the maximum element. Display the array in reverse order.

            while (true)
            {
                Console.Clear();

                Console.Write("Enter the number of elements in the art: ");

                int[] a = new int[Convert.ToInt32(Console.ReadLine())]; // Array

                int b = 0; // Maximum number

                // Array input

                for (int i = 0; i < a.Length; i++)
                {
                    Console.Write($"Type {i} array: ");

                    a[i] = Convert.ToInt32(Console.ReadLine());
                }

                // Finding the maximum number

                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] > b)
                        b = a[i];
                }

                // Array in reverse order

                Console.Write("Array in reverse order: ");

                for (int i = a.Length - 1; i >= 0; i--)
                {
                    Console.Write($"{a[i]} ");
                }

                Console.WriteLine();

                Console.WriteLine($"Maximum number: {b}");

                Console.ReadLine();

            }
        }
    }
}
