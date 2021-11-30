using System;

namespace _8_exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //Посчитать количество и сумму парных чисел в диапазоне от 1 до N.

            while (true)
            {
                Console.Clear();

                for (int i = 1; i <= 10; i++)
                {
                    for (int a = 2; a <= 6; a++)
                    {
                        Console.Write($"{a} * {i} = {a * i}\t");

                    }

                    Console.WriteLine();

                }

                Console.ReadLine();

            }
        }
    }
}
