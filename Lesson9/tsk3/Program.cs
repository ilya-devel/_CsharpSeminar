// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр. 453 -> 12 45 -> 9

using System;

namespace LessonNine
{
    class Program

    {
        static void Main()
        {
            int number = GetSizeValues("число");
            System.Console.WriteLine($"{GetSumAllNumbers(number)}");
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
       static int GetSumAllNumbers(int number)
       {
        if (number == 0) return 0;
        else return number%10 + GetSumAllNumbers(number/10);
       }
    }
}