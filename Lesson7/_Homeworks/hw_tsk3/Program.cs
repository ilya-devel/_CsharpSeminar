// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

using System;

namespace LessonSeven
{
    class ExampleOne
    {
        static void Main()
        {
            int row = GetIntegerValues("Введите количество строк: ");
            int col = GetIntegerValues("Введите количество столбцов: ");
            int[,] arr = GetFill2DArray(row, col);
            System.Console.WriteLine();
            System.Console.WriteLine("Сгенерированный массив: ");
            Show2DArray(arr);
            System.Console.WriteLine();
            FindMidValuesByColumnIn2DArray(arr);
        }
        static int GetIntegerValues(string key = "Введите целое число: ")
        {
            System.Console.WriteLine(key);
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
            for (int i = 0; i < row; i++) for (int j = 0; j < col; j++) 
            {
                array[i, j] = new Random().Next(1, 100);
            }
            return array;
        }
        static void Show2DArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++) System.Console.Write($" {array[i, j]:d2}\t");
                System.Console.WriteLine();
            }
        }
        static void FindMidValuesByColumnIn2DArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(1); i++)
            {
                double midValues = 0;
                for (int j = 0; j < array.GetLength(0); j++) midValues += array[j,i];
                System.Console.WriteLine($"Среднее арифметическое значение элементов по столбцу {i + 1} равно: {midValues/array.GetLength(0):f2}");
            }
        }
    }
}