using System;

namespace Количество_делителей
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Найти количество делителей каждого из целых чисел от 120 до 140.

            int a = 0;

            for (int i = 120; i <= 140; i++)
            {
                for (int j = 1; j <= 120; j++)
                {
                    if (i % j == 0)
                    {
                        a += 1;
                    }
                }

                Console.WriteLine($"количество делителей числа {i} = {a}");

                a = 0;
            }
        }
    }
}
