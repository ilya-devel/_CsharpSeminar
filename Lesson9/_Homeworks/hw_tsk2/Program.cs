// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

using System;

namespace LessonNine
{
    class Program

    {
        static void Main()
        {
            int maxSize = GetSizeValues("максимальное значение");
            int minSize = GetSizeValues("минимальное значение");
            System.Console.WriteLine($"Вывод суммы элементов через рекурсию: {(maxSize > minSize ? ShowNaturalValuesRec(minSize, maxSize) : ShowNaturalValuesRec(maxSize, minSize))}");
            System.Console.WriteLine($"Вывод  суммы элементов через цикл: {(maxSize > minSize ? ShowNaturalValuesLoop(minSize, maxSize) : ShowNaturalValuesLoop(maxSize, minSize))}");
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
        static int ShowNaturalValuesRec(int minValues, int maxValues)
        {
            if (maxValues == minValues) return minValues;
            else return ShowNaturalValuesRec(minValues, maxValues - 1) + maxValues;
        }
        static int ShowNaturalValuesLoop(int minValues, int maxValues)
        {
            int summary = 0;
            for (int i = minValues; i <= maxValues; i++) summary += i;
            return summary;
        }
    }
}