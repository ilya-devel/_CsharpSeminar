// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

using System;

namespace HomeWorks
{
    class TaskOne
    {
        static void Main()
        {
            var arr = GetArray(-100, -1);
            System.Console.WriteLine("Принят следующий массив:");
            ShowArray(arr);
            System.Console.WriteLine();
            System.Console.WriteLine($"Сумма чисел на нечётных позициях равна: {GetSummaryNumbersOfOddPosition(arr)}");
        }
        static int[] GetArray(int MinValue = 100, int Multiple = 10)
        {
            System.Console.WriteLine("Введите размер массива: ");
            bool check = Int32.TryParse(Console.ReadLine(), out int size);
            if (!check)
            {
                System.Console.WriteLine("Размер указан не корректно, принят размер по умолчанию (10)!");
                size = 10;
            }
            int[] array = new int[size];
            for (int i = 0; i < size; i++) array[i] = new Random().Next(MinValue, MinValue * Multiple);
            return array;
        }
        static void ShowArray(int[] array)
        {
            System.Console.Write("[ ");
            for (int i = 0; i < array.Length; i++)
            {
                if (i != array.Length - 1) System.Console.Write($"{array[i]}, ");
                else System.Console.Write($"{array[i]}");
            }
            System.Console.Write(" ]\n");
        }
        static int GetSummaryNumbersOfOddPosition(int[] array)
        {
            int summary = 0;
            for (int i = 1; i < array.Length; i = i + 2) summary += array[i];
            return summary;
        }
    }
}