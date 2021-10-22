using System;

namespace _4_exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //Three integers are given. Choose from them those that belong to the interval [1,3].

            while (true)
            {
                Console.Clear();

                double a = Convert.ToDouble(Console.ReadLine());

                double b = Convert.ToDouble(Console.ReadLine());

                double c = Convert.ToDouble(Console.ReadLine());

                for (int i = 1; i <= 3; i++)
                {
                    if (i == a)
                    {
                        Console.WriteLine(a);
                    }
                    if (i == b)
                    {
                        Console.WriteLine(b);
                    }
                    if (i == c)
                    {
                        Console.WriteLine(c);
                    }
                }

                Console.ReadLine();
            }
        }
    }
}
