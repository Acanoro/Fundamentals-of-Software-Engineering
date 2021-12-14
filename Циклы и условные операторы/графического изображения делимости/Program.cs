using System;

namespace графического_изображения_делимости
{
    class Program
    {
        static void Main(string[] args)
        {
            //2.Составить программу для графического изображения делимости чисел от 1 до n(значение n вводится с клавиатуры).
            //В каждой строке надо напечатать очередное число и столько символов «+», сколько делителей у этого числа.Например,
            //если n = 4, то на экране должно быть напечатано:
            //1 +
            //2++
            //3++
            //4++ +

            Console.Write("Введите конечное число: ");

            int a = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= a; i++)
            {
                Console.Write(i);

                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        Console.Write("+");
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
