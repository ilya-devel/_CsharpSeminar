// Задача Задача 65: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. M = 1; N = 5 -> "1, 2, 3, 4, 5" M = 4; N = 8 -> "4, 5, 6, 7, 8" 


using System;

namespace LessonNine
{
    class Program

    {
        static void Main()
        {
            int maxSize = GetSizeValues("максимальное значение");
            int minSize = GetSizeValues("минимальное значение");
            System.Console.Write($"{ShowNaturalValuesRec(minSize, maxSize)} ");
            System.Console.WriteLine();
            ShowNaturalValuesLoop(minSize, maxSize);
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
        static string ShowNaturalValuesRec(int minValues, int maxValues)
        {
            if (maxValues == minValues) return $"{minValues}";
            else return $"{ShowNaturalValuesRec(minValues, maxValues - 1)} {maxValues}";
        }
        static void ShowNaturalValuesLoop(int minValues, int maxValues)
        {
            for (int i = minValues; i <= maxValues; i++) Console.Write($"{i} ");
        }
    }
}