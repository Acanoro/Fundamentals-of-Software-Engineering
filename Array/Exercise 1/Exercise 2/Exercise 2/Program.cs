using System;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //2.В массиве действительных чисел все нулевые элементы заменить на среднее арифметическое всех элементов массива.

            while (true)
            {
                Console.Clear();

                Console.Write("Введите количество элементов в массиве: ");

                int a = Convert.ToInt32(Console.ReadLine());

                double[] b = new double[a];  // Массив

                double c = 0;  // Сумма всех элементоа в массиве

                // Создание массива

                for (int i = 0; i < b.Length; i++)
                {
                    Console.Write($"Введите {i} элемент: ");

                    b[i] = Convert.ToInt32(Console.ReadLine()); 
                }

                // Сумма всех элементоа в массиве

                for (int i = 0; i < b.Length; i++)
                {
                    c += b[i];
                }

                // Замена 0

                for (int i = 0; i < b.Length; i++)
                {
                    if (b[i] == 0)
                        b[i] = c / b.Length;
                }

                // Вывод массива

                for (int i = 0; i < b.Length; i++)
                {
                    Console.Write($"{b[i]} ");
                }

                Console.ReadLine();
            }


        }
    }
}
