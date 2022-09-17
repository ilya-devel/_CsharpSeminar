// **Задача 68:** Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n. m = 3, n = 2 -> A(m,n) = 29 

using System;

namespace LessonNine
{
    class Program

    {
        static void Main()
        {
            int m = GetSizeValues("число N");
            int n = GetSizeValues("число M");
            System.Console.WriteLine($"{AkermanFunction(n, m)}");
        }
        static int GetSizeValues(string key = "элементов")
        {
            System.Console.WriteLine($"Введите {key}: ");
            bool check = Int32.TryParse(Console.ReadLine(), out int values);
            if (!check)
            {
                System.Console.WriteLine("Не верно указаны данные, принята величина по умолчанию (3)!");
                values = 3;
            }
            return values;
        }
        static int AkermanFunction(int m, int n)
        {
            if (m == 0) return n + 1;
            else if (m > 0 && n == 0) return AkermanFunction(m - 1, 1);
            else if (m > 0 && n > 0) return AkermanFunction(m - 1, AkermanFunction(m, n - 1));
            return AkermanFunction(n, m);
        }
    }
}