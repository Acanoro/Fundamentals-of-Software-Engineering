using System;
using System.Linq;

namespace Реверс
{
    class Program
    {
        static void Main(string[] args)
        {
            //Реверс – переворачивание символов строки, когда последняя буква в тексте становиться первой, а первая – последней. 
            //Написать программу для получения реверсированной строки.

            string str = Console.ReadLine();
            string str_2 = new string(str.ToCharArray().Reverse().ToArray());
            Console.WriteLine(str_2);
            Console.ReadLine();
        }
    }
}
