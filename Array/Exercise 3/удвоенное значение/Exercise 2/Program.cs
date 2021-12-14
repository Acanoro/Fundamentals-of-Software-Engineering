using System;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. Дан одномерный массив из 8 элементов. Заменить все элементы массива меньшие 15 их удвоенными значениями.
            //Вывести на экран монитора преобразованный массив.

            while (true)
            {
                Console.Clear();

                double[] massiv_1 = new double[8];  // 1 массив

                // Создание массива

                for (int i = 0; i < massiv_1.Length; i++)
                {
                    Console.Write($"Введите {i} элемент: ");

                    massiv_1[i] = Convert.ToInt32(Console.ReadLine());
                }

                // Удвоение элементов, которые меньше 15

                for (int i = 0; i < massiv_1.Length; i++)
                {
                    if (massiv_1[i] < 15)
                        massiv_1[i] = massiv_1[i] + massiv_1[i];
                }

                // Вывод измененного массива на экран

                Console.Write("\nИзмененный массив: ");

                for (int i = 0; i < massiv_1.Length; i++)
                {
                    Console.Write($"{massiv_1[i]} ");
                }

                Console.ReadLine();

            }
        }
    }
}
