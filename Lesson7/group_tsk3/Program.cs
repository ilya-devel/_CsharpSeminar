// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д. Например, задан массив: 1 4 7 2 5 9 2 3 8 4 2 4 Сумма элементов главной диагонали: 1+9+2 = 12 

using System;

namespace LessonSeven
{
    class ExampleOne
    {
        static void Main()
        {
            int row = GetSizeValues("строк");
            int col = GetSizeValues("столбцов");
            int[,] arr = GetFill2DArray(row, col);
            Show2DArray(arr);
            System.Console.WriteLine();
            System.Console.WriteLine($"Сумма элементов на главной диагонали двумерного массива, равна: {SummaryValuesOfMainDiagon(arr)}");

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
            for (int i = 0; i < row; i++) for (int j = 0; j < col; j++) array[i, j] = new Random().Next(1, 25);
            return array;
        }
        static void Show2DArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++) System.Console.Write($" {array[i, j]}\t");
                System.Console.WriteLine();
            }
        }
        static int SummaryValuesOfMainDiagon(int[,] array)
        {
            int summary = 0;
            for (int i = 0; i < array.GetLength(0) && i < array.GetLength(1); i++) summary += array[i,i];
            return summary;
        }
    }
}