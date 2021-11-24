using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            //3.Дана последовательность отрицательных целых чисел, оканчивающаяся положительным числом. 
            //Найти среднее арифметическое всех чисел последовательности(без учета положительным числа).
            //Решить задачу используя циклическую конструкцию while.

            while (true)
            {
                Console.Clear();

                Console.Write("Введите первое отрицательное число: ");

                int a = Convert.ToInt32(Console.ReadLine());

                Console.Write("Введите второе число (b > a): ");

                int b = Convert.ToInt32(Console.ReadLine());

                int c = 0;

                int d = 0;

                while (a < b)
                {
                    if (a == 0)
                        break;
                    c += a;

                    d += 1;

                    a += 1;
                }

                Console.WriteLine($"среднее арифметическое всех чисел последовательности(без учета положительным числа) = {c / d}");

                Console.ReadLine();
            }
        }
    }
}
