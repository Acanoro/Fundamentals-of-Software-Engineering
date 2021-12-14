using System;

namespace Exercise_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задан массив из n целых чисел. Вывести только его положительные элементы, не меняя первоначальный порядок.

            while (true)
            {
                Console.Clear();

                Console.Write("Введите количество элементов в массиве: ");

                int n = Convert.ToInt32(Console.ReadLine());

                double[] a = new double[n];  // массив

                // Создание массива

                for (int i = 0; i < a.Length; i++)
                {
                    Console.Write($"Введите {i} элемент: ");

                    a[i] = Convert.ToInt32(Console.ReadLine());
                }

                // Вывод массива на экран

                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] > 0)
                    {
                        Console.Write($"{a[i]} ");
                    }
                }

                Console.ReadLine();
            }
        }
    }
}
