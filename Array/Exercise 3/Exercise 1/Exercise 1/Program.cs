using System;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. В одномерном числовом массиве D длиной n вычислить сумму элементов с нечетными индексами.
            //Вывести на экран массив D, полученную сумму.

            while (true)
            {
                Console.Clear();

                Console.Write("Введите количество элементов в массиве: ");

                int n = Convert.ToInt32(Console.ReadLine());

                double[] D = new double[n];  // 1 массив

                double nechet = 0;  // Сумма нечетных чисел

                // Создание массива

                for (int i = 0; i < D.Length; i++)
                {
                    Console.Write($"Введите {i} элемент: ");

                    D[i] = Convert.ToInt32(Console.ReadLine());
                }

                // Находим сумму нечетных и выводим массив D на экран

                Console.Write("\nМассив D: ");

                for (int i = 0; i < D.Length; i++)
                {
                    if (D[i] % 2 != 0)
                        nechet += D[i];

                    Console.Write($"{D[i]} ");
                }

                Console.WriteLine($"\n\nСумма нечетных чисел: {nechet}");

                Console.ReadLine();
            }
        }
    }
}
