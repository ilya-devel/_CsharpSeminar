// Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных

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
            HowMuchEveryValues(arr);
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
            for (int i = 0; i < row; i++) for (int j = 0; j < col; j++) array[i, j] = new Random().Next(1, 5);
            return array;
        }
        static void Show2DArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++) System.Console.Write($" {array[i, j]:d2} ");
                System.Console.WriteLine();
            }
        }
        static void HowMuchEveryValues(int[,] array)
        {
            var countValues = new Dictionary<int, int> ();
            for (int i = 0; i < array.GetLength(0); i++)
                for (int j = 0; j < array.GetLength(1); j++)
                    if (!countValues.ContainsKey(array[i,j])) countValues.Add(array[i,j], 1);
                    else countValues[array[i,j]] += 1;
            foreach (var (key, value) in countValues) System.Console.WriteLine($"{key} встречается {value} раза");
        }
    }
}