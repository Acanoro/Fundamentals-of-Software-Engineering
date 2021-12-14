using System;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Дан массив целых чисел. Переписать все положительные элементы во второй массив, а остальные - в третий.

            while (true)
            {
                Console.Clear();

                Console.Write("Введите количество элементов в массиве: ");

                int a = Convert.ToInt32(Console.ReadLine());

                double[] massiv_1 = new double[a];  // 1 массив

                int positive = 0;  // Количество положительных эелементов

                int negative = 0;   // Количество отрицательных эелементов

                // Создание массива

                for (int i = 0; i < massiv_1.Length; i++)
                {
                    Console.Write($"Введите {i} элемент: ");

                    massiv_1[i] = Convert.ToInt32(Console.ReadLine());
                }

                // Нахождение количества положительных и отрицательных эелементов

                for (int i = 0; i < massiv_1.Length; i++)
                {
                    if (massiv_1[i] > 0)
                        positive += 1;

                    else
                        negative += 1;
                }

                double[] massiv_2 = new double[positive]; // 2 массив

                int index_massiv_2 = 0; // Индекс 2 массива

                double[] massiv_3 = new double[negative]; // 3 массив

                int index_massiv_3 = 0; // Индекс 3 массива

                // Добавление элементов из 1 массива во 2 и 3 

                for (int i = 0; i < massiv_1.Length; i++)
                {
                    if (massiv_1[i] > 0)
                    {
                        massiv_2[index_massiv_2] = massiv_1[i];

                        index_massiv_2 += 1;
                    }

                    else
                    {
                        massiv_3[index_massiv_3] = massiv_1[i];

                        index_massiv_3 += 1;
                    }
                }

                // Вывод массива 1, 2, 3

                Console.Write("\nПервый массив: ");

                for (int i = 0; i < massiv_1.Length; i++)
                {
                    Console.Write($"{massiv_1[i]} ");
                }

                Console.Write("\n\nВторой массив: ");

                for (int i = 0; i < massiv_2.Length; i++)
                {
                    Console.Write($"{massiv_2[i]} ");
                }

                Console.Write("\n\nТретий массив: ");

                for (int i = 0; i < massiv_3.Length; i++)
                {
                    Console.Write($"{massiv_3[i]} ");
                }

                Console.ReadLine();
            }
        }
    }
}
