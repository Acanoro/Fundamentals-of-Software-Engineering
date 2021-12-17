using System;

namespace Cоседниe_буквы
{
    class Program
    {
        static void Main(string[] args)
        {
            //Т3.24.Дано предложение.Определить, сколько в нем одинаковых соседних букв.

            string a = Console.ReadLine();

            int b = 0;

            for (int i = 1; i < a.Length; i++)
            {
                if (a[i - 1] == a[i])
                {
                    b += 1;
                }
            }

            Console.WriteLine(b);
        }
    }
}
