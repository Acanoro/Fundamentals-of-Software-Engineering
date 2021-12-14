using System;

namespace Exercise_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задана последовательность целых чисел. Подсчитать количество элементов, у которых четные соседи.

            var a = Array.ConvertAll(Console.ReadLine().Split(' '), i => int.Parse(i));

            int amount_of_elements = 0;

            for (int i = 1; i < a.Length - 1; i++)
            {
                if (a[i - 1] % 2 == 0 && a[i + 1] % 2 == 0)
                {
                    amount_of_elements += 1;
                }
            }

            Console.WriteLine(amount_of_elements);
        }
    }
}
