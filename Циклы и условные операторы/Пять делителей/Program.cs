using System;

namespace Пять_делителей
{
    class Program
    {
        static void Main(string[] args)
        {
            //3. Найти все целые числа из промежутка от 1 до 300, у которых ровно пять делителей.

            Console.Write($"числа у которых ровно пять делителей: ");

            int a = 0;

            for(int i = 1; i <= 300; i++)
            {
                for (int j = 1; j <= i; j++)
                { 
                    if(i % j == 0)
                    {
                        a += 1;
                    }
                }

                if (a == 5)
                {
                    Console.Write($"{i}; ");
                }

                a = 0;
            }
        }
    }
}
