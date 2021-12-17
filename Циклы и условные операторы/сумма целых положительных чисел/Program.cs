using System;

namespace сумма_целых_положительных_чисел
{
    class Program
    {
        //Найти сумму целых положительных чисел, больших 30 и меньших 100, кратных трем и оканчивающихся на 2, 4 и 8.

        static int sum(ref int a, int b)
        { 
            int summ = 0;

            for (int i = a; i < b; i++)
            {
                if (i % 3 == 0 && (i % 10 == 2 || i % 10 == 4 || i % 10 == 8))
                {
                    summ += 1;
                }
            }

            return summ;
        }

        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());

            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(sum(ref a, b));
        }
    }
}
