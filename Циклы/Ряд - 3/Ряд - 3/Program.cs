using System;

namespace Ряд___3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Даны два целых числа A и В, A > B.Выведите все нечётные числа от A до B включительно, в порядке убывания.
            //В этой задаче можно обойтись без инструкции if.

            while (true)
            {
                Console.Clear();

                Console.Write("Enter the first number (A > B): ");

                int a = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter the second number(B < A): ");

                int b = Convert.ToInt32(Console.ReadLine());

                for (int i = a; i >= b; i--)
                {
                    if (i % 2 != 0)
                    Console.WriteLine(i);
                }

                Console.ReadLine();
            }
        }
    }
}
