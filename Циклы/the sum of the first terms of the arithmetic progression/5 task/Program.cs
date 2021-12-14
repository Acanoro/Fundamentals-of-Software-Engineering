using System;

namespace _5_task
{
    class Program
    {
        static void Main(string[] args)
        {
            //Find the sum of the first N terms of an arithmetic progression using a for loop.

            while (true)
            {
                Console.Clear();
            
                Console.Write("Enter the number: ");

                int n = Convert.ToInt32(Console.ReadLine());

                int sum = 0;

                for (int i = 1; i <= n; i++)
                {
                    sum += i; 
                }
                Console.WriteLine($"The sum of the first {n} members of the arithmetic progression is {sum}");

                Console.ReadLine();

                

            }
        }
    }
}
