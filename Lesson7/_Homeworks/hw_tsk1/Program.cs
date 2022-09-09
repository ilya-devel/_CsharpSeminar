// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

using System;

namespace LessonSeven
{
    class ExampleOne
    {
        static void Main()
        {
            int row = GetSizeValues("строк");
            int col = GetSizeValues("столбцов");
            double[,] arr = GetFill2DArray(row, col);
            System.Console.WriteLine();
            System.Console.WriteLine("Сгенерированный массив: ");
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
        static double[,] GetFill2DArray(int row, int col)
        {
            double[,] array = new double[row, col];
            for (int i = 0; i < row; i++) 
                for (int j = 0; j < col; j++) 
                    array[i, j] = (new Random().NextDouble())*(new Random().Next(-10, 11));
            return array;
        }
        static void Show2DArray(double[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++) System.Console.Write($" {array[i, j]:f2}\t");
                System.Console.WriteLine();
            }
        }
    }
}