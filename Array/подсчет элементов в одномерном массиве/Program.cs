using System;
using System.Threading;

namespace подсчет_элементов_в_одномерном_массиве
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. В одномерном массиве из 100 чисел M[] подсчитайте количество элементов, удовлетворяющих условию 0 < M[i] <125

            int[] array = new int[100];

            Random random = new Random();

            int amount_of_elements = 0;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1000);
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (0 < array[i] && array[i] < 125)
                {
                    amount_of_elements += 1;
                }
            }

            // Вывод массива на экран

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }

            Console.WriteLine($"\nколичество элементов, удовлетворяющих условию 0 < M[i] <125 = {amount_of_elements}");
        }
    }
}
