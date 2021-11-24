using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Вывести на экран синус максимального из 3 заданных чисел.
            while (true)
            {
                Console.Clear();

                Console.Write("Введите первое число: ");

                double a = Math.Sin((Convert.ToDouble(Console.ReadLine())) * Math.PI / 180);

                Console.Write("Введите второе число: ");

                double b = Math.Sin((Convert.ToDouble(Console.ReadLine())) * Math.PI / 180);

                Console.Write("Введите третие число: ");

                double c = Math.Sin((Convert.ToDouble(Console.ReadLine())) * Math.PI / 180);

                Console.WriteLine($"Максимальное значение синуса из 3 чисел: {Math.Round(Math.Max(Math.Max(a, b), c), 2)}");

                Console.ReadLine();
            }

        }
    }
}
