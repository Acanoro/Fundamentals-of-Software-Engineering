using System;

namespace периметр_треугольника
{
    class Program
    {
        //Выполнить: Вводятся три числа — длины трех сторон треугольника. Создайте функцию Perimeter(), которая вычисляет периметр треугольника по длинам трех его сторон.

        //Указание 1: Метод Perimeter() должен принимать в качестве аргументов три целых числа.
        //Указание 2: Метод не должен возвращать никакого значения, поэтому вы должны использовать ключевое слово void в сигнатуре:

        //static void Perimeter(...);
        //Указание 3: Не забудьте преобразовать введенные значения в целые числа. Например:

        //int a = int.Parse(Console.ReadLine());

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();

                Console.Write("Введите первую сторону треугольника ");

                int a = Convert.ToInt32(Console.ReadLine());

                Console.Write("Введите вторую сторону треугольника ");

                int b = Convert.ToInt32(Console.ReadLine());

                Console.Write("Введите третию сторону треугольника ");

                int c = Convert.ToInt32(Console.ReadLine());

                Perimetr(a, b, c);
            }
        }

        static void Perimetr(int a, int b, int c)
        {
            int p = a + b + c;

            Console.WriteLine($"Периметр = {p}");

            Console.ReadLine();
        }

    }
}
