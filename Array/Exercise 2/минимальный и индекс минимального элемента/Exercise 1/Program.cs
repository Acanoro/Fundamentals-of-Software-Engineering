using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Дан одномерный массив, состоящий из N целочисленных элементов. Ввести массив с клавиатуры.
            //Найти минимальный элемент.Вывести индекс минимального элемента на экран.

            while (true)
            {
                Console.Clear();

                Console.Write("Введите количество элементов в массиве: ");

                int a = Convert.ToInt32(Console.ReadLine());

                int[] b = new int[a];  // Массив

                int c = 1;  // Минимальный элемент массива

                int d = 0;  // Индекс минимального элемента в массиве

                // Создание массива

                for (int i = 0; i < b.Length; i++)
                {
                    Console.Write($"Введите {i} элемент: ");

                    b[i] = Convert.ToInt32(Console.ReadLine());
                }

                // Нахождение минимального массива и его индекса

                for (int i = 0; i < b.Length; i++)
                {
                    if (c > b[i])
                    {
                        c = b[i];

                        d = i;
                    }
                }

                Console.WriteLine($"Минимальный элемент: {c}\nИндекс минимального элемента: {d}");

                Console.ReadLine();
            }

        }
    }
}
