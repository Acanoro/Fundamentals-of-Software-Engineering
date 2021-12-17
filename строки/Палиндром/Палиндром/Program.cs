using System;

namespace Палиндром
{
    class Program
    {
        static void Main(string[] args)
        {
            //Проверить является введенный пользователем палиндромом или нет. Пробелы и регистр символов в строке игнорировать.
            //Алгоритм решения задачи с палиндромом:
            //Получить текст из клавиатуры;
            //Удалить из него все пробелы;
            //Перевести символы строки в один регистр(не имеет значение в какой, переводите в тот, с каким вам удобнее работать);
            //Последовательно сравнивать символы с начала и конца строки приближаясь к средине: первый с последним, второй со вторым от конца и т.д.

            while (true)
            {
                string str = Console.ReadLine();
                string str_replace = str.Replace(" ", "").ToLower();
                string str_1 = null;
                string str_2 = null;


                for (int i = 0; i < str_replace.Length; i++)
                {
                    str_1 += str_replace[i];
                }

                for (int i = str_replace.Length - 1; i != -1; i--)
                {
                    str_2 += str_replace[i];
                }

                if (str_1 == str_2)
                {
                    Console.WriteLine($"Строка ''{str}'' является полиндромом");
                }
                else
                {
                    Console.WriteLine($"Строка ''{str}'' не является полиндромом");
                }
            }
        }
    }
}
