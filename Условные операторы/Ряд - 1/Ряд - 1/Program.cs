using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Даны два целых числа A и B(при этом A ≤ B).Выведите все числа от A до B включительно.=

            while (true)
            {
                Console.Clear();

                Console.Write("Enter the first number (A ≤ B): ");

                int a = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter the second number: ");

                int b = Convert.ToInt32(Console.ReadLine());

                if (a <= b)
                    for (int i = a; i <= b; i++)
                    {
                        Console.WriteLine(i);
                    }
                else
                    Console.WriteLine("ERROR");

                Console.ReadLine();
            }

        }
    }
}
