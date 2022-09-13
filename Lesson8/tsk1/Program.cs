// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива

using System;

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
            ChangeRows(arr);
            System.Console.WriteLine();
            Show2DArray(arr);

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
            for (int i = 0; i < row; i++) for (int j = 0; j < col; j++) array[i,j] = new Random().Next(1, 100);
            return array;
        }
        static void Show2DArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++) 
            {
                for (int j = 0; j < array.GetLength(1); j++) System.Console.Write($" {array[i,j]:d2} ");
                System.Console.WriteLine();
            }
        }
        static int[,] ChangeRows(int[,] array)
        {
            int[] firstRow = new int[array.GetLength(1)];
            int[] lastRow = new int[array.GetLength(1)];
            for (int i = 0; i < array.GetLength(1); i++) firstRow[i] = array[0, i];
            for (int i = 0; i < array.GetLength(1); i++) lastRow[i] = array[array.GetLength(0) - 1, i];
            for (int i = 0; i < array.GetLength(1); i++) array[0,i] = lastRow[i];
            for (int i = 0; i < array.GetLength(1); i++) array[array.GetLength(0) - 1, i] = firstRow[i];
            return array;
        }
    }
}