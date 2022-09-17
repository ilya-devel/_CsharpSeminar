// Задача Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N. N = 5 -> "1, 2, 3, 4, 5" N = 6 -> "1, 2, 3, 4, 5, 6"

using System;

namespace LessonNine
{
    class Program

    {
        static void Main()
        {
            int maxSize = GetSizeValues("максимальное значение");
            System.Console.Write($"{ShowNaturalValuesRec(maxSize)} ");
            System.Console.WriteLine();
            ShowNaturalValuesLoop(maxSize);
            System.Console.WriteLine();
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
        static string ShowNaturalValuesRec(int maxValues)
        {
            if (maxValues == 1) return "1";
            else return $"{ShowNaturalValuesRec(maxValues - 1)} {maxValues}";
        }
        static void ShowNaturalValuesLoop(int maxValues)
        {
            for (int i = 1; i <= maxValues; i++) Console.Write($"{i} ");
        }
    }
}