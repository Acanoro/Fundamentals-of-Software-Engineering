using System;

namespace Exercise_8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задан массив из n целых чисел. Найти сумму и количество чисел, больших среднего арифметического элементов массива.

            while (true)
            {
                Console.Clear();

                Console.Write("Введите количество элементов в массиве: ");

                int n = Convert.ToInt32(Console.ReadLine());

                double[] a = new double[n];  // 1 массив

                double the_sum_of_all_numbers = 0;

                double sum_of_numbers = 0;

                int amount_of_numbers = 0;

                // Создание массива

                for (int i = 0; i < a.Length; i++)
                {
                    Console.Write($"Введите {i} элемент: ");

                    a[i] = Convert.ToInt32(Console.ReadLine());
                }

                // Hаходит сумму всех чисел

                for (int i = 0; i < a.Length; i++)
                    the_sum_of_all_numbers += a[i];

                // Hаходит сумму и количество чисел, больших среднего арифметического элементов массива

                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] > the_sum_of_all_numbers / a.Length)
                    {
                        sum_of_numbers += a[i];

                        amount_of_numbers += 1;
                    }
                }

                Console.WriteLine($"Сумма больших среднего арифметического элементов массива: {sum_of_numbers}\nКоличество чисел больших среднего арифметического элементов массива: {amount_of_numbers}");

                Console.ReadLine();
            }
        }
    }
}
