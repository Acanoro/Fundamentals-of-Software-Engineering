using System;

namespace количество_делителей
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Найти количество делителей каждого из целых чисел от 120 до 140.

            int sum = 0;

            for (int i = 120; i <= 140; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        sum += 1;
                    }
                }

                Console.WriteLine($"Kоличество делителей числa {i}: {sum}");

                sum = 0;
            }
        }
    }
}
