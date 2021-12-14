using System;

namespace _9_exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //Посчитать количество и сумму парных чисел в диапазоне от 1 до N.

            int i, x = 0, n, count = 0;
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= n; i++)

            {
                if (i % 2 == 0)
                {
                    count++;
                    x = x + i;

                }
                Console.WriteLine($"x={x} count={count}");
            }
        }
    }
}
