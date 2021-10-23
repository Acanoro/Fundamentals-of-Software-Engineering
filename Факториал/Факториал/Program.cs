using System;

namespace Факториал
{
    class Program
    {
        static void Main(string[] args)
        {
            // The factorial of the number n is the product 1 × 2 × ... × n. Notation: n !.
            // For the given natural n, calculate the value n!. It is forbidden to use the math library in this problem.

            while (true)
            {
                Console.Clear();

                Console.Write("Enter factorial: ");

                int factorial = Convert.ToInt32(Console.ReadLine());

                int n = 1;

                for (int i = 1; i <= factorial; i++)
                    {
                        n *= i;
                    }

                Console.WriteLine(n);

                Console.ReadLine();
            }
        }
    }
}
