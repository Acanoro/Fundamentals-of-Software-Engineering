using System;

namespace _6_exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //Вычислить факториал числа p(при p > 0), используя цикл do while.

            Console.Write("Введите число: ");

            int p = Convert.ToInt32(Console.ReadLine());

            int b = 1;

            int c = 1;

            do
            {
                c *= b;

                ++b;
            }

            while (b <= p);
            
            Console.WriteLine(c);

            Console.ReadLine();

        }

    }
}
