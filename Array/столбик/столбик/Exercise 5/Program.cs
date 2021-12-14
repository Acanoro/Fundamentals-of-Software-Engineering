using System;

namespace Exercise_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задан массив из n целых чисел. Вывести его элементы в столбик, не меняя первоначальный порядок. 

            while (true)
            {
                Console.Clear();

                Console.Write("Введите количество элементов в массиве: ");

                int n = Convert.ToInt32(Console.ReadLine());

                double[] a = new double[n];  // 1 массив

                // Создание массива

                for (int i = 0; i < a.Length; i++)
                {
                    Console.Write($"Введите {i} элемент: ");

                    a[i] = Convert.ToInt32(Console.ReadLine());
                }

                // Вывод массива на экран

                for (int i = 0; i < a.Length; i++)
                {
                    Console.Write($"{a[i]}\n");
                }

                Console.ReadLine();
            }
        }
    }
}
