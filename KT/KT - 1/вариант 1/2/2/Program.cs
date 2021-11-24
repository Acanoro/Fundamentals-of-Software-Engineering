using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Даны два числа A и B(A<B). Найти сумму всех целых чисел от А до В включительно.
            //Решить задачу используя циклическую конструкцию for.
            while (true)
            {
                Console.Clear();
            
                Console.WriteLine("Введите 2 числа, при том что первое число дожно быть меньше второго.");

                Console.Write("Введите первое число: ");

                int A = Convert.ToInt32(Console.ReadLine());

                Console.Write("Введите второе число: ");

                int B = Convert.ToInt32(Console.ReadLine());

                int c = 0;

                for (int i = A; i <= B; i++)
                {
                    c += i;
                }

                Console.WriteLine($"Сумма всех целых чисел от А до В = {c}");

                Console.ReadLine();
            }

        }
    }
}
