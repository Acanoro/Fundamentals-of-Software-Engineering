using System;

namespace _3_exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program for calculating the cost of the purchase, taking into account the discount.
            //A 3% discount is provided if the purchase amount is more than 500 rubles, 5% - if the amount is more than 1000 rubles.

            while (true)
            {


                Console.Clear();

                Console.Write("Enter purchase amount: ");

                double a = Convert.ToInt32(Console.ReadLine());

                if (a > 500 && a <= 1000)
                    Console.WriteLine($"Purchase price including discount {a - (a * 0.03) }");
                else if (a > 1000)
                    Console.WriteLine($"Purchase price including discount {a - (a * 0.05) }");
                else
                    Console.WriteLine($"Purchase price including discount {a}");

                Console.ReadLine();
            }
        }
    }
}
