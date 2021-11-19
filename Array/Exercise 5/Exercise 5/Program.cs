using System;

namespace Exercise_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //3.Задан массив из n целых чисел.Найти сумму и количество чисел, больших среднего арифметического элементов массива.

            Console.Write("Введите количество целых чисел в массиве: ");

            int n = Convert.ToInt32(Console.ReadLine());

            double[] a = new double[n];

            double sum_vsex_chisel = 0;

            double sum_bolshe_ar = 0;

            int kolvo_elementov_bolshe_ar = 0;

            for (int i = 0; i < n; i++)
            {

                Console.Write($"Введите {i} элемент массива: ");

                a[i] = Convert.ToDouble(Console.ReadLine());
            }

            for (int i = 0; i < a.Length; i++)
            {
                sum_vsex_chisel += a[i];
            }

            double srednee_arefmeticheskoe = sum_vsex_chisel / n;

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > srednee_arefmeticheskoe)
                {
                    sum_bolshe_ar += a[i];

                    kolvo_elementov_bolshe_ar += 1;
                }
            }

            Console.WriteLine($"Cуммa чисел больших среднего арифметического элементов массива: {sum_bolshe_ar}\nКоличество чисел больших среднего арифметического элементов массива: {kolvo_elementov_bolshe_ar}");

            Console.ReadLine();
        }
    }
}
