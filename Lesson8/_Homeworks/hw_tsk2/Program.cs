// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

using System;
using System.Collections.Generic;

namespace LessonEight
{
    class Program

    {
        static void Main()
        {
            int row = GetSizeValues("строк");
            int col = GetSizeValues("столбцов");
            int[,] arr = GetFill2DArray(row, col);
            Show2DArray(arr);
            System.Console.WriteLine();
            GetRowWithMinimalSummary(arr);
            
        }
        static int GetSizeValues(string key = "элементов")
        {
            System.Console.WriteLine($"Введите количество {key}: ");
            bool check = Int32.TryParse(Console.ReadLine(), out int values);
            if (!check)
            {
                System.Console.WriteLine("Не верно указаны данные, принята величина по умолчанию (3)!");
                values = 3;
            }
            return values;
        }
        static int[,] GetFill2DArray(int row, int col)
        {
            int[,] array = new int[row, col];
            for (int i = 0; i < row; i++) for (int j = 0; j < col; j++) array[i, j] = new Random().Next(1, 10);
            return array;
        }
        static void Show2DArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++) System.Console.Write($" {array[i, j]} ");
                System.Console.WriteLine();
            }
        }
        static void GetRowWithMinimalSummary(int[,] array)
        {
            var sumRow = new Dictionary<int, int> ();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                int summary = 0;
                for (int j = 0; j < array.GetLength(1); j++) summary += array[i,j];
                sumRow.Add(summary, i);
            }
            int minimal = sumRow.Keys.ToArray()[0];
            foreach (var key in sumRow.Keys) if (key < minimal) minimal = key;
            System.Console.WriteLine($"Строка с наименьшей суммой ({minimal}) значений: {sumRow[minimal] + 1}");
        }
    }
}