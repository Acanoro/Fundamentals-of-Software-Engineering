using System;

namespace _7_exercise
{
    class Program
    {
        static void Main(string[] args)
        {

            //Вывести на экран, консольного приложения, прямоугольный треугольник из звездочек “*”, с длиной катета m.

            while (true)
            {
                Console.Clear();

                int leg_length = Convert.ToInt32(Console.ReadLine());

                for (int i = 1; i < leg_length; i++)
                {
                    for (int a = 1; a < i; a++)
                    {
                        Console.Write("#");
                    }

                    Console.WriteLine();
                    
                    Console.ReadLine();

                }
            }
        }
    }
}
