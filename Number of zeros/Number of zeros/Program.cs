using System;

namespace Number_of_zeros
{
    class Program
    {
        static void Main(string[] args)
        {
            // Given N numbers: first enter the number N, then enter exactly N integers.
            // Count the number of zeros among the entered numbers and print this amount.
            // You need to count the number of numbers equal to zero, not the number of digits.

            while (true)
            {
                Console.Clear();

                int n = Convert.ToInt32(Console.ReadLine());

                int b = 0;

                for (int i = 1; i <= n; i++)
                {
                    int a = Convert.ToInt32(Console.ReadLine());

                    if (a == 0)
                    {
                        b += 1;
                    }     
                }

                Console.WriteLine(b);

                Console.ReadLine();
            }
        }
    }
}
